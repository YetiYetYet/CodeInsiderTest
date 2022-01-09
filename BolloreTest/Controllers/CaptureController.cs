using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Text.RegularExpressions;

namespace BolloreTest.Controllers
{
    public delegate string Picker();
    public class CaptureController: Controller
    {
        public static Picker getPicker(string input, string pattern)
        {
            Picker picker;

            if (input == null || pattern == null)
            {
                picker = delegate()
                {
                    return (null);
                };
                return (picker);
            }
            //Construit un pattern regex pour ne matcher qu'une seule ligne
            if (!pattern.StartsWith("^")) pattern = "^" + pattern;
            if (!pattern.EndsWith("$")) pattern = pattern + "$";

            //Il cherche le pattern dans l'unput donné
            var enumerator = Regex.Matches(input, pattern, RegexOptions.Singleline).GetEnumerator();
            //Il arrive au premier résultat dponné par la recherche
            enumerator.MoveNext();


            picker = delegate()
            {
                //Récupère le troisème occurence d
                string result = enumerator.MoveNext() ? enumerator.Current.ToString() : null;
                return (result);
            };

            return (picker);
        }

        public string Capture()
        {
            var res = getPicker("toto \ntata\n toto\n tata", "toto");
            return res();
        }
    }
}