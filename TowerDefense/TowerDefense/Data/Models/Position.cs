namespace TowerDefense.Data.Models
{
    public class Position
    {
        public int X { private set; get; } 
        public int Y { private set; get; }

        public Position() {
            this.X = 0;
            this.Y = 0;
        }

        public Position(int x, int y) {
            this.X = x;
            this.Y = y;
        }
    }
}
