using AdminEliminadorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPracticoSkynet
{
    public partial class Program
    {
        static EliminadorDAL eliminadorDAL = new EliminadorDAL();

        static void MostrarEliminadores()
        {
            List<Eliminador> eliminadores = eliminadorDAL.ListarEliminadores();
            
            for (int i = 0; i < eliminadores.Count; i++)
            {
                Eliminador eliminadorActual = eliminadores[i];
                Console.WriteLine("Numero de serie: {0}\n Tipo:{1}", eliminadorActual.NumeroSerie, eliminadorActual.Tipo);
            }
        }

        static void BuscarEliminadores()
        {
            Console.WriteLine("Ingrese numero de serie.");
            new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim())
                             .ForEach(e => Console.WriteLine("Numero de serie: {0}\n Tipo:{1}", e.NumeroSerie, e.Tipo));
            List<Eliminador> eliminadores = new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim());
            foreach (Eliminador e in eliminadores)
            {
                Console.WriteLine("Numero de serie: {0}\n Tipo:{1}", e.NumeroSerie, e.Tipo);
            }
        }

        static void IngresarEliminador()
        {
            string numeroSerie;
            string tipo;
            int prioridadBase;
            string objetivo;
            Int32 destino;
            List<string> tiposValidos = new List<string>();
            tiposValidos.Add("T-1");
            tiposValidos.Add("T-800");
            tiposValidos.Add("T-1000");
            tiposValidos.Add("T-3000");

            Console.WriteLine("Ingrese datos del Eliminador a agregar.");
            bool esValido;

            do
            {
                Console.WriteLine("Ingrese numero de serie. Debe tener un largo de siete (7) caracteres:");
                numeroSerie = Console.ReadLine().Trim();
            } while (numeroSerie.Length != 7);

            do
            {
                Console.WriteLine("Ingrese tipo de Eliminador. Debe ser uno de los siguientes tipos:");
                foreach (string valido in tiposValidos)
                {
                    Console.WriteLine(valido);
                }
                tipo = Console.ReadLine().Trim();
            } while (!tiposValidos.Contains(tipo));

            do
            {
                Console.WriteLine("Ingrese prioridad base del objetivo:");
                esValido = int.TryParse(Console.ReadLine().Trim(), out prioridadBase);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese objetivo para el Eliminador:");
                objetivo = Console.ReadLine().Trim();
            } while (objetivo.Length == 0);

            do
            {
                Console.WriteLine("Ingrese año de destino:");
                esValido = Int32.TryParse(Console.ReadLine().Trim(), out destino);
            } while (!esValido && destino < 3000 && destino > 1997);

            Eliminador e = new Eliminador()
            {
                NumeroSerie = numeroSerie,
                Tipo = tipo,
                PrioridadBase = prioridadBase,
                Objetivo = objetivo,
                Destino = destino
            };
            eliminadorDAL.AgregarEliminador(e);

            Console.WriteLine("Se agrego el siguiente Eliminador:");
            Console.WriteLine("Numero de Serie: {0} ", e.NumeroSerie);
            Console.WriteLine("Tipo: {0} ", e.Tipo);
            Console.WriteLine("Prioridad base: {0} ", e.PrioridadBase);
            Console.WriteLine("Objetivo a eliminar: {0} ", e.Objetivo);
            Console.WriteLine("Año de destino : {0} ", e.Destino);



        }
    }
}
