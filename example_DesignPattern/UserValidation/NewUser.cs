using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_FactoryMethodDesignPattern.UserValidation
{
    public class NewUser : IUsers
    {
        string userName { get; set; }
        string Name { get; set; }
        string password { get; set; }
        public bool validation()
        {
            // verifing that user is exiting user or not
            // implement registration process
            return true;
        }
    }
}
