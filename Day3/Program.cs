string[] inputLines = await File.ReadAllLinesAsync("Day3Input.txt");

// We take one item to get the leght of that item, we asume all the other items have the same length
int lineLength = inputLines[0].Length;
string gammaRate = string.Empty;
string epsilonRate = string.Empty;

// First, we loop all the first digit of the line, the the second and so on
for (int i = 0; i < lineLength; i++)
{
    int oneCount = inputLines.Count(x => x[i] == '1');
    int zeroCount = inputLines.Count(x => x[i] == '0');

    // We print the most common in that position
    if (oneCount > zeroCount)
    {        
        gammaRate += "1";
        epsilonRate += "0";
    }
    else
    {        
        gammaRate += "0";
        epsilonRate += "1";
    }
}

//We convert the gamma and epsilon rates to decimal
int gammaRateDecimal = Convert.ToInt32(gammaRate, 2);
int epsilonRateDecimal = Convert.ToInt32(epsilonRate, 2);

Console.WriteLine($"Gamma rate: {gammaRate}. Decimal: {gammaRateDecimal}");
Console.WriteLine($"Epsilon rate: {epsilonRate}. Decimal: {epsilonRateDecimal}");
Console.WriteLine($"Multiplying gamma and epsilon rates: {gammaRateDecimal * epsilonRateDecimal}");

//Part two

string[] candidatesOxygen = inputLines;
string candidateOxygen = string.Empty;

for (int i = 0; i < lineLength; i++)
{
    int totalOnes = candidatesOxygen.Count(x => x[i] == '1');
    int totalZeros = candidatesOxygen.Count(x => x[i] == '0');

    if (totalOnes > totalZeros || totalOnes == totalZeros)
    {
        candidatesOxygen = candidatesOxygen.Where(x => x[i] == '1').ToArray();
    }
    else
    {
        candidatesOxygen = candidatesOxygen.Where(x => x[i] == '0').ToArray();
    }

    // If we are at the end and we have only one candidate, thats our oxygen rate
    if (candidatesOxygen.Length == 1)
    {
        candidateOxygen = candidatesOxygen[0];
    }
}

string[] candidatesCO2 = inputLines;
string candidateCO2 = string.Empty;

for (int j = 0; j < lineLength; j++)
{
    int totalOnes = candidatesCO2.Count(x => x[j] == '1');
    int totalZeros = candidatesCO2.Count(x => x[j] == '0');

    if (totalOnes > totalZeros || totalOnes == totalZeros)
    {
        candidatesCO2 = candidatesCO2.Where(x => x[j] == '0').ToArray();
    }
    else
    {
        candidatesCO2 = candidatesCO2.Where(x => x[j] == '1').ToArray();
    }

    // If we are at the end and we have only one candidate, thats our oxygen rate
    if (candidatesCO2.Length == 1)
    {
        candidateCO2 = candidatesCO2[0];
        break;
    }
}

int oxygenRateDecimal = Convert.ToInt32(candidateOxygen, 2);
int CO2RateDecimal = Convert.ToInt32(candidateCO2, 2);

Console.WriteLine($"Oxygen rate: {candidateOxygen}. Decimal: {oxygenRateDecimal}");
Console.WriteLine($"CO2 rate: {candidateCO2}. Decimal: {CO2RateDecimal}");
Console.WriteLine($"Life support rating: {oxygenRateDecimal * CO2RateDecimal}");