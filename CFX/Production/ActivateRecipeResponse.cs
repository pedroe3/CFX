﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CFX.Production
{
    public class ActivateRecipeResponse : CFXMessage
    {
        public ActivateRecipeResponse()
        {
            Result = new RequestResult();
        }

        public RequestResult Result
        {
            get;
            set;
        }
    }
}