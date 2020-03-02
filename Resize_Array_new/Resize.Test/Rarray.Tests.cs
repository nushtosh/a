using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Resize_Array_new;

namespace Resize_Array_new.Test
{
    [TestClass]
    public class Resize_Array_newTest
    {
        [TestMethod]
        public void add_to_end_test()
        {
            int expected = 33;
            Rarray ar = new Rarray();
            ar.start(5);
            ar.add_to_end(33);
            int actual = ar[5];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void write_and_read_test()
        {
            int expected = 33;
            Rarray ar = new Rarray();
            ar.start(5);
            ar[3] = 33;
            int actual = ar[3];
            Assert.AreEqual(expected, actual);

        }

        
    }
}
