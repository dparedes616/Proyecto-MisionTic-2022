﻿using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Console
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT _repoDT = new RepositorioDT();
        static void Main(string[] args)
        {
            int opcion =0;
            do
            {
                Console.WriteLine("1. Insertar Municipio");
                Console.WriteLine("2. Insertar Director Tecnico");
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
                }
            }while(opcion !=0);           
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
            _repoDT.AddDT(nombre);
        }
    }
}