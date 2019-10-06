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
        public PlayerWindow()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Topmost = true;

            Task drawingTask = new Task(() => Moove(this));
            drawingTask.Start();
            Show();
        }

        private async void Moove(Window w)
        {
            double a = 0;

            while (true)
            {
                w.Dispatcher.Invoke((Action)(() =>
                {
                    w.Left = (w.Left + w.Width) % 1920;
                    w.Top = 0;

                }));

                a += 0.1;
                await Task.Delay(500);
            }
        }
    }
}
