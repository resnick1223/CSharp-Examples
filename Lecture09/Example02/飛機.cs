﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class 飛機 : 可飛行的道具
    {
        public override void 飛行()
        {
            Console.WriteLine("用飛機飛行");
        }
    }
}