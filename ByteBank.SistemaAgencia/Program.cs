﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(520, 120120);
            Console.WriteLine(conta.Agencia + " " + conta.Numero);
            Console.ReadLine();
            
        }
    }
}
