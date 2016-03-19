﻿namespace TowerDefense.Graphics
{
    public static class GraphicsManager
    {
        // Directories
        public static readonly string SurfacePath = Game.StartupPath + "data\\surfaces\\";
        public static readonly string GuiPath = GraphicsManager.SurfacePath + "gui\\";
        public static readonly string FontPath = Game.DataPath + "fonts\\";
        public static readonly string TowerPath = SurfacePath + "towers\\";

        // The class object containing the graphics system.
        public static IGraphics Graphics { private set; get; }

        public static void Initialize() {
            // Set and initialize the graphics system.
            GraphicsManager.Graphics = new Sfml.Sfml();
        }
    }
}
