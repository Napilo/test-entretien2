using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestAlgo
    {

        /// <summary>
        /// grouper les anagrammes 
        /// 10 min
        /// </summary>
        public static void Test1()
        {            
            List<List<int>> datas = new List<List<int>>()
            {
                new List<int>() { 1,2,3,4,5,6,7,8,9},
                new List<int>() { 6,10,11,8,13,14,15,23},
                new List<int>() { 6,23,7,8},
                new List<int>() { 2,50,100,88},
            };             
        }
        
        public static Dictionary<string, List<string>> Test2()
        {            
            List<string> input = new List<string> {"reza","eat", "tea", "tan", "ffgtfrteghgg" , "ate", "nat", "bat", "bta", "azer", "hrgefftgggtf"};

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < input.Count; i++)
            {
                string charArrayToString = new string(input[i].ToCharArray().OrderBy(x => x).ToArray());

                if (dict.ContainsKey(charArrayToString))
                {
                    List<string> list = dict[charArrayToString];
                    list.Add(input[i]);
                }
                else
                {
                    List<string> list = new List<string> { input[i] };
                    dict.Add(charArrayToString, list);
                }
            }

            return dict;

        }


        public void Test3()
        {
            var input = new [] {1, 2, 7, 8, 11, 7};
            var sum = 20;
        }
    }
}
