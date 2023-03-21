using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Part48
{
    internal class sub
    {
        private int[] mas;
        private int size;
        public sub(int x)
        {
            size = x;
            mas = new int[size];
        }
        public int[] Mas
        {
            get
            {
                return mas;
            }
            set
            {
                mas = value;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int this[int x]
        {
            get
            {
                return mas[x];
            }
            set
            {
                mas[x] = value;
            }
        }
        public void Enter()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите элемент {i}");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < mas.Length; i++)
            {
                str += mas[i] + " ";
            }
            return $"Информация об прогресии {str}";
        }
        public void find(int x)//поиск
        {
            for (int i = 0; i < mas.Length;i++)
            {
                if (mas[i] == x)
                {
                    Console.WriteLine($"найдено число {x} расположенное по индексу {i}");
                }
            }
            Console.WriteLine("Число не найдено");
        }
        public int[] decreasing()//убывающая
        {
            Array.Sort(mas);
            Array.Reverse(mas);
            return mas;
        }
        public int[] increasing()//возрастающая
        {
            Array.Sort(mas);
            return mas;
        }
        public int[] ndecreasing()//неубывающая
        {
            Array.Sort(mas);
            return mas;
        }
        public int[] nincreasing()//невозрастающая
        {
            Array.Sort(mas);
            Array.Reverse(mas);
            return mas;
        }
        public int[] geo()//геометрическая//////////
        {

            return mas;
        }
        public int[] ari()//арифметическая//////////
        {

            return mas;
        }
        public int locmax(int x,int y)//локальный макс
        {
            int max = mas[0];
            for(int i = x;i < y;i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }
            return max;
        }
        public int locmin(int x, int y)//локальный мин
        {
            int min = mas[0];
            for (int i = x; i < y; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            return min;
        }
        public int max()//макс
        {
            int max = mas[0];
            for(int i = 0; i < mas.Length;i++)
            {
                if(max < mas[i])
                {
                    max = mas[i];
                }
            }
            return max;
        }
        public int min()//мин
        {
            int min = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
            }
            return min;
        }
        public void more(int x)//больше 
        {
            for(int i = 0;i< mas.Length;i++)
            {
                if (mas[i] >= x)
                {
                    Console.Write(mas[i] + " ");
                }
            }
            Console.Write("\n");
        }
        public void less(int x)//меньше
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] <= x)
                {
                    Console.Write(mas[i] + " ");
                }
            }
            Console.Write("\n");
        }
        public void positivе()//больше нуля
        {
            for(int i =0;i<mas.Length;i++)
            {
                if (mas[i] > 0 )
                {
                    Console.Write(mas[i] + " ");
                }
            }
        }
        public void negativе()//меньше нуля
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    Console.Write(mas[i] + " ");
                }
            }
        }
        public static bool operator ==(sub a, sub b)
        {
            if (a.Mas.Length == b.Mas.Length)
            {
                for(int i = 0; i < a.size; i++)
                {
                    if(a.Mas[i] != b.Mas[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }//перегрузка оператора ==
        public static bool operator !=(sub a, sub b)
        {
            if (a.Mas.Length == b.Mas.Length)
            {
                for (int i = 0; i < a.size; i++)
                {
                    if (a.Mas[i] == b.Mas[i])
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }//перегрузка оператора !=
        public static bool operator >(sub a, sub b)
        {
            int sum = 0;
            int sum2 = 0;
            for(int i = 0; i < a.Mas.Length;i++)
            {
                sum += a.Mas[i];
            }
            for (int i = 0; i < b.Mas.Length; i++)
            {
                sum2 += b.Mas[i];
            }
            if(sum > sum2)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }//перегрузка оператора >
        public static bool operator <(sub a, sub b)
        {
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < a.Mas.Length; i++)
            {
                sum += a.Mas[i];
            }
            for (int i = 0; i < b.Mas.Length; i++)
            {
                sum2 += b.Mas[i];
            }
            if (sum < sum2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//перегрузка оператора <
    }
}
