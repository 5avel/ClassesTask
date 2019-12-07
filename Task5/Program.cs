using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("5avel", "PAvel", "Boliubash", 32);
            Console.WriteLine($"Login:{user.Login} \n Name:{user.Name} \n Lastname: {user.LastName}, \n Age:{user.Age}");
        }
    }
}
