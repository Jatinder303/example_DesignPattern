using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_FactoryMethodDesignPattern.UserValidation
{
    public abstract class UserFactory
    {
        protected abstract IUsers MakeUser();
        string Username { get; set; }
        string Password { get; set; }
        public IUsers CreateUser()
        {
            
            return this.MakeUser();
        }
            
    }
}
