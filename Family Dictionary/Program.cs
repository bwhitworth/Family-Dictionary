using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Define a Dictionary that contains information about several members of your family (include relationship as key, name and age as properties).
            
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("oldestSister", new Dictionary<string, string>() { { "name", "Ashley" }, { "age", "25" } });
            myFamily.Add("youngestSister", new Dictionary<string, string>() { { "name", "Tabitha" }, { "age", "20" } });
            myFamily.Add("youngestDog", new Dictionary<string, string>() { { "name", "Bug" }, { "age", "7" } });
            myFamily.Add("oldestDog", new Dictionary<string, string>() { { "name", "Mylo" }, { "age", "12" } });

            // 2. Next, iterate over each item in myFamily and produce the following output:
            // "Krista is my sister and is 42 years old"

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");

            }
        }
    }
}
