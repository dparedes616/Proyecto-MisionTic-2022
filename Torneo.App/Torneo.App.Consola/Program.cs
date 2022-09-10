using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using System;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT _repoDT = new RepositorioDT();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        static void Main(string[] args)
        {
            int opcion =0;
            do
            {
                Console.WriteLine("1. Insertar Municipio");
                Console.WriteLine("2. Insertar Director Tecnico");
                Console.WriteLine("3. Insertar Jugador");
                Console.WriteLine("4. Insertar Equipo");
                Console.WriteLine("0. Salir");
                opcion=Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddDT();
                        break;
                    case 3:
                        AddJugador();
                        break;
                     case 4:
                        AddEquipo();
                        break;
                }
            }while (opcion !=0);           
        }
        private static void AddMunicipio()
        {
            Console.WriteLine("Ingrese el nombre del municipio");
            string nombre = Console.ReadLine();            
            var municipio = new Municipio{Nombre = nombre,};
            _repoMunicipio.AddMunicipio(municipio);
        }
        private static void AddDT()
        {
            Console.WriteLine("Ingrese el nombre del director técnico");
            string nombre =Console.ReadLine();
            Console.WriteLine("Ingrese el documento del director técnico");
            string documento =Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del director técnico");
            string telefono =Console.ReadLine();
            var dt=new DirectorTecnico{Nombre= nombre,Documento=documento,Telefono=telefono,};
            _repoDT.AddDT(dt);
        }
        private static void AddJugador()
        {
            Console.WriteLine("Ingrese el nombre del jugador");
            string nombre =Console.ReadLine();
            Console.WriteLine("Ingrese el numero del jugador");
            string numero =Console.ReadLine();
            Console.WriteLine("Ingrese el id del equipo del jugador");
            int idequipo =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el id de la posición del jugador");
            int idposición =Int32.Parse(Console.ReadLine());
            var jugador=new Jugador{Nombre=nombre, Numero=numero,};
            _repoJugador.AddJugador(jugador,numero,idequipo,idposición);
        }
        private static void AddEquipo()
        {
            Console.WriteLine("Ingrese el nombre del equipo");
            string nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el id del municipio del equipo");
            int idMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el id del director técnico del equipo");
            int idDT= Int32.Parse(Console.ReadLine());
            var equipo = new Equipo{Nombre=nombre};
            _repoEquipo.AddEquipo(equipo,idMunicipio,idDT);
        }
    }
}