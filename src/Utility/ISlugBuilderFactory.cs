﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Utility
{
    public interface ISlugBuilderFactory
    {
        ISlugBuilder Create();
    }
}
