using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person noName = new Person(string.Empty, "Kolovski", 15);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown : {0}",ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }

            try
            {
                Person noLastName = new Person("Konstantin", null, 15);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }

            try
            {
                Person negativeAge = new Person("Konstantin", "Kolovski", -15);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }

            try
            {
                Person tooOld = new Person("Konstantin", "Kolovski", 165);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown : {0}", ex);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown : {0}",ex);
            }
        }
    }
}
