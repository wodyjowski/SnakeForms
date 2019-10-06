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

        public Game(ILogger logger)
        {
            this.logger = logger;
        }
        public void Start()
        {
            logger.Log("Game has started");
            CreateGameTimer();
        }

        private void CreateGameTimer()
        {
            Timer timer = new Timer(new TimerCallback(TimeEvent), 0, 500, 500);
        }

        private void TimeEvent(object state)
        {
            logger.Log("Game tick");
        }
    }
}
