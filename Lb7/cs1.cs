using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class Array : IOutput
    {
        private int[] data;

        public Array(int size)
        {
            data = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = rand.Next(10);
            }
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (int value in data)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"Array elements with info: {info}");
            foreach (int value in data)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

    internal class cs1
    {
    }
}
