namespace Commons
{
    public static class FileCommons
    {
        public static async Task<string> ReadTextFile(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }

        public static async Task<int[]> ReadTextAsIntegerArray(string filePath)
        {
            string[] lines = await File.ReadAllLinesAsync(filePath);

            return Array.ConvertAll(lines, x => int.Parse(x));            
        }
    }
}