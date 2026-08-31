using System;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
namespace JSONDataHandling
{
	public class JSONHANDLING
	{
        static void CreateStudentJson()
        {
            JObject student = new JObject
            {
                ["name"] = "Nakul",
                ["age"] = 20,
                ["subjects"] = new JArray
        {
            "C#",
            "Java",
            "DBMS"
        }
            };

            Console.WriteLine(student);
        }
    }
}

