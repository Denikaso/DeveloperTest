namespace Library
{
    public class NumberSequence
    {
        public static void PrintNumberSequence()
        {
            Console.Write("Введите натуральное последнее число в последовательности: ");
            int lastNumber;
            try
            {
                lastNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введенное значение не является натуральным числом.");
                return;
            }
            if (lastNumber < 1)
            {
                Console.WriteLine("Ошибка: неккоректный ввод. Число не является натуральным");
                return;
            }
            /*
            for (int i = 1; i < lastNumber; i++)            
                Console.Write(i + ", ");            
            Console.Write(lastNumber + ".");
            */
            string result = string.Join(", ", Enumerable.Range(1, n)) + ".";
            Console.WriteLine(result);
        }
    }
    public class SquareWithHole
    {
        public static void PrintSquare()
        {
            Console.Write("Введите нечетную длину стороны квадрата большую, чем 3: ");
            int sideLength;
            try
            {
                sideLength = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введенное значение не является числом.");
                return;
            }
            if (sideLength < 3 || sideLength % 2 == 0)
            {
                Console.WriteLine("Ошибка: неккоректный ввод. Длина стороны должна быть натуральным нечетным числом, большим чем 3.");
                return;
            }
            int halfLength = sideLength / 2 + 1;
            string rowString = new string('#', sideLength);
            for (int row = 1; row <= sideLength; row++) {                
                if (row == halfLength)
                    Console.WriteLine(rowString.Substring(0, halfLength - 1) + " " + rowString.Substring(halfLength));
                else 
                    Console.WriteLine(rowString);
            }
        }
    }
}
