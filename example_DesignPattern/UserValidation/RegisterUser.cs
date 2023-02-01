using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_FactoryMethodDesignPattern.UserValidation
{
    public class RegisterUser :IUsers
    {
        string userName { get; set; }
        string password { get; set; }
      
   
        public bool validation()
        {

            // implement the login process
            return true;
        }

    }
}
