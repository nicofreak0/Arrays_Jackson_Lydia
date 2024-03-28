namespace Arrays_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter a whole number for the array size
            Console.WriteLine("Enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;

            //asks user to enter another whole number to add to the array,
            //adds the numbers together to get the sum of the array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            //prints to console the answer of the array sum
            Console.WriteLine($"The sum of the array is {sum}");

            //sorts the array numbers in order and prints to console
            Array.Sort( numbers );

            Console.WriteLine("Array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}