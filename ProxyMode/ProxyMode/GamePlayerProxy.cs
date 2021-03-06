﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    public class GamePlayerProxy : IGamePlayer, IProxy
    {
        private IGamePlayer gamePlayer = null;

        public GamePlayerProxy(IGamePlayer _gamePlayer)
        {
            this.gamePlayer = _gamePlayer;
        }

        public void login(string user, string password)
        {
            this.gamePlayer.login(user, password);
        }

        public void killBoss()
        {
            this.gamePlayer.killBoss();
        }

        public void upgrade()
        {
            this.gamePlayer.upgrade();
        }

        public IGamePlayer getProxy()
        {
            return this;
        }

        public void count()
        {
            Console.WriteLine("Cost: $100");
        }
    }
}
