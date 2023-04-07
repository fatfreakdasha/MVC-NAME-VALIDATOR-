using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationOfFullName
{
     class NameValidatorView
    {
        
            public string GetNameInput()
            {
                Console.Write("введите ФИО: ");
                return Console.ReadLine();
            }

            public void ShowResult(bool isValid)
            {
                if (isValid)
                {
                    Console.WriteLine("ФИО введено корректно.");
                }
                else
                {
                    Console.WriteLine("ФИО введено некорректно.");
                }
            }
        

    }
}
