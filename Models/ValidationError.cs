﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XeroConnector.Model
{
    public class ValidationError
    {
        [DataMember(EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
