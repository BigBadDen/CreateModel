using DataAPIGeneratorTemplate;
using System;


namespace CreateModel
{
    /// <summary>
    /// 
    /// The code below creates a c# Model class corresponding to a json file, ensuring pascalCase / camelcase is used in correct places
    /// 
    ///     **** To create the models, run the application and hit "O"
    ///     **** To create the correspoding mapper code snippets,  run the application and hit "O"
    /// 
    ///     BEFORE RUNNING:
    ///     =================================================================
    ///     
    ///     1. Add individual files to the json folder - 1 per model 
    ///     
    ///     2. Set/check _TARGET_NAMESPACE, to be used in class opening text (initialised in CreateModel\ModelGenerator.cs)
    ///     
    ///     3. Set/check value of allModels string array - to correspond with items in the json folder
    ///
    ///     4. Set targetPath for the new class in:     a) CreateModel\ModelGenerator.cs
    ///                                                 b) CreateModel\MapperGenerator.cs
    ///
    /// </summary>

    class Program
    {
        // ***BEFORE RUNNING*** set the names of the models to be created:
        //
        // NB. If the json files aren't found, they will be skipped
        //
        // IF these classes already exist in the target folder and are in TFS, check them out first!!
        //

        private static string[] _allModels = new string[] { "CentreSelection",
                                                            "Confirmation",
                                                            "ContactDetails",
                                                            "DocumentUpload",
                                                            "EducationLanguage",
                                                            "Generic",
                                                            "OtherInformation",
                                                            "StudentDetails",
                                                            "SecondParentContactDetails",
                                                            "IncompleteApplications"};

        static void Main(string[] args)
        {
            Console.WriteLine("Hit O to create object models");
            Console.WriteLine("Hit M to create mappers");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            IApiCodeGenerator codeGenerator;

            codeGenerator = new ModelGenerator();

            if (keyInfo.Key == ConsoleKey.O)
            {
                codeGenerator = new ModelGenerator();
            }
            else if (keyInfo.Key == ConsoleKey.M)
            {
                codeGenerator = new MapperGenerator();
            }

            codeGenerator.AllModels = _allModels;
            codeGenerator.Run();
        }
     
    }
}
