using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Story
{
    class Player
    {
        public int PlayerHealth { get; set; }
        public int PlayerBA { get; set; }
        public int PlayerWD { get; set; }

        public void PlayerSAttack()
        {
            Console.WriteLine("You hit the Enemy! with your special Attack!");
        }
        public void PlayerWAttack()
        {
            Console.WriteLine("You hit the Enemy! with your Weapon!");
        }
        public void PlayerBAttack()
        {
            Console.WriteLine("You hit the Enemy! with your Basic Attack! he loses 50 points of HP");
        }


    }











}
