using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KnightLite
{   
    internal abstract class Npcs
    {
        private string _name;
        private float _hp;
        private int _maxHp;
        private int _dmg;
        public Npcs(string name, float hp, int maxHp, int dmg)
        {
            _name = name;
            _hp = hp;
            _maxHp = maxHp;
            _dmg = dmg;
        }
        public void GetHit()
        {
            _hp -= _dmg;

            if (_hp < 0)
            {
                _hp = 0;
            }
            Console.WriteLine($"{_name} took {_dmg} damage!");
        }


        public void Appear()
        {
            Console.Write($"{_name} has appeared!");
        }

        public void Attack()
        {
            Console.WriteLine($"{_name} attacks!");
            //edit once player is made
        }
    }
}
