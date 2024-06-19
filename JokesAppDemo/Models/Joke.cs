namespace JokesAppDemo.Models
{
    public class Joke
    {
        //Simple example of properties in an object/class
        public int Id { get; set; }
        public string? JokeQuestion { get; set; }
        public string? JokeAnswer { get; set; }
        public int? Rating { get; set; } 

        // Class Method/Constructor
        public Joke()
        {
           
        }
    }
}
