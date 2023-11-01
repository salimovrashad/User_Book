using System.Collections.Generic;
using Core.Models;

namespace ConsoleApp1
{
	public class Program
	{

		public static List<User> Users = new List<User>();

		static void Main(string[] args)
		{

			Users.Add(new User
				{

					Name = "Rashad",
					Surname = "Salimov",
					Password = "password",
					Username = "rash"

				}
			);
			Users.Add(new User
			{

				Name = "Gunash",
				Surname = "Mammadli",
				Password = "password",
				Username = "gunmam"

			}
			);
			Users.Add(new User
			{

				Name = "adfkjbdak",
				Surname = "asdfafs",
				Password = "password",
				Username = "rash"

			}
			);

			while (true)
            {
				Console.WriteLine("Secim edin: ");
				Console.WriteLine("1-Qeydiyyat");
				Console.WriteLine("2-Giris");
				Console.WriteLine("3-AllUsers");
				Console.WriteLine("4-RemoveUsers");
				string choose = Console.ReadLine();

				switch (choose)
				{
					case "1":
                        Console.WriteLine("name: ");
						string name = Console.ReadLine();
                        Console.WriteLine("surname: ");
						string surname = Console.ReadLine();
						Console.WriteLine("username: ");
						string username = Console.ReadLine();
						Console.WriteLine("password: ");
						string password = Console.ReadLine();

						Authorization.Register(name, surname, username, password);
                        break;

					case "2":
                        Console.WriteLine("name: ");
                        string lname = Console.ReadLine();
                        Console.WriteLine("pass: ");
                        string lpassword = Console.ReadLine();

						Authorization.Login(lname, lpassword);
						break;

					case "3":
                        Authorization.GetUsers();
                        break;
					case "4":
						Authorization.Logout();
						break;
				}
			}
        }
	}
	public static class Authorization
	{



		public static void Register(string name, string surname, string username, string password) 
		{
			Console.WriteLine(name + " " + surname);
            Console.WriteLine("Qeydiyyat ugurlu oldu!!!");
        }


		public static void Login(string lname, string lpassword)
		{

            Console.WriteLine("Adi daxil edin: ");
			string inname = Console.ReadLine();

			Console.WriteLine("Password daxil edin: ");
			string inpass = Console.ReadLine();

			if (inname == lname && inpass == lpassword)
            {
                Console.WriteLine("Giris ugurlu oldu.");
            }
            else
            {
				Console.WriteLine("Giris ugursuz oldu!!!");
            }

        }


		public static void GetUsers() 
		{
            foreach (var user in Program.Users)
            {
                Console.WriteLine(user.Username);
            }
        }


		public static void Logout()
		{
			Program.Users.Clear();
		}

	}
}