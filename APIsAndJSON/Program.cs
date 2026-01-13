namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise One Ron vs Kayne
            var api = new RonVsKanyeApi(); 
            
            for (int i = 0; i < 3; i++) { 
                Console.WriteLine($"Kanye: {api.KayneSpeaks()}"); 
                Console.WriteLine($"Ron: {api.RonSpeaks()}"); Console.WriteLine(); 
            }
            
            //Exercise Two return OpenWeatherMapAPI
            var weatherApi = new OpenWeatherMapAPI(); 
            var report = weatherApi.ReturnWeather(); 
            Console.WriteLine("Weather report retrieved:"); 
            Console.WriteLine(report);
        }
    }
}
