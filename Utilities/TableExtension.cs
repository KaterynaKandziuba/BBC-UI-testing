using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Kandziuba_SpecFlow.Utilities
{
    class TableExtension
    {

        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }

        public static List<string> ToList(Table table)
        {
            var list = new List<string>();
            foreach(var row in table.Rows)
            {
                list.Add(row[0]);
            }
            return list;
        }
    }
}
