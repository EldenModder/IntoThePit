using System.Numerics;
using Raylib_cs;


//Static using
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using rlImGui_cs;

namespace IntoThePit
{
    internal class Game
    {
        //Object
        private UI ui;
        private Input input;
        private Utils utils;

        public Player player;

        public readonly int WindowWidth = 1280;
        public readonly int WindowHeight = 720;

        Font defaultFont;
        Vector2 startPosition;

        public void Start()
        {
            InitWindow(WindowWidth, WindowHeight, "IntoThePit");
            SetTargetFPS(60);
            defaultFont = GetFontDefault();
            ui = new UI(this);
            player = new Player(this);
            utils = new Utils(this, player ,ui);
            input = new Input(player, ui, utils);
            ui.CreateUIContext();
            startPosition = new Vector2(20, 10);
        }

        public void Update()
        {
            while (!WindowShouldClose())
            {
                BeginDrawing();

                ClearBackground(Black);

                input.Move();

                //Draw Player at Start
                DrawTextEx(defaultFont, player.Glyph, player.Position + startPosition, 16, 0, DarkBlue);

                //ImGui
                rlImGui.Begin();
                ui.DrawGameUI();
                rlImGui.End();

                EndDrawing();
            }
        }
        public void Quit()
        {
            rlImGui.Shutdown();
            CloseWindow();
        }
    }
}
