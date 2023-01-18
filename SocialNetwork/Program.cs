using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

class Program
{
    public static UserService userService = new UserService();

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать!");

        while(true)
        {
            Console.WriteLine("Для регистрации пользователя введите имя");

            string firstName = Console.ReadLine();

            Console.WriteLine("Фамилия: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine("email: ");
            string email = Console.ReadLine();

            UserRegistrationData userRegistrationData = new UserRegistrationData()
            {
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Email = email
            };

            try
            {
                userService.Register(userRegistrationData);
                Console.WriteLine("Регистрация произошла успешно");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Введите корректное значение");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка при регистрации.");
            }
        }
        
    }
}



