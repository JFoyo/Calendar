using System;

class Program
{
    static void Main()
    {
        string? InputYear;
        int headerWidth = 26;

        do
        {
            Console.Write("Please enter a Year: ");
            InputYear = Console.ReadLine();
        } while (InputYear == null || !IsAllDigits(InputYear));

        string[] Month = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        for (int j = 0; j < 12; j++)
        {
            string header = string.Format("{0,-" + (headerWidth - 4) + "} {1,4}", Month[j], InputYear);

            Console.WriteLine(header);
            Console.Write("Sun Mon Tue Wen Thu Fri Sat");
            Console.Write("\n");

            DateTime firstDayOfMonth = new DateTime(Convert.ToInt16(InputYear), j + 1, 1);
            int daysInMonth = DateTime.DaysInMonth(Convert.ToInt16(InputYear), j + 1);
            int currentDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

            for (int k = 0; k < currentDayOfWeek; k++)
            {
                Console.Write("    ");
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write(day.ToString().PadLeft(3) + " ");
                if ((currentDayOfWeek + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n");
        }
    }

    static bool IsAllDigits(string InputYear)
    {
        foreach (char c in InputYear)
        {
            if (!char.IsDigit(c))
            {
                Console.WriteLine("Invalid Input. Please enter only numbers.");
                return false;
            }
            else if (InputYear.Length != 4){
                Console.WriteLine("Invalid Input. Please enter 4 numbers only.");
                return false;
            }
        }
        return true;
    }
}
