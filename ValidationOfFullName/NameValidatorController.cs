using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationOfFullName
{
     class NameValidatorController
    {
      
            private NameValidatorModel model;
            private NameValidatorView view;

            public NameValidatorController(NameValidatorModel model, NameValidatorView view)
            {
                this.model = model;
                this.view = view;
            }

            public void Validate()
            {
                string name = view.GetNameInput();
                NameValidatorModel nameValidatorModel = new NameValidatorModel(name);
                bool isValid = nameValidatorModel.IsValid();
                view.ShowResult(isValid);
            }
        

    }
}
