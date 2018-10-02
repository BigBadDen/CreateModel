using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using DataAPIGeneratorTemplate;

namespace ModelAndMapperGenerator
{

    class ModelGenerator : CodeGeneratorBase, IApiCodeGenerator
    {
        public void Run()
        {
            GenerateCode();
        }

        private static string _TARGET_NAMESPACE = "StudyGroup.DataAPI.Models.AgentApplicationForm";

        public void GenerateCode()
        {
            // ***BEFORE RUNNING*** SET WHERE THE OBJECT MODELS SHOULD BE CREATED:

            string targetPath = @"D:\Git\ModelAndMapperGenerator\ModelAndMapperGenerator\Output\Models\";
            //string targetPath = @"D:\Projects\Websites\SitecoreV8Upg\SiteCore\StudyGroup.DataAPI\Models\AgentApplicationForm\";

            foreach (string modelName in _allModels)
            {
                // load file & get json keys...

                string filePath = $@"D:\Git\ModelAndMapperGenerator\ModelAndMapperGenerator\Json\{modelName}.json";

                if (!File.Exists(filePath))
                {
                    Console.Write($"{filePath} does not exist!!!\n\n\n\n");
                }
                else
                {
                    Console.WriteLine("Reading from :" + filePath + "...\n");

                    string file = File.ReadAllText(filePath);

                    var theObject = JsonConvert.DeserializeObject(file);

                    Newtonsoft.Json.Linq.JObject jsonObject = (Newtonsoft.Json.Linq.JObject)theObject;

                    var allKeys = ((IDictionary<string, Newtonsoft.Json.Linq.JToken>)jsonObject).Keys;

                    // convert to required format for model declaration...

                    string opener = GetClassStartText(modelName);
                    var allModelFields = allKeys.Select(k => ConvertToFieldDeclaration(k)).ToList<string>();

                    // add class start & end text

                    allModelFields.Insert(0, opener);
                    allModelFields.Add(GetClassEnd());

                    // write file...

                    string newFilePath = String.Format(@"{0}{1}Object.cs", targetPath, modelName);


                    Console.WriteLine("Writing to:" + newFilePath + "\n\n");
                    //Console.WriteLine(String.Join("", allModelFields));

                    File.WriteAllLines(newFilePath, allModelFields);

                    //File.AppendAllLines(newFilePath, allModelFields);

                    Console.WriteLine("Hit escape quit or any other key to continue");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
              
            }
        }

        private static string GetClassStartText(string modelName)
        {
            StringBuilder returnString = new StringBuilder();

            returnString.Append("using System.Xml;\n");
            returnString.Append("using System.Xml.Serialization;\n");
            returnString.Append("using Newtonsoft.Json;\n");
            returnString.Append("\n");

            returnString.Append($"namespace {_TARGET_NAMESPACE}\n");
            returnString.Append("{\n");
            returnString.Append("\n");
            returnString.Append($"\tpublic class {modelName}Object\n");
            returnString.Append("\t{\n");

            return returnString.ToString();
        }

        private static string GetClassEnd()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.Append("\t}\n");
            returnString.Append("}\n");
            return returnString.ToString();
        }

        private static string ConvertToFieldDeclaration(string theCamelCaseFieldName)
        {

            StringBuilder propertyString = new StringBuilder();

            propertyString.Append(String.Format("\t\t[JsonProperty(\"{0}\")]\n", theCamelCaseFieldName));
            propertyString.Append(String.Format("\t\t[XmlElement(\"{0}\")]\n", ToPascalCase(theCamelCaseFieldName)));

            propertyString.Append("\t\tpublic string ");
            propertyString.Append(ToPascalCase(theCamelCaseFieldName));
            propertyString.Append("{\n");

            propertyString.Append("\t\t\tget;\n");
            propertyString.Append("\t\t\tset;\n");
            propertyString.Append("\t\t}\n");

            return propertyString.ToString();
        }

 
    }
}
