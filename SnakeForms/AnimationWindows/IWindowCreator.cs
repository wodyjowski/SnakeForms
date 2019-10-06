using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SnakeForms.AnimationWindows
{
    public interface IWindowCreator
    {
        public Window ObtainWindow(WindowType wType);
    }
}
