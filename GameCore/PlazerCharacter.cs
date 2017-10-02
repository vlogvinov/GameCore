﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class PlazerCharacter
    {
        public int Health { get; private set; } = 100;
        public bool IsDead { get; private set; }

        public void Hit(int damage)
        {
            Health -= damage;
            if(Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}
