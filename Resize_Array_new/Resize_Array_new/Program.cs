using System;

namespace Resize_Array_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Rarray ar = new Rarray();
            ar.start(3);
            ar[0] = 4 ;
            ar.add_to_end(33);
            ar.print();
        }
    }
}
