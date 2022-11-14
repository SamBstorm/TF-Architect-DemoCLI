namespace DemoCLI
{
    public struct ConsoleAvancee
    {
        public static void WriteLineVertical(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                Console.WriteLine(c);
            }
        }

        public static string EncodeMessage(string message, int step)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                c = (char)(c + step);
                result += c;
            }
            return result;
        }
    }
}
