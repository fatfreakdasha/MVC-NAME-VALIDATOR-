using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationOfFullName
{
     class NameValidatorModel
    {
       
           private string name;

            public NameValidatorModel(string name)
            {
                this.name = name;
            }

            public bool IsValid()
            {
                if (string.IsNullOrEmpty(name))
                {
                    return false;
                }

                string[] nameParts = name.Split();
                if (nameParts.Length != 3)
                {
                    return false;
                }

                foreach (string part in nameParts)
                {
                    if (!Regex.IsMatch(part, @"^[а-яА-Я]+$"))
                    {
                        return false;
                    }
                }

                return true;
            }
        

    }
}
