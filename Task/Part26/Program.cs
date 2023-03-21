using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] z = new int[15] { 0,-1,1,2,3,4,5,-6,7,8,1,0,0,0,0};
            int negative = 0;
            int zero = 0;
            for(int i = 0;i < z.GetLength(0);i++)
            {
                if (z[i] < 0)
                {
                    negative = i;
                    break;
                }
            }
            for (int i = 0; i < z.GetLength(0); i++)
            {
                if (z[i] == 0)
                {
                    zero = i;
                    if(negative > zero)
                    {
                        
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for(int i = negative+1;i < zero;i++)
            {
                Console.Write(z[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
