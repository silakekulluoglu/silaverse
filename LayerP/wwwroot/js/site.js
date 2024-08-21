// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var prevSearchTerm = '';
$(document).ready(function () {
    let currentSearchTerm;
    let lastSelectedMainCategory = '';
    // prevSearchTerm = $('#currentSearchTerm').val();
    $('#searchInput').on('keypress', function (event) {
        if (event.which == 13) {
            currentSearchTerm = $('#searchInput').val();

            if (currentSearchTerm == undefined || currentSearchTerm == null) {
                currentSearchTerm = prevSearchTerm;
            }
            else {
                prevSearchTerm = currentSearchTerm;
            }

            event.preventDefault();
            updateFilters(null, currentSearchTerm);
        }
    });

    $('#MainCategory').on('change', function () {
        var selectedOption = $(this).find(':selected');
        var selectedMainCategory = selectedOption.text();
        var isMainCategory = selectedOption.hasClass('main-category');

        console.log("selected category:" + selectedMainCategory);

        if (isMainCategory && selectedMainCategory !== lastSelectedMainCategory) {
            // Ana kategori değiştiğinde tüm alt kategorileri gizle
            $('#MainCategory option.sub-category').hide();

            // Yeni seçilen ana kategoriye ait alt kategorileri göster
            $('#MainCategory option.sub-category[data-main-category="' + selectedMainCategory + '"]').show();

            // Son seçilen ana kategoriyi güncelle
            lastSelectedMainCategory = selectedMainCategory;
        }
    });

    $('.multiples').on('mousedown', 'option', function (e) {
        e.preventDefault();

        // Seçim durumunu tersine çevir
        $(this).prop('selected', !$(this).prop('selected'));

        // Seçim değişikliğini tetikle
        $(this).parent().trigger('change');

        return false;
    });

    $('#Filters').on('change', function () {
        if ($('#searchInput').val() == "") {
            updateFilters(null, currentSearchTerm);
        }
        else {
            updateFilters(null, $('#searchInput').val());
        }
    });

    function updateFilters(categoryOverride, searchTerm) {

        var formData = $('#Filters').serializeArray();
        var jsonData = {};
        var apiUrl;

        $.each(formData, function () {
            if (this.name == "Subjects" || this.name == "GradeLevels" || this.name == "Standards") {
                if (!jsonData[this.name]) {
                    jsonData[this.name] = [];
                }
                jsonData[this.name].push(parseInt(this.value, 10) || '');
            }
            else {
                jsonData[this.name] = parseInt(this.value, 10) || '';
            }
        });


        if (searchTerm && searchTerm !== "") {

            $(".mainpage").hide().prop("disabled", true);
            $(".searchpage").show().prop("disabled", false);

            jsonData["SearchTerm"] = searchTerm;
        }
        if ((prevSearchTerm != null && prevSearchTerm != "" && prevSearchTerm != undefined)
            && currentSearchTerm == null || currentSearchTerm == "" || currentSearchTerm == undefined) {
            $(".mainpage").show().prop("disabled", false);
            $(".searchpage").hide().prop("disabled", true);
        }

        console.log("apiUrl: " + apiUrl);
        console.log("jsonData: " + JSON.stringify(jsonData));

        $.ajax({
            url: '/Home/PopularJson',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(jsonData),
            success: function (result) {
                // Partial view'ı sayfanın ilgili bölümüne ekle
                $('#content').html(result);

                // URL'i güncellemek için History API'yi kullan
                if (searchTerm != undefined && searchTerm != null && searchTerm != "") {
                    var newUrl = '/Search?q=' + encodeURIComponent(searchTerm);
                    history.pushState(null, '', newUrl);
                }
            },
            error: function (error) {
                console.log('Error:', error);
            }
        });
        
    }
    
});