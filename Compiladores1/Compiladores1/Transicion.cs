﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiladores1
{
    internal class Transicion
    {
        public EDO destino;
        public string valor;

        public Transicion(EDO destino, string valor)
        {
            this.destino = destino;
            this.valor = valor;
        }
    }
}
