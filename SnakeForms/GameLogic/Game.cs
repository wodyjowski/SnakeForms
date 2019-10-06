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
        private readonly IPlayer player;

        public Game(ILogger logger, IPlayer player)
        {
            this.logger = logger;
            this.player = player;
        }
        public void Start()
        {
            logger.Log("Game has started");
            CreatPlayer();
            CreateGameTimer();
        }

        private void CreatPlayer()
        {
            player.CreatePlayer();
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
