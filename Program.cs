namespace Prog_120_S23_L14_Arrays_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // Parallel Arrays
            // - Related to the final
            // Passing By Reference

            // Collections
            // Trickiest things about arrays are 
            // 1. That you use an index to access values
            // 2. That the index STARTS at 0
            // 3. That the last ELEMENT is at .Length - 1

            // How do we create an array of strings with the capacity of 3, names
            string[] names = new string[3];

            names[0] = "David";
            names[1] = "Nancy";
            names[2] = "Will";
            int.Parse("dog");
            //names[3] = "Josh";
            //Console.WriteLine(names[3]);

            try
            {

            }
            catch(IndexOutOfRangeException ioore)
            {
                Console.WriteLine(ioore.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Your number was not a valid number");
            }


        } // Main

        public static void TryCatchExample()
        {

            // How do we create an array of strings with the capacity of 3, names
            string[] names = new string[3];

            names[0] = "David";
            names[1] = "Nancy";
            names[2] = "Will";
            int.Parse("dog");
            //names[3] = "Josh";
            //Console.WriteLine(names[3]);

            try
            {

            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine(ioore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Your number was not a valid number");
            }
        }

    } // class

} // namespace