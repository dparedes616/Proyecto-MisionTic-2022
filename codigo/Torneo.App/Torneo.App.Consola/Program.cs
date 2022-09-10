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
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        static void Main(string [] args)
        {
            int opción = 0;
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("-----------MENU----------");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Insertar un municipio"); /*ok*/
                Console.WriteLine("2. Inserte una posición"); /*ok*/
                Console.WriteLine("3. Insertar un partido");
                Console.WriteLine("4. Insertar un director tecnico"); /*ok*/
                Console.WriteLine("5. Insertar un equipo"); /*ok*/
                Console.WriteLine("6. Insertar un jugador"); /*ok*/
                Console.WriteLine("-------------------------");
                Console.WriteLine("7. Mostrar lista municipios"); /*ok*/
                Console.WriteLine("8. Mostrar lista directores tecnicos"); /*ok*/
                Console.WriteLine("9. Mostrar lista posiciones"); /*ok*/
                Console.WriteLine("10. Mostrar lista equipos"); /*ok*/
                Console.WriteLine("-------------------------");
                Console.WriteLine("0. Salir"); /*ok*/
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
                    case 5:
                        AddEquipo();
                        break;
                    case 6:
                        AddJugador();
                        break;
                    case 7:
                        GetAllMunicipios();
                        break;
                    case 8:
                        GetAlldT();
                        break;
                    case 9:
                        GetAllPosiciones();
                        break;
                    case 10:
                        GetAllEquipos();
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
            int IdLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese marcador equipo local");
            int marcadorLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mel equipo visitante");
            int IdVisitante = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese marcador equipo visitante");
            int marcadorVisitante = Int32.Parse(Console.ReadLine());
            
            var partido = new Partido
            {
                FechaHora = FechaPartido,

            };
            _repoPartido.AddPartido(partido, FechaPartido, IdLocal, marcadorLocal, IdVisitante, marcadorVisitante);
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
         //__________________________________________________________________________________________________________//

        private static void AddEquipo()
        {
            Console.WriteLine("Ingrese el nombre del equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el id del municipio");
            int IdMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese id del director tecnico");
            int IdDT = Int32.Parse(Console.ReadLine());

            var equipo = new Equipo 
            {
                Nombre = nombre,
            };
            _repoEquipo.AddEquipo(equipo, IdMunicipio, IdDT);
        }

         //__________________________________________________________________________________________________________//

        private static void AddJugador()
        {
            Console.WriteLine("Ingrese el nombre del jugador");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del jugador");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese id equipo");
            int IdEquipo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese id la posición");
            int IdPosicion = Int32.Parse(Console.ReadLine());

            var jugador = new Jugador 
            {
                Nombre = nombre,
                Numero = numero,
            };
            _repoJugador.AddJugador(jugador, IdEquipo, IdPosicion);
        }

            //Metodo Get Municipios__________________________________________________________________________________________________________//

        private static void GetAllMunicipios()
        { 
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }

            //Metodo Get Dts__________________________________________________________________________________________________________//

        private static void GetAlldT()
        { 
            foreach (var directoresTecnicos in _repoDt.GetAlldT())
            {
                Console.WriteLine(directoresTecnicos.Id + " " + directoresTecnicos.Nombre);
            }
        }

            //Metodo Get Posiciones__________________________________________________________________________________________________________//

        private static void GetAllPosiciones()
        { 
            foreach (var posiciones in _repoPosicion.GetAllPosiciones())
            {
                Console.WriteLine(posiciones.Id + " " + posiciones.Nombre);
            }
        }

            //Metodo Get Equipos__________________________________________________________________________________________________________//

        private static void GetAllEquipos()
        { 
            foreach (var equipos in _repoEquipo.GetAllEquipos())
            {
                Console.WriteLine(equipos.Nombre + " " + equipos.Municipio.Nombre + " " + equipos.DirectorTecnico.Nombre);
            }
        }
    }
}