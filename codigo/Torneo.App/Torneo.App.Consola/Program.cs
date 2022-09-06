using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program 
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        private static IRepositorioDT _repoDt = new RepositorioDT();
        static void Main(string [] args)
        {
            int opción = 0;
            do
            {
                Console.WriteLine("1 Insertar un municipio");
                Console.WriteLine("2 Inserte una posición");
                Console.WriteLine("3 Insertar un partido");
                Console.WriteLine("4 Insertar un director tecnico");
                Console.WriteLine("0 Salir");
                opción = Int32.Parse(Console.ReadLine());
                switch (opción)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddPosicion();
                        break;
                    case 3:
                        AddPartido();
                        break;
                    case 4:
                        AddDT();
                        break;

                }

            } while (opción != 0);
        }

//__________________________________________________________________________________________________________//

        private static void AddMunicipio()
        {
            Console.WriteLine("Ingrese el nombre del municipio");
            string nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
//__________________________________________________________________________________________________________//
        private static void AddPosicion()
        {
            Console.WriteLine("Ingrese una posición");
            string nombre = Console.ReadLine();
            var posicion = new Posicion
            {
                Nombre = nombre,
            };
            _repoPosicion.AddPosicion(posicion);
        }
//__________________________________________________________________________________________________________//
        private static void AddPartido()
        {
            Console.WriteLine("Ingrese la fecha del partido");
            string FechaHora = Console.ReadLine();
            DateTime FechaPartido = DateTime.Parse(FechaHora);
            Console.WriteLine("Ingrese el equipo local");
            int Local = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese marcador equipo local");
            int MarcadorLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mel equipo visitante");
            int Visitante = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese marcador equipo visitante");
            int MarcadorVisitante = Int32.Parse(Console.ReadLine());
            
            /*var EquipoLocal = new Equipo
            {
                Nombre = Local
            };

            var EquipoVisitante = new Equipo
            {
                Nombre =Visitante
            };*/

            var partido = new Partido
            {
                FechaHora = FechaPartido,
                Local = Local,
                MarcadorLocal = MarcadorLocal,
                Visitante = Visitante,
                MarcadorVisitante = MarcadorVisitante,
            };
            _repoPartido.AddPartido(partido);
        }
//__________________________________________________________________________________________________________//

        private static void AddDT()
        {
            Console.WriteLine("Ingrese el nombre del director tecnico");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el documento del director tecnico");
            string documento = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del director tecnico");
            string telefono = Console.ReadLine();
            var directorTecnico = new DT
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDt.AddDT(directorTecnico);
        }


    }
}