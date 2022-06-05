namespace PokemonApp.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; }


    }
}
