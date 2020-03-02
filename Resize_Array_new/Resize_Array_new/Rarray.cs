using System;
using System.Collections.Generic;
using System.Text;

namespace Resize_Array_new
{
    public class Rarray
    {
        public int[] array;

        public void start(int n)
        {
            Rarray ar = new Rarray();
            array = new int[n];
        }
        public void resize(int n)
        {
                int a = n - array.Length;
                int[] newar = new int[array.Length + a];
                for (int i = 0; i < array.Length; i++)
                {
                    newar[i] = array[i];
                    
                }
                array = newar;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                    resize(index);
                array[index] = value;   

            }
        }

        public void add_to_end(int value)
        {
            resize(array.Length+1);
            array[array.Length - 1]=value;
        }

        public void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]) ;
            }
        }
    }
}
