﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiladores1
{
    internal class TransicionDestado
    {
        public DEstado destino;
        public string valor;

        public TransicionDestado(DEstado destino, string valor)
        {
            this.destino = destino;
            this.valor = valor;
        }
    }
}
