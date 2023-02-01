using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace example_FactoryMethodDesignPattern.UserValidation
{
    public class FactoryMethod_RegisterUser : UserFactory
    {
        protected override IUsers MakeUser()
        {
            IUsers RegisterUser_Obj = new RegisterUser();
            return RegisterUser_Obj;
        }
    }
}
