﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Profesor
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public string NombreCompleto => $"{Nombres} {Apellidos}";
    }
}

