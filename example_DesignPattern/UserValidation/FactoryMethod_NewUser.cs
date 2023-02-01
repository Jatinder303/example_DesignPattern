using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_FactoryMethodDesignPattern.UserValidation
{
   public class FactoryMethod_NewUser : UserFactory
    {
        protected override IUsers MakeUser()
        {
            IUsers NewUser_Obj = new NewUser();
            return NewUser_Obj;
        }
    }
}

