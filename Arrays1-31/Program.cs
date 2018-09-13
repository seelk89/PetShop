using System;

namespace Arrays1_31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1
            //InputStuffIntoArray();

            //Excercise 2
            //ReverseOrderOfArray();

            //Excercise 4
            //CopyArrayToArray();

            //Excercise 5
            //NumberOfDuplicates();

            //Excercise 6
            //NumberOfUniques();

            //Excercise 7
            MergeArrays();

            Console.ReadLine();
        }

        //Part of Excercise 7
        private static void MergeArrays()
        {
            int n = 3;
            int[] intArray = new int[n];
            int[] secondArray = new int[n];
            int[] mergedArray = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in the second array: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //Merging arrays
            Array.Copy(intArray, mergedArray, n);
            Array.Copy(secondArray, 0, mergedArray, n, n);

            //Sorting arrays with bubblesort
            for (int i = 0; i < n * 2; i++)
            {
                for (int j = 0; j < n * 2; j++)
                {
                    if (mergedArray[j] > mergedArray[i])
                    {
                        int temp = mergedArray[i];
                        mergedArray[i] = mergedArray[j];
                        mergedArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(mergedArray[i]);
            }
        }

        //Part of Excercise 6
        private static void NumberOfUniques()
        {
            int n = 3;
            int[] intArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in the second array: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                int check = intArray[i];
                int counter = 0;

                for (int j = 0; j < intArray.Length; j++)
                {
                    if (check != secondArray[j])
                    {
                        counter++;
                    }
                }

                if (counter == intArray.Length)
                {
                    Console.WriteLine(check);
                }
            }
        }

        //Part of Excercise 1
        private static void InputStuffIntoArray()
        {
            int[] intArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < intArray.Length; j++)
            {
                Console.WriteLine(intArray[j]);
            }
        }

        //Part of excercise 2
        private static void ReverseOrderOfArray()
        {
            int n = 10;
            int[] intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int j = n-1; j > 0; j--)
            {
                Console.WriteLine(intArray[j]);
            }
        }

        //Part of excercise 4
        private static void CopyArrayToArray()
        {
            int n = 10;
            int[] intArray = new int[n];
            int[] arrayCopy = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                arrayCopy[i] = intArray[i];
            }

            for (int j = 0; j < intArray.Length; j++)
            {
                Console.WriteLine(arrayCopy[j]);
            }
        }

        //Part of excercise 5
        private static void NumberOfDuplicates()
        {
            int n = 3;
            int[] intArray = new int[n];
            int[] secondArray = new int[n];
            int duplicates = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in array: ", i);
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Int for {0} place in the second array: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                int check = intArray[i];
             
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (check == secondArray[j])
                    {
                        duplicates++;
                    }
                }
            }

            Console.WriteLine(duplicates);
        }
    }
}
