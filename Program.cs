namespace Prog_120_S23_L14_Arrays_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ask the user how many products they would like? ( asking for the size of the array )
            // Ask the user for the name of each product ( looping and assigning the users values )
            // Ask the user for a price of each product ( looping and assigning a value to a different array )
            // Sum the total of all the products

            // Ask the user how many products they would like? ( asking for the size of the array )
            Console.WriteLine("How many products would you like?");
            int numberOfProducts = int.Parse(Console.ReadLine());

            // Creating an array to the users specificed capacity
            // string, int, double, bool
            // what type would name be
            // anytime I'm asking for multiple of something, it's usually in an array
            string[] products = new string[numberOfProducts];

            int index = 0;

            while(index < products.Length)
            {
                Console.Write($"Enter the name for product {index}: ");
                products[index] = Console.ReadLine();

                index++;
            }

            // Testing to see the product was saved by displaying the first item
            Console.WriteLine(products[0]);



        } // Main

        // Arrays
        // Parallel Arrays
        // - Related to the final
        // Passing By Reference

        // Collections
        // Trickiest things about arrays are 
        // 1. That you use an index to access values
        // 2. That the index STARTS at 0
        // 3. That the last ELEMENT is at .Length - 1

        public static void AskingUserForInformation()
        {
            // Arrays to a size of 5
            string[] usersNames = new string[5];

            Console.WriteLine("Please enter 5 names");

            int index = 0;

            // In this loop we are asking the user for 5 names


            while (index < usersNames.Length)
            {
                Console.Write($"Please enter name {index}: ");
                usersNames[index] = Console.ReadLine();

                index++;
            }

            // ----------------------------------------------
            // In this loop we are displaying the 5 names

            Console.WriteLine("You have entered 5 names");

            index = 0;
            while (index < usersNames.Length)
            {
                Console.WriteLine(usersNames[index]);

                index++;
            }
        }

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
        } // TryCatchExample()

        public static void LoopingThruAnArray()
        {

            // How do we create an array of strings with the capacity of 3, names
            string[] names = new string[5];

            names[0] = "David";
            names[1] = "Nancy";
            names[2] = "Will";
            names[3] = "John";
            names[4] = "Josh";

            int index = 0;

            // index < arrayName.Length : most used equation to go through an array

            while (index < names.Length)
            {
                Console.WriteLine(names[index]);
                index++;
            }

        }

    } // class

} // namespace