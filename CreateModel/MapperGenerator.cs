using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateModel
{
    class MapperGenerator
    {
        private static string[] _allModels; 

        public string[]  AllModels
        {
            get { return _allModels; }
            set { _allModels = value; }
        }

        public void Run()
        {
            GenerateCode();
        }

        private static void GenerateCode()
        {
            // ****************************************************************************************************************************

            string targetPath = @"D:\Git\CreateModel\CreateModel\Output\Mappers\";

            // ****************************************************************************************************************************

            foreach (string modelName in _allModels)
            {
                // load file & get json keys...

                string filePath = String.Format(@"D:\Git\CreateModel\CreateModel\Json\{0}.json", modelName);

              

                if (!File.Exists(filePath))
                {
                    Console.Write($"{filePath} does not exist!!!\n\n\n\n");
                }
                else
                {
                    Console.WriteLine("Reading from :" + filePath + "...\n\n");

                    string file = File.ReadAllText(filePath);

                    var theObject = JsonConvert.DeserializeObject(file);

                    Newtonsoft.Json.Linq.JObject jsonObject = (Newtonsoft.Json.Linq.JObject)theObject;

                    var allKeys = ((IDictionary<string, Newtonsoft.Json.Linq.JToken>)jsonObject).Keys;

                    // generate a line of code to map the object field to the value of the sitecore item field

                    var allModelFields = allKeys.Select(k => CreateFieldMapping(k, modelName)).ToList<string>();

                    // write file...

                    string newFilePath = String.Format(@"{0}{1}Mapper.cs", targetPath, modelName);

                    Console.WriteLine("Writing to:" + newFilePath + "\n\n");

                    File.WriteAllLines(newFilePath, allModelFields);

                    Console.WriteLine("Hit escape quit or any other key to continue");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }

        private static string CreateFieldMapping(string theCamelCaseFieldName, string modelName)
        {
            string thePascalCaseFieldName = ToPascalCase(theCamelCaseFieldName);

            StringBuilder propertyString = new StringBuilder();
            propertyString.Append(String.Format("{0} = FieldValueUtils.GetItemFieldValue({1}Item,\"{2}\"),", thePascalCaseFieldName, ToCamelCase(modelName), ToPascalCaseWithSpaces(thePascalCaseFieldName)));
            return propertyString.ToString();
        }

        private static string ToPascalCaseWithSpaces(string thePascalCaseField)
        {
            StringBuilder fieldWithSpaces = new StringBuilder();

            for (int i=0; i<thePascalCaseField.Length; i++)
            {
                string theCurrentChar = thePascalCaseField.Substring(i, 1);
                if (theCurrentChar  == theCurrentChar.ToUpper() && i > 0)
                {
                    fieldWithSpaces.Append(" ");
                }
                fieldWithSpaces.Append(theCurrentChar);
            }
            return fieldWithSpaces.ToString().Replace("I E L T S", "IELTS")
                .Replace("Dob D D", "Dob DD")
                .Replace("Dob M M", "Dob MM")
                .Replace("Dob Y Y Y Y", "Dob YYYY")
                .Replace("D D Placeholder", "DD Placeholder")
                .Replace("M M Placeholder", "MM Placeholder")
                .Replace("Y Y Y Y Placeholder", "YYYY Placeholder")
                .Replace("U K Visa", "UK Visa")
                ;
        }

        private static string ToPascalCase(string theField)
        {
            string firstChar = theField.Substring(0, 1);
            string remaiainingChars = theField.Substring(1, theField.Length - 1);
            return firstChar.ToUpper() + remaiainingChars;
        }

        private static string ToCamelCase(string theField)
        {
            string firstChar = theField.Substring(0, 1);
            string remaiainingChars = theField.Substring(1, theField.Length - 1);
            return firstChar.ToLower() + remaiainingChars;
        }
    }
}
