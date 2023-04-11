using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticoSkynet
{
    public class Eliminador
    {
        private string numeroSerie;
        private string tipo;
        private int prioridadBase;
        private string objetivo;
        private Int32 destino;

        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int PrioridadBase { get => prioridadBase; set => prioridadBase = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int Destino { get => destino; set => destino = value; }
    }
}