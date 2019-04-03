using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProperties
{
    class Player
    {
        public bool isAlive = true;
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        public void CheckDeath()
        {
            if (health <= 0)
                isAlive = false;
        }
    }