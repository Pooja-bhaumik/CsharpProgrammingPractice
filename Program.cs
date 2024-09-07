using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)

        {
            //Child obj = new Child();
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

            //5-Word count
            //string input = "Please god give me a job t";
            //int count = calculateWordCount(input);
            //Console.WriteLine(count);



            //6-To count the number of occurrences of each character in a string like "aabbcca"
            //string input = "aabbcca";
            //CountCharacterOccurrences(input);

            //7-Given number is prime or not(A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself. In other words,
            //a prime number is only divisible by 1 and the number itself, )

            //Console.Write("Please enter a number");
            //int number = int.Parse(Console.ReadLine());
            //bool isPrime = true;
            //if (number < 2)
            //{
            //    isPrime = false;
            //}
            //else
            //{
            //    for(int i = 2; i < number; i++)
            //    {
            //        if(number % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine($"{number} is Prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is not a Prime");
            //    }
            //}

            //8:Remove duplicate elements from array//this logic will be work when the array is sorted


            //    int[] arr = { 6, 4, 4, 6, 2, 2, 1 };
            //    int[] temp = new int[arr.Length];

            //int j = 0;
            //for(int i = 0; i < arr.Length-1; i++)
            //{
            //    if(arr[i] != arr[i + 1])
            //    {

            //        temp[j++] = arr[i];
            //    }
            //}
            //temp[j++] = arr[arr.Length - 1];
            //for(int i = 0; i < j; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //9:Array Manipulation to Remove Duplicates and Move Zeros
            //int[] arr = { 1, 2, 3, 2, 0, 0, 6, 0 };
            //int[] result = MovingZerosEndwithDuplicateRemoval.MoveZerosAndRemoveDuplicates(arr);
            //Console.WriteLine(string.Join(",", result));

            //10 reverse string with built in method

            //string result = ReverseStringWithBuiltInMethod.ReverseStringWithBuilt();

            //11 nth highest number
            //NthHighestNumber.FindNthHighestNumber();

            //12 nth smallest number
            //FindNthSmallestNumber.FindNthMinimumNumber();

            //12 swap without temp
            SwapWithoutTemp.SwapTwoNumberWithoutTemp();


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
        //second approch for console first unique

        //         for(int i =0;i<input.Length;i++){
        //            bool isUnique = true;
        //            for(int j=0;j<input.Length;j++){
        //                if(i!=j && input[i]==input[j]){
        //                    isUnique = false;
        //                    break;
        //                }

        //}
        //if (isUnique)
        //{
        //    Console.WriteLine(input[i]);
        //    break;
        //}
        //        }


        //2-
        //Method to find second max highest number of an array
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

        //5-calculate word count

        //public static int calculateWordCount(string input)
        //{
        //    if (string.IsNullOrWhiteSpace(input))
        //    {
        //        return 0;
        //    }
        //    int count = 0;
        //    bool isWord = false;
        //    foreach (char c in input)
        //    {
        //        if (char.IsWhiteSpace(c))
        //        {
        //            isWord = false;
        //        }
        //        else
        //        {
        //            if (!isWord)
        //            {
        //                count++;
        //                isWord = true;
        //            }
        //        }
        //    }
        //    return count;
        //}
        //public static void CountCharacterOccurrences(string input)
        //{
        //    var charCount = new Dictionary<char, int>();

        //    foreach (char c in input)
        //    {
        //        if (charCount.ContainsKey(c))
        //        {
        //            charCount[c]++;
        //        }
        //        else
        //        {
        //            charCount[c] = 1;
        //        }
        //    }

        //    foreach (var item in charCount)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }
        //}

    }
}
