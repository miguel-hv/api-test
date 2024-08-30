public class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
}

namespace pokelab_api.Models { 
    public static class PokemonDictionary
    {

        public static Dictionary<string, Pokemon> PokemonList { get; } = new Dictionary<string, Pokemon>
        {
             { "charmander", new Pokemon { Name = "charmander", Type = "fire" } },
             { "squirtle", new Pokemon { Name = "squirtle", Type = "water" } },
             { "bulbasaur", new Pokemon { Name = "bulbasaur", Type = "grass" } },
        };

    }
}
