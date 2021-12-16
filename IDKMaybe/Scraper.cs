//Jayden Wigley
//Final C# Project
//12-15-21
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace IDKMaybe
{
    class Scraper
    {
        public string file = "";
        public void Rouletter(string url)
        {
            file = "";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            foreach (var rows in doc.DocumentNode.SelectNodes("//tr[@class]"))
            {
                var tier = HttpUtility.HtmlDecode(rows.SelectSingleNode(".//h3").InnerText.Trim());
                var name = HttpUtility.HtmlDecode(rows.SelectSingleNode(".//td//p").InnerText.Trim());
                var desc = HttpUtility.HtmlDecode(rows.SelectSingleNode(".//div[@class='formattedPerkDesc']").InnerText.Trim());
                var formattedDesc = Regex.Replace(desc, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
                var history = $"\n{name} ({tier} tier perk): {formattedDesc}";
                Debug.Print(history);
                file += history;
            }
        }
    }
}