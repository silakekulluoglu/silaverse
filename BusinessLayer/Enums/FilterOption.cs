using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{

    [AttributeUsage(AttributeTargets.Field)]
    public class FilterDataAttribute : Attribute
    {
        public string Sort { get; set; }
        public string PostedAfter { get; set; }
        public string Category { get; set; }
        public bool IsEdu { get; set; }
        public string Subject { get; set; }
        public string GradeLevel { get; set; }
        public string Standard { get; set; }
        public string License { get; set; } 

        public bool Customizable { get; set; }
        public bool ShowCustomizedCreations { get; set; }
        public bool OrderPrint { get; set; }
        public bool HasMakes { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsChallangeWinner { get; set; }
        public bool IsDerivative { get; set; }
        // Diğer filtreleri burada ekleyebilirsiniz
    }
    public enum FilterOption
    {
        [FilterData(Sort = "popular", PostedAfter = "now-30d")]
        Last30Days,

        [FilterData(Sort = "popular", PostedAfter = "now-7d")]
        Last7Days,

        [FilterData(Sort = "popular", PostedAfter = "now-365d")]
        ThisYear,

        [FilterData(Sort = "popular")]
        AllTime,

        [FilterData(Sort = "newest")]
        Newest,

        [FilterData(Sort = "makes")]
        Makes,

        [FilterData(Category = "")]
        AllThings,

        [FilterData(Category = "73")]
        Category3DPrinting,

        [FilterData(Category = "127")]
        Category3DPrintingAccessories,

        [FilterData(Category = "152")]
        Category3DPrintingExtruders,

        [FilterData(Category = "128")]
        Category3DPrintingParts,

        [FilterData(Category = "126")]
        Category3DPrintingPrinters,

        [FilterData(Category = "129")]
        Category3DPrintingTests,

        [FilterData(Category = "63")]
        CategoryArt,

        [FilterData(Category = "144")]
        CategoryArt2D,

        [FilterData(Category = "75")]
        CategoryArtTools,

        [FilterData(Category = "143")]
        CategoryArtCB,

        [FilterData(Category = "78")]
        CategoryArtInteractive,

        [FilterData(Category = "79")]
        CategoryArtMath,

        [FilterData(Category = "145")]
        CategoryArtSR,

        [FilterData(Category = "80")]
        CategoryArtSculptures,

        [FilterData(Category = "76")]
        CategoryArtSL,

        [FilterData(Category = "64")]
        CategoryFashion,

        [FilterData(Category = "81")]
        CategoryFashionAccessories,

        [FilterData(Category = "82")]
        CategoryFashionBracelets,

        [FilterData(Category = "142")]
        CategoryFashionCostume,

        [FilterData(Category = "139")]
        CategoryFashionEarrings,

        [FilterData(Category = "83")]
        CategoryFashionGlasses,

        [FilterData(Category = "84")]
        CategoryFashionJewelry,

        [FilterData(Category = "130")]
        CategoryFashionKeychains,

        [FilterData(Category = "85")]
        CategoryFashionRings,

        [FilterData(Category = "65")]
        CategoryGadgets,


        [FilterData(Category = "141")]
        CategoryGadgetsAudio,


        [FilterData(Category = "86")]
        CategoryGadgetsCamera,


        [FilterData(Category = "87")]
        CategoryGadgetsComputer,


        [FilterData(Category = "88")]
        CategoryGadgetsPhone,


        [FilterData(Category = "90")]
        CategoryGadgetsTablet,

        [FilterData(Category = "91")]
        CategoryGadgetsTabletVG,

        [FilterData(Category = "66")]
        CategoryHobby,

        [FilterData(Category = "155")]
        CategoryHobbyAutomotive,

        [FilterData(Category = "93")]
        CategoryHobbyDIY,

        [FilterData(Category = "92")]
        CategoryHobbyElectronics,

        [FilterData(Category = "94")]
        CategoryHobbyMusic,

        [FilterData(Category = "95")]
        CategoryHobbyRCVehicles,

        [FilterData(Category = "96")]
        CategoryHobbyRobotics,

        [FilterData(Category = "140")]
        CategoryHobbySO,

        [FilterData(Category = "67")]
        CategoryHousehold,

        [FilterData(Category = "147")]
        CategoryHouseholdBathroom,

        [FilterData(Category = "146")]
        CategoryHouseholdContainers,

        [FilterData(Category = "97")]
        CategoryHouseholdDecor,

        [FilterData(Category = "99")]
        CategoryHouseholdSupplies,

        [FilterData(Category = "100")]
        CategoryHouseholdKD,

        [FilterData(Category = "101")]
        CategoryHouseholdOO,

        [FilterData(Category = "98")]
        CategoryHouseholdOG,

        [FilterData(Category = "103")]
        CategoryHouseholdPets,

        [FilterData(Category = "69")]
        CategoryLearning,

        [FilterData(Category = "106")]
        CategoryLearningBiology,

        [FilterData(Category = "104")]
        CategoryLearningEngineering,

        [FilterData(Category = "105")]
        CategoryLearningMath,

        [FilterData(Category = "148")]
        CategoryLearningPA,

        [FilterData(Category = "70")]
        CategoryModels,

        [FilterData(Category = "107")]
        CategoryModelsAnimals,

        [FilterData(Category = "108")]
        CategoryModelsBS,

        [FilterData(Category = "109")]
        CategoryModelsCreatures,

        [FilterData(Category = "110")]
        CategoryModelsFD,

        [FilterData(Category = "111")]
        CategoryModelsFurniture,

        [FilterData(Category = "115")]
        CategoryModelsRobots,

        [FilterData(Category = "112")]
        CategoryModelsPeople,

        [FilterData(Category = "114")]
        CategoryModelsProps,

        [FilterData(Category = "116")]
        CategoryModelsVehicles,

        [FilterData(Category = "71")]
        CategoryTools,

        [FilterData(Category = "118")]
        CategoryToolsHand,

        [FilterData(Category = "117")]
        CategoryToolsMachine,

        [FilterData(Category = "120")]
        CategoryToolsHB,

        [FilterData(Category = "72")]
        CategoryToysGames,

        [FilterData(Category = "151")]
        CategoryToysGamesChess,

        [FilterData(Category = "121")]
        CategoryToysGamesCT,

        [FilterData(Category = "122")]
        CategoryToysGamesDice,

        [FilterData(Category = "123")]
        CategoryToysGamesGames,

        [FilterData(Category = "124")]
        CategoryToysGamesMT,

        [FilterData(Category = "113")]
        CategoryToysGamesPlaysets,

        [FilterData(Category = "125")]
        CategoryToysGamesPuzzles,

        [FilterData(Category = "149")]
        CategoryToysGamesAccessories,

        [FilterData(Category = "0")]
        CategoryOther,

        [FilterData(IsEdu = true)]
        IsEdu,

        [FilterData(Subject = "11")]
        Science,

        [FilterData(Subject = "12")]
        Math,

        [FilterData(Subject = "13")]
        Engineering,

        [FilterData(Subject = "14")]
        History,

        [FilterData(Subject = "15")]
        Geography,

        [FilterData(Subject = "16")]
        Art,

        [FilterData(Subject = "17")]
        Languages,

        [FilterData(Subject = "18")]
        Music,

        [FilterData(Subject = "19")]
        Technology,

        [FilterData(Subject = "20")]
        SpecialEd,

        [FilterData(GradeLevel = "15")]
        Kindergarten,

        [FilterData(GradeLevel = "16")]
        Grade1st,

        [FilterData(GradeLevel = "17")]
        Grade2nd,

        [FilterData(GradeLevel = "18")]
        Grade3rd,

        [FilterData(GradeLevel = "19")]
        Grade4th,

        [FilterData(GradeLevel = "20")]
        Grade5th,

        [FilterData(GradeLevel = "21")]
        Grade6th,

        [FilterData(GradeLevel = "22")]
        Grade7th,

        [FilterData(GradeLevel = "23")]
        Grade8th,

        [FilterData(GradeLevel = "24")]
        Grade9th,

        [FilterData(GradeLevel = "25")]
        Grade10th,

        [FilterData(GradeLevel = "26")]
        Grade11th,

        [FilterData(GradeLevel = "27")]
        Grade12th,

        [FilterData(GradeLevel = "28")]
        EducationHigher,

        [FilterData(Standard = "3")]
        NGSS,

        [FilterData(Standard = "4")]
        CCSS,

        [FilterData(License = "cc")]
        Cc,

        [FilterData(License = "cc-sa")]
        CcSa,

        [FilterData(License = "cc-nd")]
        CcNd,

        [FilterData(License = "cc-nc")]
        CcNc,

        [FilterData(License = "cc-nc-sa")]
        CcNcSa,

        [FilterData(License = "cc-nc-nd")]
        CcNcNd,

        [FilterData(License = "pd0")]
        PublicDomainDedication,

        [FilterData(License = "gpl")]
        GNU_GPL,

        [FilterData(License = "lgpl")]
        GNU_LGPL,

        [FilterData(License = "bsd")]
        BSDLicense,

        [FilterData(License = "none")]
        AllRightsReserved,

        [FilterData(License = "nokia")]
        Nokia,

        [FilterData(License = "public")]
        PublicDomain,

        [FilterData(Customizable = true)]
        Customizable,

        [FilterData(ShowCustomizedCreations = true)]
        ShowCustomizedCreations,

        [FilterData(OrderPrint = true)]
        OrderPrint,

        [FilterData(HasMakes = true)]
        HasMakes,

        [FilterData(IsFeatured = true)]
        IsFeatured,

        [FilterData(IsChallangeWinner = true)]
        IsChallangeWinner,

        [FilterData(IsDerivative = true)]
        IsDerivative
    }
}

