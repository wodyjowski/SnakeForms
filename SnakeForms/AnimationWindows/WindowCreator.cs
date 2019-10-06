using SnakeForms.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SnakeForms.AnimationWindows
{
    public class WindowCreator : IWindowCreator
    {
        private readonly ILogger logger;

        public WindowCreator(ILogger logger)
        {
            this.logger = logger;
        }

        public Window CreateWindow(WindowType wType)
        {
            logger.Log("Creating Window...");

            switch (wType)
            {
                case WindowType.SquareWindow: return new SquareWindow();
            }

            throw new InvalidOperationException($"Unsupported window type: {wType}");
        }
    }
}
