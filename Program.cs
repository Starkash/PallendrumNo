namespace Pallendrum
{
    class Pallendrum
    {
        static void Main()
        {
            int num, result = 0, rem, originalnum;

            Console.WriteLine("Eneter Any Number:");
            num = int.Parse(Console.ReadLine());
            originalnum = num;
            while (num > 0)
            {
                rem = num % 10;
                result = rem + result * 10;
                num = num / 10;


            }

            if (result == originalnum)
            {
                Console.WriteLine("This is a Pallendrum Number:");

            }
            else
            {
                Console.WriteLine("This is not Pallendrum Number:");
            }
            Console.ReadLine();






        }
    }








}














