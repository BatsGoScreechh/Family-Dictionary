using System;
using System.Collections.Generic;
using System.Collections;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define a Dictionary that contains information about several members of your family. Use the following example as a template.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();



            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Casey"},
            {"age", "26"}});

            myFamily.Add("mother", new Dictionary<string, string>(){
            {"name", "Katrina"},
            {"age", "51"}});


            // Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                var value = familyMember.Value;

                    Console.WriteLine($"{value["name"]} is my {familyMember.Key} and is {value["age"]} years old.");

                // Console.WriteLine(familyMember.Value);

            }
        }
    }
}


