// We read the lines
string[] lines = await File.ReadAllLinesAsync("Day2Input.txt");

int currentHorizontalPos = 0;
int currentDepth = 0;

// We loop and evaluate each line
for(int i = 0; i < lines.Length; i++)
{
    // We splipt the line into an array of string. We know that the format is like: forward 1
    string[] parts = lines[i].Split(' ');

    // We evaluate the direction
    switch (parts[0])
	{
		case "forward":
			currentHorizontalPos += int.Parse(parts[1]);
			break;

		case "up":
			currentDepth -= int.Parse(parts[1]);
			break;

		case "down":
            currentDepth += int.Parse(parts[1]);
            break;

		default:
			break;
	}

}


Console.WriteLine($"The current horizontal position is: {currentHorizontalPos} and the current depth is: {currentDepth}");
Console.WriteLine($"The multiply of these is: {currentDepth*currentHorizontalPos}");

