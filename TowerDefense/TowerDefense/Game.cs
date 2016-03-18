using TowerDefense.Audio;
using TowerDefense.Data;
using TowerDefense.Graphics;
using TowerDefense.IO;
using System;

namespace TowerDefense
{
    public static class TowerDefense
    {
        // Global variables related to the game.
        public static readonly string StartupPath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string DataPath = TowerDefense.StartupPath + "data\\";
        public static GameState State { private set; get; }
        public static GameFlag Flag { private set; get; }

        // The main point of entry for the application.
        private static void Main(string[] args) {

            // Check the folders and files in the system.
            FolderSystem.Check();

            // Load the game data.
            DataManager.Load();

            // Initialize the audio system.
            AudioManager.Initialize();

            // Initialize the game graphics.
            GraphicsManager.Initialize();

            // Start the game-loop.
            TowerDefense.GameLoop();
        }

        private static void GameLoop() {
            int tick = 0, tick16 = 0;

            // Mark the game as running, and show the main window.
            TowerDefense.Flag = GameFlag.Running;

            // Continue to run the game-loop as long as our game
            // is not closing.
            while (TowerDefense.Flag != GameFlag.Closing) {
                tick = Environment.TickCount;

                // Render graphics up to 60 times a second.
                if (tick16 < tick) {
                    GraphicsManager.Graphics?.Draw();
                    tick16 = tick + 16;
                }
            }

            // The game will only be destroyed when the flag is set to closing.
            TowerDefense.Destroy();
        }

        public static void SetGameState(GameState state) {
            switch (state) {
                case GameState.MainMenu:
                    TowerDefense.State = state;
                    break;
                default:
                    return;
            }
        }

        public static void SetGameFlag(GameFlag flag) {
            // Make sure we can't change the flag if we're already closing.
            if (TowerDefense.Flag == GameFlag.Closing) {
                return;
            }

            TowerDefense.Flag = flag;
        }

        private static void Destroy() {
            // Make sure that the game-loop has stopped, and
            // that we didn't call this on accident.
            if (TowerDefense.Flag != GameFlag.Closing) {
                return;
            }

            // Before closing the game, save all relevant data.
            DataManager.Save();
            Environment.Exit(0);
        }
    }
}
