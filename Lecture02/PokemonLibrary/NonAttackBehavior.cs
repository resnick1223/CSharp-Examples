using System;

namespace PokemonLibrary
{
    internal class NonAttackBehavior : IAttackBehavior
    {
        public void Attack(Character character)
        {
            Console.WriteLine("無法攻擊");
        }
    }
}