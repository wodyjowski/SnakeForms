using SnakeForms.AnimationWindows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace SnakeForms.GameLogic
{
    class Player : IPlayer
    {
        public double X { get => playerWindow.Left; set => playerWindow.Left = value; }

        public double Y { get => playerWindow.Left; set => playerWindow.Left = value; }

        private Window playerWindow;
        private readonly IWindowCreator windowCreator;

        public Player(IWindowCreator windowCreator)
        {
            this.windowCreator = windowCreator;
        }
        public void CreatePlayer()
        {
            playerWindow = windowCreator.CreateWindow(WindowType.SquareWindow);
            playerWindow.Topmost = true;
            playerWindow.KeyDown += PlayerWindow_KeyDown;
            playerWindow.Left = 0;
            playerWindow.Top = 0;
            playerWindow.Show();
        }

        private void PlayerWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left: playerWindow.Left -= playerWindow.Width;
                    break;
                case Key.Right:
                    playerWindow.Left += playerWindow.Width;
                    break;
                case Key.Up:
                    playerWindow.Top -= playerWindow.Height;
                    break;
                case Key.Down:
                    playerWindow.Top += playerWindow.Height;
                    break;

            }
        }
    }
}
