﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediviaBot.input
{
    class MouseScrollUp : Input
    {
        public MouseScrollUp(Point location, int priority) : base (priority, InputType.Mouse)
        {
            Priority = priority;
            Location = location;
        }

        public Point Location { get; set; }
    }
}
