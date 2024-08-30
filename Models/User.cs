using Microsoft.AspNetCore.Identity;

namespace pokelab_api.Models
{
    public class User : IdentityUser
    {
        public PokeType[]? Secrets { get; set; }
        public Pokemon? Pokemon { get; set; }
    }
}
