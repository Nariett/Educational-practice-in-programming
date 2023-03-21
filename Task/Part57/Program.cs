using System;
using System.IO;

namespace Part57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter write = new StreamWriter("text.txt"))
            {
                Console.WriteLine("Введите предложение для записи");
                string text = Console.ReadLine();
                string shifr = "";

                char[] letter = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'x', 'ц', 'ч', 'ш', 'щ' };
                for (int i = 0; i < text.Length; i++)
                {
                    bool pass = false;
                    for (int j = 0; j < letter.Length; j++)
                    {
                        if (text[i] == letter[j])
                        {
                            shifr += text[i] + "ла";
                            pass = true;
                            break;
                        }
                    }
                    if (pass == false)
                    {
                        shifr += text[i];
                    }
                }
                write.Write(shifr);
            }
            using (StreamReader read = new StreamReader("text.txt"))
            {
                Console.WriteLine("Шифрованный текст");
                string text = read.ReadToEnd();
                Console.WriteLine(text);
                string rer = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != text.Length -1)
                    {
                        if (text[i+1] == 'л' && text[i + 2] == 'а')
                        {
                            rer += text[i];
                            i += 2;
                        }
                        else
                        {
                            rer += text[i];
                        }
                    }
                    else
                    {
                        if (text[i-1] == 'л' && text[i] == 'а')
                        {
                            rer += text[i];
                        }
                        else
                        {
                            rer += text[i];
                        } 
                            
                    }

                }
                Console.Write(rer);
            }
            Console.ReadKey();
        }
    }
}
