﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IAbstractFactory
    {
        IEventBs CreateEventObject();
    }
}
