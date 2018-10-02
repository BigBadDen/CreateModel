using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAPIGeneratorTemplate
{
    public abstract class CodeGeneratorBase
    {
        public static string[] _allModels;

        public string[] AllModels
        {
            get { return _allModels; }
            set { _allModels = value; }
        }

        public static string ToPascalCase(string theField)
        {
            string firstChar = theField.Substring(0, 1);
            string remaiainingChars = theField.Substring(1, theField.Length - 1);
            return firstChar.ToUpper() + remaiainingChars;
        }


        public static string ToPascalCaseWithSpaces(string thePascalCaseField)
        {
            StringBuilder fieldWithSpaces = new StringBuilder();

            for (int i = 0; i < thePascalCaseField.Length; i++)
            {
                string theCurrentChar = thePascalCaseField.Substring(i, 1);
                if (theCurrentChar == theCurrentChar.ToUpper() && i > 0)
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
                .Replace("U S", "US")
                .Replace("U R N", "URN")
                .Replace("A N Z", "ANZ")
                .Replace("H E N A", "HENA")
                .Replace("We Chat","WeChat")
                ;
        }

        public static string ToCamelCase(string theField)
        {
            string firstChar = theField.Substring(0, 1);
            string remaiainingChars = theField.Substring(1, theField.Length - 1);
            return firstChar.ToLower() + remaiainingChars;
        }
    }
}
