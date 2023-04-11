using EjercicioPracticoSkynet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEliminadorModel.DAL
{
    public class EliminadorDAL
    {
        private static List<Eliminador> eliminadores = new List<Eliminador>();

        public void AgregarEliminador(Eliminador eliminador)
        {
            eliminadores.Add(eliminador);
        }

        public List<Eliminador> ListarEliminadores()
        {
            return eliminadores;
        }

        public List<Eliminador> FiltrarEliminadores(string numeroSerie)
        {
            return eliminadores.FindAll(p => p.NumeroSerie.ToLower() == numeroSerie.ToLower());
        }
    }
}
