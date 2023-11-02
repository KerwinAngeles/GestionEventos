class Evento
{
    private string nombreEvento;
    private DateTime fecha;
    private string lugar;
    private string[] listaInvitados;
    private static int numeroDeEventosCreados;

    public Evento(string nombreEvento, DateTime fecha)
    {
        this.nombreEvento = nombreEvento;
        this.fecha = fecha;
        numeroDeEventosCreados++;
    }

    public Evento(string nombreEvento, DateTime fecha, string lugar)
    : this(nombreEvento, fecha)
    {
        this.nombreEvento = nombreEvento;
        this.fecha = fecha;
        this.lugar = lugar;
        numeroDeEventosCreados++;
    }

    public string NombreEvento { get { return nombreEvento; } set { nombreEvento = value; } }
    public DateTime Fecha { get { return fecha; } set { fecha = value; } }
    public string Lugar { get { return lugar; } set { lugar = value; } }
    public string[] ListaInvitados { get { return listaInvitados; } set { listaInvitados = value; } }

    public string[] AgregarInvitados(int cantidadInvitados)
    {
        string nombreInvitados;
        ListaInvitados = new string[cantidadInvitados];

        for (int i = 0; i < listaInvitados.Length; i++)
        {
            Console.WriteLine($"Ingresa el {i + 1} invitados");
            nombreInvitados = Console.ReadLine();
            ListaInvitados[i] = nombreInvitados;
        }
        Console.WriteLine("Invitados Agregados con exito");
        Console.WriteLine("");
        return ListaInvitados;
    }
    public string AgregarInvitados(string nombreInvitado)
    {
        return AgregarInvitados(nombreInvitado);
    }

    public static int CantidadDeEventos()
    {
        return numeroDeEventosCreados;
    }
    public void Invitados()
    {
        foreach (var item in ListaInvitados)
        {
            Console.WriteLine(item);
        }
    }


}