namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var api = new RonVsKanyeApi(); for (int i = 0; i < 5; i++) { 
                Console.WriteLine($"Kanye: {api.KayneSpeaks()}"); 
                Console.WriteLine($"Ron: {api.RonSpeaks()}"); Console.WriteLine(); 
            }
        }
    }
}
