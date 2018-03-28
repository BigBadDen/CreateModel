using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreateModel
{
    /// <summary>
    /// 
    /// The code below creates a c# Model class corresponding to a json file, ensuring pascalCase / camelcase is used in correct places
    /// 
    ///     **** To create the models, run the application and hit "O"
    ///     **** To create the correspoding mapper code snippets,  run the application and hit "O"
    ///     
    /// 
    /// 
    ///     BEFORE RUNNING:
    ///     =================================================================
    ///     
    ///     1. Add individual files to the json folder - 1 per model 
    ///     2. Set _TARGET_NAMESPACE, to be used in class opening text
    ///     3. Set value of allModels string array - to correspond with items in the json folder
    ///     4. Set targetPath for the new class
    ///
    /// </summary>

    class Program
    {

        // ***BEFORE RUNNING*** set the name of the namespace where the models will reside

        private static string _TARGET_NAMESPACE = "StudyGroup.DataAPI.Models.AgentApplicationForm";


        // ***BEFORE RUNNING*** set the names of the models to be created:
        //
        // NB. IF these classes already exist in the target folder and are in TFS, check them out first!!

        private static string[] _allModels = new string[] { "CentreSelection",
                                                            "Confirmation",
                                                            "ContactDetails",
                                                            "DocumentUpload",
                                                            "EducationLanguage",
                                                            "Generic",
                                                            "OtherInformation",
                                                            "StudentDetails",
                                                            "IncompleteApplications"};

        static void Main(string[] args)
        {
            Console.WriteLine("Hit O to create object models");
            Console.WriteLine("Hit M to create mappers");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.O)
            {
                ModelGenerator modelgenerator = new ModelGenerator();
                modelgenerator.AllModels = _allModels;
                modelgenerator.Run();
            }
            else if (keyInfo.Key == ConsoleKey.M)
            {
                MapperGenerator mapper = new MapperGenerator();
                mapper.AllModels = _allModels;
                mapper.Run();
            }
        }
     
    }
}
