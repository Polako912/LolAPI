using System;
using System.Collections.Generic;
using System.Text;

namespace Champion.Core.Models
{
    public class ChampionRotation
    {
        public List<int> FreeChampionIds { get; set; }
        public List<int> FreeChampionIdsForNewPlayers { get; set; }
        public int MaxNewPlayerLevel { get; set; }
    }
}
