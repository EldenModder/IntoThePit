using System.Numerics;
using ImGuiNET;
using rlImGui_cs;


namespace IntoThePit
{
    internal class UI
    {
        private readonly Game game;
        public readonly float SidePanelWidth = 200f;

        public UI(Game game) => this.game = game;

        public void CreateUIContext()
        {
            try
            {
                rlImGui.Setup(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
        public void DrawGameUI()
        {
            Vector2 leftWindowPos = new Vector2(0, 0);
            Vector2 leftWindowSize = new Vector2(SidePanelWidth, game.WindowHeight);
            Vector2 rightWindowPos = new Vector2(game.WindowWidth - SidePanelWidth, 0);
            Vector2 rightWindowSize = new Vector2(SidePanelWidth, game.WindowHeight);

            ImGui.SetNextWindowPos(leftWindowPos, ImGuiCond.Always);
            ImGui.SetNextWindowSize(leftWindowSize, ImGuiCond.Always);
            ImGui.SetNextWindowBgAlpha(1);

            ImGui.Begin("Game Info",
                ImGuiWindowFlags.NoTitleBar |
                ImGuiWindowFlags.NoResize |
                ImGuiWindowFlags.AlwaysAutoResize |
                ImGuiWindowFlags.NoMove);

            ImGui.Text("Into The Pit");

            ImGui.End();

            ImGui.SetNextWindowPos(rightWindowPos, ImGuiCond.Always);
            ImGui.SetNextWindowSize(rightWindowSize, ImGuiCond.Always);
            ImGui.SetNextWindowBgAlpha(1);

            ImGui.Begin("Player Info",
                ImGuiWindowFlags.NoTitleBar |
                ImGuiWindowFlags.NoResize |
                ImGuiWindowFlags.AlwaysAutoResize |
                ImGuiWindowFlags.NoMove);

            ImGui.End();
        }
    }
}
