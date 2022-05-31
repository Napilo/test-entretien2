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
        
        public static void Test2()
        {            
            List<string> input = new List<string> {"reza","eat", "tea", "tan", "ate", "nat", "bat", "bta", "azer"};

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            List<string> listModifie = input.Select(x => x).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                foreach (string item in dict.Keys)
                {
                    if (isAnagram(item, input[i]))
                    {
                        List<string> list = dict[item];
                        list.Add(input[i]);
                    }
                    else
                    {
                        dict.Add(input[i], new List<string>());
                    }

                }

                
                for (int j = i+1; i < input.Count; j++)
                {

                }
            }

        }

        private static bool isAnagram(string item, string s)
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            var input = new [] {1, 2, 7, 8, 11, 7};
            var sum = 20;
        }
    }
}
