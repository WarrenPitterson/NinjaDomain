using System.Collections.Generic;

namespace NinjaDomain
{
    public class Clan
    {
        public int Id { get; set; }
        public string ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }

    }
}
