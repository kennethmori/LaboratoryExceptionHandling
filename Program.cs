using LaboratoryExceptionHandling;


namespace LabExceptionHandling;

class Program
{
    //exercise 2 method
    private static void ReadNumber(int start, int end)
    {
        try
        {
            int min = 0;
            int max = 9;

            while (min <= max)
            {
                {
                    try
                    {

                        min++;
                        Console.WriteLine($"Enter number {min}:");
                        int num = int.Parse(Console.ReadLine());
                        if (num < start || num > end)
                        {
                            throw new myException($"{num} is invalid.");
                        }
                    }
                    catch (myException ex)
                    {
                        Console.WriteLine($"{ex.Message} Number must be between Start and End.");
                    }
                }
            }
            Console.WriteLine("End of loop body.");
        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid number or non-number text is entered {ex}");
        }
    }

    //main 
    static void Main(string[] args)
    {
        //1.
        try
        {
            Console.WriteLine("\n------------------------------Exercise 1------------------------------");
            Console.WriteLine("Enter an integer:");
            double input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                throw new FormatException();
            }

            double calculates = Math.Sqrt(input);
            Console.WriteLine($"The square root of {input} is: {calculates}");
        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid. Must be a positive integer. {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        finally
        {
            Console.WriteLine("Goodbye");
        }


        //2.
        Console.WriteLine("\n------------------------------Exercise 2------------------------------");
        Console.WriteLine("Enter Start:");
        int Start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter End:");
        int End = int.Parse(Console.ReadLine());

        ReadNumber(Start, End);
    }
}
