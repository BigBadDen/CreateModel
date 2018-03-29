using DataAPIGeneratorTemplate;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CreateModel
{
    class MapperGenerator : CodeGeneratorBase, IApiCodeGenerator
    {
        public void Run()
        {
            GenerateCode();
        }

        public void GenerateCode()
        {
            // ****************************************************************************************************************************

            string targetPath = @"D:\Git\CreateModel\CreateModel\Output\Mappers\";

            // ****************************************************************************************************************************

            foreach (string modelName in _allModels)
            {
                // load file & get json keys...

                string filePath = $@"D:\Git\CreateModel\CreateModel\Json\{modelName}.json";

                if (!File.Exists(filePath))
                {
                    Console.Write($"{filePath} does not exist!!!\n\n\n\n");
                }
                else
                {
                    Console.WriteLine("Reading from :" + filePath + "...\n\n");

                    string file = File.ReadAllText(filePath);

                    var theObject = JsonConvert.DeserializeObject(file);

                    JObject jsonObject = (JObject)theObject;

                    var allKeys = ((IDictionary<string, JToken>)jsonObject).Keys;

                    // generate a line of code to map the object field to the value of the sitecore item field

                    var allModelFields = allKeys.Select(k => CreateFieldMapping(k, modelName)).ToList<string>();

                    // write file...

                    string newFilePath = $@"{targetPath}{modelName}Mapper.cs";

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
            return $"{thePascalCaseFieldName} = FieldValueUtils.GetItemFieldValue({ToCamelCase(modelName)}Item,\"{ToPascalCaseWithSpaces(thePascalCaseFieldName)}\"),";
        }
     
    }
}
