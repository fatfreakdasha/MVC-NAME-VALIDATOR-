using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationOfFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameValidatorModel model = new NameValidatorModel("");
            NameValidatorView view = new NameValidatorView();
            NameValidatorController controller = new NameValidatorController(model, view);

            controller.Validate();
            Console.ReadKey();
        }
    }
}
