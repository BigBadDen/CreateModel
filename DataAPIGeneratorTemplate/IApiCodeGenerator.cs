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

        string[] AllModels { get; set; }
    }
}
