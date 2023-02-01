using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using example_FactoryMethodDesignPattern.UserValidation;


namespace example_FactoryMethodDesignPattern
{
    public partial class Form1 : Form
    {
        IUsers NewUser_Obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            NewUser_Obj = new FactoryMethod_NewUser().CreateUser();
        }

        private void Reg_User_Click(object sender, EventArgs e)
        {
           NewUser_Obj = new FactoryMethod_RegisterUser().CreateUser();
        }

        private void admin_user_Click(object sender, EventArgs e)
        {
           NewUser_Obj = new FactoryMethod_AdminUser().CreateUser();
        }
    }
}
