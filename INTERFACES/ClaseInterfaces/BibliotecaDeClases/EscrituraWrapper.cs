﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

       public EscrituraWrapper(string text, ConsoleColor color)
        {
            this.color = color;
            this.texto = text;
        }

    }
}
