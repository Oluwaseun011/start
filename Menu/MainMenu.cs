using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Managers;

namespace start.Menu
{
    public class MainMenu
    {

        UserLogic userLogic = new UserLogic();
        public void Main()
        {
            Console.WriteLine("1. Register\n2. Login");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Register();
                Main();
            }
            else if (input == "2")
            {
                Login();
            }
            else
            {
                Console.WriteLine("invalid input");
                Main();
            }
        }

        public void Register()
        {
            Console.Write("enter your email: ");
            string email = Console.ReadLine();

            Console.Write("enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
        }

        public void Login()
        {
            Console.Write("enter your email: ");
            string email = Console.ReadLine();

            Console.Write("enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            var response = userLogic.Login(email, pin);

            if (response == null)
            {
                Console.WriteLine("invalid cridentials");
                Login();
            }
            else
            {
                if (response.Role == "SuperAdmin")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Admin();
                }

                else if (response.Role == "Customer")
                {

                }
            }



        }
    }
}