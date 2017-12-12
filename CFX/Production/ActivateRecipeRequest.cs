﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Production
{
    public class ActivateRecipeRequest : CFXMessage
    {
        public string RecipeName
        {
            get;
            set;
        }

        public string Lane
        {
            get;
            set;
        }

        public string Stage
        {
            get;
            set;
        }
    }
}
