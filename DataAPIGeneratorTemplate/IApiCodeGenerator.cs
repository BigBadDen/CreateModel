using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIGeneratorTemplate
{
    public interface IApiCodeGenerator
    {
        void GenerateCode();
        void Run();

        /// <summary>
        /// String array containing the name of all models. This should match the name of the json file in /Json folder and will be used to 
        /// form the name of the output mapper.cs and / or object model cs file
        /// </summary>
        string[] AllModels { get; set; }
    }
}
