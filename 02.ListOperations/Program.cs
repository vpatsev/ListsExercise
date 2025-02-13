namespace P03_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string currentCmd = Console.ReadLine();
            while (currentCmd != "End")
            {
                string[] cmdArgs = currentCmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
                if (cmdType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdType == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    bool isSuccess = InsertNumber(numbers, numberToInsert, index);
                    if (!isSuccess)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);

                    bool isSuccess = RemoveNumber(numbers, removeIndex);
                    if (!isSuccess)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (cmdType == "Shift")
                {
                    string shiftDirection = cmdArgs[1];
                    int shiftsCount = int.Parse(cmdArgs[2]);

                    ShiftNumbers(numbers, shiftDirection, shiftsCount);
                }

                currentCmd = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        static void ShiftNumbers(List<int> numbers, string direction, int count)
        {
            if (numbers.Count > 1)
            {
                count = count % numbers.Count;

                for (int i = 0; i < count; i++)
                {
                    if (direction == "left")
                    {
                        int firstElement = numbers[0];

                        numbers.RemoveAt(0);

                        numbers.Add(firstElement);
                    }
                    else if (direction == "right")
                    {

                        int lastElement = numbers[numbers.Count - 1];


                        numbers.RemoveAt(numbers.Count - 1);

                        numbers.Insert(0, lastElement);
                    }
                }
            }
        }

        static bool RemoveNumber(List<int> numbers, int index)
        {
            bool result = false;
            if (IsIndexValid(numbers, index))
            {
                numbers.RemoveAt(index);
                result = true;
            }

            return result;
        }

        static bool InsertNumber(List<int> numbers, int number, int index)
        {
            bool result = false;
            if (IsIndexValid(numbers, index))
            {
                numbers.Insert(index, number);
                result = true;
            }

            return result;
        }

        static bool IsIndexValid(List<int> numbers, int index)
        {

            bool result = false;
            if (index >= 0 && index < numbers.Count)
            {
                result = true;
            }

            return result;
        }
    }
}