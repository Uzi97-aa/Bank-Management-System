using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using BuisnessLogicLayer;
namespace BankMangmentSystem
{
    public class clsGlobal
    {
    public clsUser CurrentUser;

        public void Login(string UserName,string Password)
        {
            CurrentUser= clsUser.FindByUserNameAndPassword(UserName, Password);
        }



    }
}
