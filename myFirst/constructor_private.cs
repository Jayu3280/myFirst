using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{

    class Logger
    {

        //private constructor
        private Logger()
        {
            Console.WriteLine("Private Constructor Called");
        }
        public static void WriteLog()
        {
            Logger log = new Logger();  //allowed inside the class
            Console.WriteLine("Log Written Succesfully");
        }
    }
    internal class constructor_private
    {
        static void Main(string[] args)
        {
            Logger.WriteLog();
        }
    }
}
