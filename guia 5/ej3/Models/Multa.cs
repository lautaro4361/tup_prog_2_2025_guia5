﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ej3.Models
{
    public class Multa : IImportable
    {
        public double Valor { get; set; }

        public Multa()
        {
        }

        public Multa(double valor)
        {
            Valor = valor;
        }


        public bool Importar(string xml)
        {
            Regex regex = new Regex(@"[\S\s]*?<importe>([\w\s,]+?)</importe>[\S\s]*?", RegexOptions.IgnoreCase);
            Match match = regex.Match(xml);
            if (match.Success == false)
                return false;

            Valor = Convert.ToDouble(match.Groups[1].Value);

            return true;
        }
    }
}
