using BuisnessLogicLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMangmentSystem.Global_Classes
{
    internal class clsGlobal
    {

        public static clsUser CurrentUser;
        static string KeyPath = @"HKEY_CURRENT_USER\Software\MyBankSystem";

        static string UsernameKey = "UserName";
        static string PasswordKey = "Password";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {



            string UserNameValue = Username;
            string PasswordValue = Password;



            try
            {


                Registry.SetValue(KeyPath, UsernameKey, UserNameValue, RegistryValueKind.String);
                Registry.SetValue(KeyPath, PasswordKey, PasswordValue, RegistryValueKind.String);
                return true;

            }

            catch (Exception ex)
            {

                MessageBox.Show($"There an error in {ex}", "Something Wrong", MessageBoxButtons.OK);
                return false;

            }



        }



        public static bool GetStoredCredential(ref string Username, ref string Password)
        {


            try
            {



                string getUserValue = Registry.GetValue(KeyPath, UsernameKey, null) as string;
                string getPasswordValue = Registry.GetValue(KeyPath, PasswordKey, null) as string;
                if (getUserValue != null && getPasswordValue != null)
                {
                    Username = getUserValue;
                    Password = getPasswordValue;

                }

                else
                {

                    Username = "";
                    Password = "";
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"There an error in {ex}", "Something Wrong", MessageBoxButtons.OK);
                return false;

            }

            return true;

        }



    }
}
