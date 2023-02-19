using Newtonsoft.Json.Linq;
using System;
using System.Xml.Linq;

public class RandomUniqueCodeGenerate
{
    public static void Main(string[] args)
    {
        var json = System.IO.File.ReadAllText(@"c:\test.json");

        var objects = JArray.Parse(json); // parse as array  
        foreach (JObject root in objects)
        {
            foreach (KeyValuePair<String, JToken> app in root)
            {
                var value1 = (String)app.Value["Value1"];//parse process
                var value2 = (String)app.Value["Value2"];
                var value3 = (String)app.Value["Value3"];
                var value4 = (String)app.Value["Value4"];
                var value5 = (String)app.Value["Value5"];
                var value6 = (String)app.Value["Value6"];
                var value7 = (String)app.Value["Value7"];
                var value8 = (String)app.Value["Value8"];
                var value9 = (String)app.Value["Value9"];
                var value10 = (String)app.Value["Value10"];

                Dictionary<string, int> AuthorList = new Dictionary<string, int>();

                AuthorList.Add(value1, 1); //row number add
                AuthorList.Add(value2, 2);
                AuthorList.Add(value3, 3);
                AuthorList.Add(value4, 4);
                AuthorList.Add(value5, 5);
                AuthorList.Add(value6, 6);
                AuthorList.Add(value7, 7);
                AuthorList.Add(value8, 8);
                AuthorList.Add(value9, 9);
                AuthorList.Add(value10, 10);

                foreach (KeyValuePair<string, int> author in AuthorList)
                {
                    Console.WriteLine("row: {1}, text: {0}",
                        author.Key, author.Value);
                }

                Console.ReadKey();
                
            }
        }
    }
}