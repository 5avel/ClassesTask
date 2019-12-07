using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class User
    {
        private string login;
        public string Login { get => login; set => login = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string lastname;
        public string LastName { get => lastname; set => lastname = value; }

        private int age;
        public int Age { get => age; set => age = value; }

        private readonly DateTime wreateDate;
        public DateTime WreateDate => wreateDate;

        public User(string login, string name, string lastname, int age)
        {
            this.login = login;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.wreateDate = DateTime.Now;
        }
                


    }
}
