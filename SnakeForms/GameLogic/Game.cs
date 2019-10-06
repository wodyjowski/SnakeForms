using SnakeForms.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SnakeForms.GameLogic
{
    public class Game : IGame
    {
        private readonly ILogger logger;

        public Game(ILogger logger)
        {
            this.logger = logger;
        }
        public void Start()
        {
            logger.Log("Game has started");
        }
    }
}
