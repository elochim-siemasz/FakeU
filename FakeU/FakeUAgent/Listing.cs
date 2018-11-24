﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace FakeUAgent
{
    public class Listing
    {
        public string title;
        public decimal price;
        public int id;
        public Uri uri;

        private string _desc;

        public HashSet<string> descKeywords
        {
            get
            {
                var charArr = _desc
                    .ToLower()
                    .Where((e) => Regex.IsMatch(e.ToString(), "[a-z|\\s]"))
                    .ToArray();

                var str = new string(charArr);

                var result = str
                    .Split(" ")
                    .ToHashSet();

                return result;
            }
        }
    }
}
