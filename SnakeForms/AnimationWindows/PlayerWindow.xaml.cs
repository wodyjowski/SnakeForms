using SnakeForms.GameLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SnakeForms.AnimationWindows
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window, IPlayerWindow
    {
        private Directions direction;
        private readonly double distance = 50;

        public PlayerWindow()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Topmost = true;
            direction = Directions.Right;

            Task drawingTask = new Task(() => Moove(this));
            drawingTask.Start();
            Show();
        }

        private async void Moove(Window w)
        {
            double left = 0;
            double top = 0;

            while (true)
            {
                w.Dispatcher.Invoke((Action)(() =>
                {
                    Left = CalculateLeft(Left);
                    Top = CalculateTop(Top);

                    //w.Left = left;
                    //w.Top = top;

                }));

                await Task.Delay(500);
            }
        }

        private double CalculateLeft(double left)
        {
            switch(direction)
            {
                case Directions.Right:
                    return left + distance;
                case Directions.Left:
                    return left - distance;
            }

            return left;
        }

        private double CalculateTop(double top)
        {
            switch (direction)
            {
                case Directions.Up:
                    return top - distance;
                case Directions.Down:
                    return top + distance;
            }

            return top;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Up:
                    direction = Directions.Up;
                    break;
                case Key.Down:
                    direction = Directions.Down;
                    break;
                case Key.Left:
                    direction = Directions.Left;
                    break;
                case Key.Right:
                    direction = Directions.Right;
                    break;
            }

            Left = CalculateLeft(Left);
            Top = CalculateTop(Top);
        }
    }
}
