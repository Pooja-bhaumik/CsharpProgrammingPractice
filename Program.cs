using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Example usage of FindFirstUniqueCharacter method
            //string input = "swiss";
            //char result = FindFirstUniqueCharacter(input);

            //if (result != '\0')
            //{
            //    Console.WriteLine($"The first unique character is: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("No unique character found.");
            //}

            //2-Find second maximum number in a array
            //int[] numbers = { 1, 2, 11, 12, 14 };
            //int result = FindSecondMinimumNum(numbers);

            //3-Reverse a string
            //string input = "Pooja";
            //string reverseString = FunForReverseString(input);
            //Console.WriteLine(reverseString);

            //4-remove duplicate from sorted array
            //int[] numbers = { 1, 2, 2, 3, 5, 5 };
            //int[] result = FunRemoveDuplicate(numbers);

        }


        // Method to find the first unique character in a string
        //public static char FindFirstUniqueCharacter(string input)
        //{
        //    // Outer loop: Go through each character in the string.
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        bool isUnique = true; // Assume the character is unique.

        //        // Inner loop: Compare the current character with all other characters.
        //        for (int j = 0; j < input.Length; j++)
        //        {
        //            if (i != j && input[i] == input[j]) // If the same character is found elsewhere
        //            {
        //                isUnique = false; // The character is not unique.
        //                break; // No need to check further, move to the next character.
        //            }
        //        }

        //        if (isUnique) // If the character is unique
        //        {
        //            return input[i]; // Return this character as the answer.
        //        }
        //    }

        //    return '\0'; // If no unique character is found, return null character.
        //}



        //2-
        //Method to find second min highest number of an array
        //public static int FindSecondMinimumNum(int[] numbers)
        //{
        //    int max = numbers[0];
        //    int secondMax = numbers[0];
        //    for(int i = 1; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > max)
        //        {
        //            secondMax = max;
        //            max = numbers[i];
        //        }else if(max> numbers[i])
        //        {
        //            secondMax = numbers[i];
        //        }
        //    }
        //    return secondMax;
        //}

        //3-Reverse a string


        //public static string FunForReverseString(string input)
        //{
        //    string result = "";
        //    for(int i = input.Length - 1; i >= 0; i--)
        //    {
        //        result += input[i];
        //    }
        //    return result;
        //}

        //4-Remove duplicate from sorted array


    }
}
