﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSharpAFD
{
    interface IValidacao
    {
        bool IsValid(Sistema sistema);
        bool IsValid(string palavra, Sistema sistema);

    }
}
