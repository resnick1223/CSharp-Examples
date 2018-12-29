using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public interface IAttackBehavior
    {
        void Attack(Character character);
    }
}