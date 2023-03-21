using System;

namespace Part54
{
    public delegate void PostSended(int post, int abonent);
    public class PostOffice
    {
        public event PostSended Sended1;
        public event PostSended Sended2;
        public event PostSended Sended3;

        public void SendMessage(int abonent, int post)
        {
            switch (abonent)
            {
                case 1:
                    if (Sended1 != null)
                    {
                        Sended1(post, 1);
                        Console.WriteLine("Событие 1 выполнено");
                    }
                    break;
                case 2:
                    if (Sended2 != null)
                    {
                        Sended2(post, 2);
                        Console.WriteLine("Событие 2 выполнено");
                    }
                    break;
                case 3:
                    if (Sended3 != null)
                    {
                        Sended3(post, 3);
                        Console.WriteLine("Событие 3 выполнено");
                    }
                    break;
                default:
                    break;
            }

            Sended2 = null;
            Sended3 = null;
        }
    }

    public class Abonents
    {
        static void AppendInvokations(PostOffice office)
        {
            PostSended lambdaForPosting = new PostSended(
                (postData, abonent) =>
                {
                    if (postData == -1)
                    {
                        Console.WriteLine("Отправил -1");
                        Environment.Exit(0);
                    }
                    else
                        Console.WriteLine($"Сообщение {postData} абоненту  {abonent}");
                }
            );
            office.Sended1 += lambdaForPosting;
            office.Sended2 += lambdaForPosting;
            office.Sended3 += lambdaForPosting;
        }

        public static void Post1(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 1 оправил \n");
        }
        public static void Post2(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 2 оправил\n");
        }
        public static void Post3(PostOffice office, int to, int post)
        {
            AppendInvokations(office);
            office.SendMessage(to, post);
            Console.WriteLine("пользователь 3 оправил\n");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            PostOffice post = new PostOffice();
            Abonents.Post1(post, 3, 666);
            Abonents.Post2(post, 1, 28);
            Abonents.Post3(post, 4, -189);
            Console.ReadKey();
        }
    }
}
