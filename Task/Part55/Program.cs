using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Part55
{
    enum Category
    {
        Divident
    }
    class Client : System.Collections.IEnumerable
    {
        private System.Collections.Specialized.StringCollection Data;
        private delegate void MethodAddTo(string msg);
        private event MethodAddTo ClientbeDivident;
        public string FIO;
        public int score;
        private DateTime data;
        public void AddDivident(string msg)
        {
            if (ClientbeDivident != null)
                ClientbeDivident(msg);
        }
        public void SubscribeTo(Client item)
        {
            ClientbeDivident += item.AddDivident;
        }
        public void SubscribeFrom(Client item)
        {
            ClientbeDivident -= item.AddDivident;
        }
        public Client()
        {
            Data = new System.Collections.Specialized.StringCollection();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            return ((System.Collections.IEnumerable)Data).GetEnumerator();
        }
        public Client(string FIO, int score, DateTime data)
        {
            this.FIO = FIO;
            this.score = score;
            this.data = data;
        }
        public void Enter()
        {
            Console.WriteLine("Введите инициалы");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите счет");
            score = Convert.ToInt32(Console.ReadLine());
            data = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine("FIO: " + FIO + "\nScore: " + score + "\nData: " + data);
        }

        public void metod()
        {
            Client q = new Client();
            q.FIO = this.FIO;
            q.score = this.score;
            q.data = this.data;
            do
            {
                data.AddDays(1);
            }
            while (data.Day == 31 || data.Day == 30);

            this.score += 500;
            if (this.score < 2000)
            {
                this.SubscribeTo(q);
                Console.WriteLine("Выплатите дивиденты");
            }
            if (this.score > 2000)
            {
                this.SubscribeFrom(q);
                Console.WriteLine("Вы не входите в диапазон плательщиков дивидентов");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Client client = new Client();
                Client client1 = new Client();
                client.Enter();
                client.Print();
                client1.Enter();
                client1.Print();
                client.metod();
                client1.metod();
                client.Print();
                Console.ReadKey();
            }
        }
    }
}