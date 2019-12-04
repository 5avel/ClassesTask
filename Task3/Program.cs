using System;

namespace Task3
{
    class Program
    {

        /*Задание 3
         Требуется:
            Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно
            строковое поле и метод void Show().
            Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
            Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
             */


        static void Main(string[] args)
        {
            Book b1 = new Book(
                new Title { title = "Title"},
                new Author{name = "Name"},
                new Content { content = "Content"}
        );

            b1.Show();

        }
    }
}
