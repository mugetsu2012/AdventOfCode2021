// See https://aka.ms/new-console-template for more information
using Commons;

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