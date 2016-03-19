using TowerDefense.Data.Models.Towers;

namespace TowerDefense.Data.Models.Maps
{
    public class Map
    {
        // Map constants
        public const int TILE_WIDTH = 64;
        public const int TILE_HEIGHT = 64;

        public Home Home;
        public Tower[] Towers;
        //private Virus[] viruses;
        public Position SpawnLocation;

    }
}
