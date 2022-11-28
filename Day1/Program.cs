// See https://aka.ms/new-console-template for more information
using Commons;
using System;

Console.WriteLine("Hello, World!");

// We read the input
int[] input = await FileCommons.ReadTextAsIntegerArray("Day1Input.txt");
int largerCount = 0;

for(int i = 1; i < input.Length; i++)
{
    // We compare the current value with the previous value
    if (input[i] > input[i - 1])
    {
        largerCount ++;
    }
}

Console.WriteLine($"There are {largerCount} measurements that show increasing");


/* 
 * Part two
 */

int previousTotal = 0;
int increaseCount = 0;

for (int i = 0; i < input.Length; i++)
{
    // Check if we can take 3 measurements
    if (i + 1 >= input.Length || i + 2 >= input.Length)
    {
        break;
    }

    int currentTotal = input[i] + input[i + 1] + input[i + 2];

    //Check if we have an increase
    if (currentTotal > previousTotal && previousTotal > 0)
    {
        increaseCount++;
    }

    previousTotal = currentTotal;
}

Console.WriteLine($"There are {increaseCount} measurements that show increasing for 3 consecutive measurements");