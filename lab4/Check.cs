using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static class Check
    {
        static public void check()
        {
            bool c = true;

            while (c)
            {
                int count = 0;
                int size = 5;
                var arr = new int[size];
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    arr[i] = random.Next(0, 10000);
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (arr[i] > arr[j])
                        {
                            var t = arr[i];
                            arr[i] = arr[j];
                            arr[j] = t;
                            count++;
                        }
                        if (count > 7)
                        {
                            for (int l = 0; l < size; l++)
                            {
                                Console.Write(arr[l] + " ");
                            }
                            Console.WriteLine("Error");
                            c = false;
                            break;
                        }
                    }
                }
            }
        }
    }

}
