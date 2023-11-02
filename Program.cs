using System;
using System.Security.Cryptography.X509Certificates;

namespace GestionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            string fecha = " ";
            int opc = 0;
            string nombreEvento = " ";
            string lugar = " ";
            DateTime dateTime;

            Console.WriteLine("Ingrese la cantidad de eventos");
            int cantidadEventos = int.Parse(Console.ReadLine());
            Evento[] evento = new Evento[cantidadEventos];

            do
            {

                Console.WriteLine("-----------------------------");
                Console.WriteLine("SISTEMA DE GESTION DE EVENTOS");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ");

                Console.WriteLine("MENU DE OPCIONES" +
                "\n 1: Agregar eventos y invitados " +
                "\n 2: Mostrar eventos por fechas. " +
                "\n 3: Mostrar eventos por lugar. " +
                "\n 4: Mostrar eventos de un lugar especifico. " +
                "\n 5: Mostrar lista de invitados " + 
                "\n 6: Salir.");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad de invitados que desea agregar");
                        int cantidadInvitados = int.Parse(Console.ReadLine());
                        for (int i = 0; i < cantidadEventos; i++)
                        {
                            Console.WriteLine($"Ingrese el nombre del {i + 1} evento");
                            nombreEvento = Console.ReadLine();

                            Console.WriteLine($"Ingrese la fecha del evento {nombreEvento}");
                            fecha = Console.ReadLine();

                            Console.WriteLine($"Ingrese el lugar del evento {nombreEvento}");
                            lugar = Console.ReadLine();
                            dateTime = DateTime.Parse(fecha);

                            evento[i] = new Evento(nombreEvento, dateTime, lugar);
                            evento[i].AgregarInvitados(cantidadInvitados);
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("EVENTOS POR FECHAS");

                        for (int i = 0; i < cantidadEventos; i++)
                        {
                            Console.WriteLine($"Fecha del evento {evento[i].NombreEvento}: {evento[i].Fecha}");
                        }
                        Console.ReadKey();
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("EVENTOS POR LUGAR");

                        for (int i = 0; i < cantidadEventos; i++)
                        {
                            Console.WriteLine($"Lugar del evento {evento[i].NombreEvento}: {evento[i].Lugar}");

                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("LUGAR ESPECIFICO");
                        for (int i = 0; i < cantidadEventos; i++)
                        {
                            if(evento[i].Lugar == "Estadio Olimpico")
                            Console.WriteLine($"Lugar del evento {evento[i].NombreEvento}: {evento[i].Lugar}");

                        }
                        Console.ReadKey();
                        break;
                    
                    case 5:
                        Console.Clear();
                        Console.WriteLine("LISTA DE INVITADOS");
                        for (int i = 0; i < cantidadEventos; i++)
                        {
                            evento[i].Invitados();
                        }
                        Console.ReadKey();
                        break;
                }
            } while (opc != 6);
        }
    }
}
