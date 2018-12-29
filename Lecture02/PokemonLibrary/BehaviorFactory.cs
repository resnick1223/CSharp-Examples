using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace PokemonLibrary
{
    public class BehaviorFactory
    {
        public static IAttackBehavior CreateBehavior(string nampspacePath)
        {
            Assembly assembly = typeof(IAttackBehavior).Assembly;
            return (IAttackBehavior)assembly.CreateInstance(nampspacePath);
        }
    }
}