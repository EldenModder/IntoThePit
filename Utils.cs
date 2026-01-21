using Raylib_cs;

namespace IntoThePit
{
    internal class Utils
    {
        private readonly Game game;
        private readonly Player player;
        private readonly UI ui;

        private int offsetX = 400;

        public Utils(Game game, Player player, UI ui)
        {
            this.game = game;
            this.player = player;
            this.ui = ui;
        }
        public void ClampPlayerPosition()
        {
            player.Position.X = Math.Clamp(
                player.Position.X,
                ui.SidePanelWidth,
                game.WindowWidth - ui.SidePanelWidth - 10);
            player.Position.Y = Math.Clamp(
                player.Position.Y,
                0,
                game.WindowHeight - 16);
        }

        public Rectangle GetPlayArea() 
        {
            Rectangle area;
            area = new Rectangle(ui.SidePanelWidth, 0, game.WindowWidth - offsetX, game.WindowHeight);
            return area; 
        }
    }
}
