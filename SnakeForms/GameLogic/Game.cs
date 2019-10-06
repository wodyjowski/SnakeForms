using SnakeForms.AnimationWindows;
using SnakeForms.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace SnakeForms.GameLogic
{
    public class Game : IGame
    {
        private readonly ILogger logger;
        private readonly IPlayerWindow playerW;

        public Game(ILogger logger, IPlayerWindow playerW)
        {
            this.logger = logger;
            this.playerW = playerW;
        }
        public void Start()
        {
            logger.Log("Game has started");
            playerW.Start();
        }

    }
}
