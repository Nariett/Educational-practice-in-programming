using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Part60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film[] film =
            {
                new Film("Крепкий орешек",2,"Русский язык","Боевик"),
                new Film("Терминатор",6,"Русский язык","Боевик"),
                new Film("Лалаленд",4,"Русский язык","Мюзиклы")
            };
            Film[] film2 =
            {
                new Film("Тупой и еще тупее",5,"Русский язык","Комедия"),
                new Film("Черный ястреб",1,"Русский язык","Боевик"),
                new Film("Брюс всемогущий",6,"Русский язык","Комедия")
            };
            Film[] film3 =
            {
                new Film("Зеленая миля",2,"Англиский язык","Драма"),
                new Film("Марсианин",6,"Польский язык","Фантастика"),
                new Film("Брюс всемогущий",4,"Румынский язык","Комедия")
            };
            List<Cinema> cinema = new List<Cinema>
            {
                new Cinema("robinsor", "Ул. Пушкина", 4, film),
                new Cinema("Minsk", "Ул. Ленина",2,film),
                new Cinema("Salut","Ул. Куйбышева",3,film2),
                new Cinema("Aurora","Ул. Пушкина",4,film3),
                new Cinema("Cinema 4D","Пр. Победы",9,film),
                new Cinema("Renesanse","Ул. Пролетарская",1,film3),
                new Cinema("Falcon","Ул. Красной армии",2,film2),
                new Cinema("4D Films","Ул. Трудовая",1,film),
                new Cinema("Silver Screen","Пр. Победителей",2,film2),
                new Cinema("Titan","Пр. Свободы",4,film)
            };
            int c = 0;
            int index = 0;
            while (c == 0)
            {
                Console.Write("Выберите пункт меню:\n1 - Вывод данных из списка\n2 - Добавление объектов\n3 - Индивидуальное задание\n4 - Выйти из программы\n");
                index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        {
                            foreach (var i in cinema)
                            {
                                Console.WriteLine(i.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.WriteLine("Введите название кинотеатра");
                                string name = Console.ReadLine();
                                if (name[0].ToString() != (name[0].ToString()).ToUpper())
                                {
                                    throw new UpperException("Название написано с маленькой буквы");
                                }
                                Console.WriteLine("Введите расположение кинотеатра");
                                string street = Console.ReadLine();
                                if (street[0].ToString() != (street[0].ToString()).ToUpper())
                                {
                                    throw new UpperException("Название улицы написано с маленькой буквы");
                                }
                                Console.WriteLine("Введите кол-во залов в кинотеатре");
                                int hall = Convert.ToInt32(Console.ReadLine());
                                if (hall < 0 )
                                {
                                    throw new DigitException("Кол-во залов не целочисленное или меньше нуля");
                                }
                                Console.WriteLine("Введите название фильма");
                                string nameFilm = Console.ReadLine();
                                Console.WriteLine("Введите кол-во сеансов");
                                int session = Convert.ToInt32(Console.ReadLine());
                                if (session < 0)
                                {
                                    throw new DigitException("Кол-во сеансов не целочисленное или меньше нуля");
                                }
                                Console.WriteLine("Введите язык озвучки");
                                string language = Console.ReadLine();
                                if (language[0].ToString() != (language[0].ToString()).ToUpper())
                                {
                                    throw new UpperException("Язык озвучки написан с маленькой буквы");
                                }
                                Console.WriteLine("Введите язык жанр");
                                string genre = Console.ReadLine();
                                if (genre[0].ToString() != (genre[0].ToString()).ToUpper())
                                {
                                    throw new UpperException("Жанр написан с маленькой буквы");
                                }
                                Film[] x = { new Film(nameFilm, session, language, genre) };
                                cinema.Add(new Cinema(name, street, hall, x));
                            }
                            catch (UpperException ex)
                            {
                                Console.WriteLine("Ошибка " + ex.Message);
                            }
                            catch (DigitException e)
                            {
                                Console.WriteLine("Ошибка " + e.Message);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Выберите что хотите сделать:" +
                                                "\n1 - Сортировка по двум критериям (название и кол-во залов)" +
                                                "\n2 - Вывести кинотеатров и фильмов в которых показывают кино в жанре комедия" +
                                                "\n3 - Вывести кинотеатров и улиц где нет ни одного фильма на русском языке" +
                                                "\n4 - Вывести максимальное кол-во залов на одной улице" +
                                                "\n5 - Выполнить группировку по каждому полю\n");
                            int select = Convert.ToInt32(Console.ReadLine());
                            switch(select)
                            {
                                case 1:
                                    {
                                        var sortList = from i in cinema
                                                       orderby i.Name, i.Hall
                                                       select i;
                                        foreach (var i in sortList)
                                        {
                                            Console.WriteLine(i.ToString());
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        var sortComedy = from i in cinema
                                                         from j in i.Film
                                                         where j.genre == "Комедия"
                                                         select new {Cimema = i.Name,Film = j.film};
                                        foreach (var i in sortComedy)
                                        {
                                            Console.WriteLine($"Кинотеатр: {i.Cimema} Фильм: {i.Film}");
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        var noRussian = from i in cinema
                                                        from j in i.Film
                                                        where j.language != "Русский язык"
                                                        select new {i.Name,i.Street };
                                        foreach (var i in noRussian)
                                        {
                                            Console.WriteLine($"Кинотеатр: {i.Name} Улица: {i.Street}");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        /*var sameHall = from i in cinema
                                                       from j in cinema
                                                       where 
                                                       select new { i.Name, i.Street };
                                        foreach (var i in noRussian)
                                        {
                                            Console.WriteLine($"Кинотеатр: {i.Name} Улица: {i.Street}");
                                        }*/
                                        break;
                                    }
                                case 5:
                                    {
                                        var allGroup = from i in cinema
                                                       group i by new {i.Name,i.Street,i.Hall,i.Film} into g
                                                       select new {Key = g.Key, Cinemas = g};
                                        foreach (var group in allGroup)
                                        {
                                            Console.WriteLine($"Name :{group.Key.Name}");
                                            Console.WriteLine($"Street :{group.Key.Street}");
                                            Console.WriteLine($"Hall :{group.Key.Hall}");
                                            //Console.WriteLine($"Film :{group.Key.Film}");
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Ошибка ввода данных");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Выход из программы");
                            c = 1;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода данных");
                            break;
                        }
                };
            }


        }
    }
}
