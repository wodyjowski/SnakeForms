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

        private void Moove(Window w)
        {
            double a = 0;

            while (true)
            {
                w.Dispatcher.Invoke((Action)(() =>
                {
                    w.Left = ((System.Windows.SystemParameters.PrimaryScreenWidth - w.Width) / 2) + Math.Cos(a) * 200;
                    w.Top = ((System.Windows.SystemParameters.PrimaryScreenHeight - w.Height) / 2) + Math.Sin(a) * 200;

                }));

                a += 0.001;
                Task.Delay(200);
            }
        }
    }
}
