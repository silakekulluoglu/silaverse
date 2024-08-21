using BusinessLayer.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Helpers
{
    public class helper
    {
        public static bool IsEmptyOrZero(object value)
        {
            if (value == null)
                return true;

            Type type = value.GetType();

            if (type == typeof(string))
                return string.IsNullOrEmpty((string)value);

            if (type == typeof(int))
                return (int)value == 0;

            if (type == typeof(bool))
                return !(bool)value;

            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                var enumerable = (IEnumerable)value;
                return !enumerable.GetEnumerator().MoveNext();
            }

            if (type.IsEnum)
            {
                // Enum'ın ilk değerinin "Any" olduğunu varsayıyoruz
                return (int)value == 1;
            }
            // For other types, you might want to define what "empty" means
            return false;
        }

        public static string GetQuery(string parameter, string value)
        {
            switch (parameter)
            {
                case "PostedAfter":
                    if (value == "7")
                        return "&sort=popular&posted_after=now-7d";
                    else if (value == "30")
                        return "&sort=popular&posted_after=now-30d";
                    else if (value == "365")
                        return "&sort=popular&posted_after=now-365d";
                    else if (value == "4")
                        return "&sort=popular";
                    else if (value == "2")
                        return "&sort=newest";
                    else if (value == "3")
                        return "&sort=makes";
                    else if (value == "5")
                        return "&sort=relevant";
                    else if (value == "6")
                        return "&sort=text";
                    else
                        return "";
                case "MainCategory":
                    if (value == "-1")
                        return $"&category_id=0";
                    else
                        return $"&category_id={value}";
                case "IsEdu":
                    return $"&is_edu_approved={value}";
                case "Customizable":
                    return $"&customizable={value}";
                case "ShowCustomizedCreations":
                    return $"&show_customized={value}";
                case "OrderPrint":
                    return $"&order_print={value}";
                case "HasMakes":
                    return $"&has_makes={value}";
                case "IsFeatured":
                    return $"&is_featured={value}";
                case "IsChallangeWinner":
                    return $"&is_challenge_winner={value}";
                case "IsDerivative":
                    return $"&is_derivative={value}";
                case "License":
                    if (value == "2")
                        return "&license=cc";
                    else if (value == "3")
                        return "&license=cc-sa";
                    else if (value == "4")
                        return "&license=cc-nd";
                    else if (value == "5")
                        return "&license=cc-nc";
                    else if (value == "6")
                        return "&license=cc-nc-sa";
                    else if (value == "7")
                        return "&license=cc-nc-nd";
                    else if (value == "8")
                        return "&license=pd0";
                    else if (value == "9")
                        return "&license=gpl";
                    else if (value == "10")
                        return "&license=lgpl";
                    else if (value == "11")
                        return "&license=bsd";
                    else if (value == "12")
                        return "&license=none";
                    else if (value == "13")
                        return "&license=nokia";
                    else if (value == "14")
                        return "&license=public";
                    else
                        return "";
                case "Standards":
                    return $"&standards={value}";
                case "GradeLevels":
                    return $"&grades={value}";
                case "Subjects":
                    return $"&subjects={value}";
            }
            return "";
        }

        public static string ConstructEndpoint(FiltersDto filters)
        {
            var endpoint = "";
            foreach (var property in typeof(FiltersDto).GetProperties())
            {
                var value = property.GetValue(filters);
                var name = property.Name;

                if (name.ToString() == "SearchTerm")
                    continue;

                if (!helper.IsEmptyOrZero(value))
                {
                    if (value.GetType() != typeof(string) && typeof(IEnumerable).IsAssignableFrom(value.GetType()))
                    {
                        foreach (var item in (IEnumerable)value)
                        {
                            endpoint += helper.GetQuery(name.ToString(), ((int)item).ToString());
                        }
                    }
                    else
                    {
                        endpoint += helper.GetQuery(name.ToString(), ((int)value).ToString());
                    }

                }
            }
            Console.WriteLine(endpoint);
            return endpoint;
        }
    }
}
