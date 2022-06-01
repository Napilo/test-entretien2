using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestLinq
    {        
        public static char FindCharWithMaxOccurence()
        {
            List<string> input = new List<string>()
            {
                "aabcccccooooooooooo",
                "ddflfccccc",
                //"zzzzzzzzzzzzzzzzzzz"
            };


            //char[] c = input.First().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            List<char> listChar = input.SelectMany(t => t.ToCharArray()).ToList();
            listChar.Aggregate(dict, (x, y) =>
            {
                if (x.ContainsKey(y))
                {
                    dict[y]++;
                }
                else
                {
                    dict.Add(y, 1);
                }

                return dict;
            });

            char myChar = dict.First(x => x.Value == dict.Values.Max()).Key;
            return myChar;
        }
        public static void Test2()
        {
            string input = "aabacccz";
            /* RESULTAT ATTENDU
            /*
            3 : a,c
            *********
            1 : b,z
            */
            //            
        }
        public static void MergeIndexAndRemoveDuplicate()
        {
            /* RESULTAT ATTENDU
            * 
            * Dictionary<string, List<int>> c = new Dictionary<string, List<int>>()
           {

               {"a", {1} },{"b", {45}, {"c",{45,22,30} }
           };
           */

            List<Dictionary<string, int>> input = new List<Dictionary<string, int>>()
            {
                new Dictionary<string, int>()
                {
                    {"a",1 },{"b",20},{"c",45}
                },
                new Dictionary<string, int>()
                {
                    {"a",10 },{"c",22},{"b",45}
                },
                new Dictionary<string, int>()
                {
                    {"a",10 },{"c",30},{"b",20}
                }
            };
        }
            
        

        }
    }
