using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoogeSort
{
    class Program
    {
        static void Main(string[] args) => Process();

        static void Process() {
            Console.Write("Ented array elements: ");
            var tempArray = Console.ReadLine().Split(new[] { ' ', ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[tempArray.Length];
            try{
                for (var i = 0; i < tempArray.Length; i++)
                    array[i] = Convert.ToInt32(tempArray[i]);
                Console.WriteLine($"Sored array: {String.Join(", ", StoogeSort(array))}");
                Repeat();
                return;
            }
            catch {
                Console.Clear();
                Console.WriteLine("Try again...");
                Process();
                return;
            }
        }

        static void Repeat() {
            Console.Write("Want to sort another array? (yes/no) - ");
            string answer = Console.ReadLine().Trim();
            if (answer == "yes") {
                answer = "";
                Console.Clear();
                Process();
                return;
            }
            else if (answer == "no") {
                Console.WriteLine("Shutting down...");
                return;
            }
            else {
                answer = "";
                Console.Clear();
                Console.WriteLine("Try again...");
                Repeat();
                return;
            }
        }

        static void Swap(ref int e1, ref int e2){
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int[] StoogeSort(int[] array) {


            return array;
        }
    }
}
