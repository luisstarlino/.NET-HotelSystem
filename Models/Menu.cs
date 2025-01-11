namespace DesafioProjetoHospedagem.Models;

public class Menu
{
    public bool Online { get; set; }
    List<Suite> AvailableSuites { get; set; }
    List<Reserva> CurrentReservations { get; set; }
    public Menu()
    {
        Online = true;
        AvailableSuites = new List<Suite>();
        CurrentReservations = new List<Reserva>();
    }

    public void Logout()
    {
        Online = false;
    }

    public void ShowOptions()
    {
        //Console.Clear();
        Console.WriteLine("🏨 Hotel System - Type one of This Option 🏨");
        Console.WriteLine("1 - (SYSTEM) Create New Suite 🛏️");
        Console.WriteLine("2 - (SYSTEM) List All Suites 🛏️");
        Console.WriteLine("3 - (SYSTEM) Check-in : New Reservetion 🔵");
        Console.WriteLine("4 - (SYSTEM) Check-out : End Reservetion 🔵");
        Console.WriteLine("5 - (SYSTEM) List All Reservetion 🔵");
        Console.WriteLine("6-Out");
    }

    public void ListSuites()
    {
        Console.Clear();
        Console.WriteLine("---- AVAILABLES SUITES ----");
        for (int i = 0; i < AvailableSuites.Count; i++)
        {
            Console.WriteLine($"{i + 1} | NAME: {AvailableSuites[i].TipoSuite} | VALUE PER DAY: {AvailableSuites[i].ValorDiaria.ToString("C")} | MAX PEOPLE: {AvailableSuites[i].Capacidade}");
        }
        Console.WriteLine("");

    }
    public void ListReservations()
    {
        Console.Clear();
        Console.WriteLine("---- RESERVATIONS ACTIVES ----");
        for (int i = 0; i < CurrentReservations.Count; i++)
        {
            Console.WriteLine($"{i + 1} | SUITE NAME: {CurrentReservations[i].Suite.TipoSuite} | GUESTS: {CurrentReservations[i].Hospedes.Count} | DAYS: {CurrentReservations[i].DiasReservados}");
        }

    }
    public void CreateNewSuite()
    {
        Console.Clear();
        Console.WriteLine("🏨 OPT 1 - Fill all information for add a new Suite 🏨");

        Console.WriteLine("🏨 Name:");
        string name = Console.ReadLine();

        Console.WriteLine("🏨 Max People:");
        string maxPeople = Console.ReadLine();

        Console.WriteLine("🏨 Value Per Day:");
        string valuePerDay = Console.ReadLine();

        AvailableSuites.Add(new Suite()
        {
            Capacidade = Int32.Parse(maxPeople),
            TipoSuite = name,
            ValorDiaria = Decimal.Parse(valuePerDay)
        });

        Console.Clear();
        Console.WriteLine("✅ Add in your system!");

    }
    public void AddNewReservation(bool WithError = false)
    {
        Console.Clear();


        Console.WriteLine("\n🏨 OPT 2 - CHECKIN 🏨");
        ListSuites();
        if (WithError) Console.WriteLine("Type a valid option!");
        Console.WriteLine("🏨 Select the suite. Type a Number 🏨");


        var selectedOption = Int32.Parse(Console.ReadLine());

        // --- INVALID OPTION
        if (selectedOption > AvailableSuites.Count)
        {
            AddNewReservation(true);
        }

        // --- CURRENT OPTION
        Console.WriteLine("🏨 Numbers Of People: ");
        var NumberOfPeople = Int32.Parse(Console.ReadLine());

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> guests = new List<Pessoa>();
        for (int fillFakeName = 0; fillFakeName < NumberOfPeople; fillFakeName++)
        {
            guests.Add(new Pessoa
            {
                Nome = $"Person {fillFakeName + 1}"
            });

        }

        Console.WriteLine("🏨 Days: ");
        var DaysSelected = Int32.Parse(Console.ReadLine());


        // -- CREATE NEW RESERVATION
        Reserva reservation = new Reserva(diasReservados: DaysSelected);
        reservation.CadastrarSuite(AvailableSuites[selectedOption - 1]);
        reservation.CadastrarHospedes(guests);

        CurrentReservations.Add(reservation);

        Console.Clear();
        Console.WriteLine("✅ Add in your system!");

    }

    public void RemoveReserevation(bool WithError = false)
    {
        Console.Clear();

        if (WithError) Console.WriteLine("Type a valid option!");

        Console.WriteLine("\n🏨 OPT 2 - CHECKOUT 🏨");
        ListReservations();
        Console.WriteLine("🏨 Select the reservaton to checkout!.Type a Number 🏨");

        var selectedOption = Int32.Parse(Console.ReadLine());

        // --- INVALID OPTION
        if (selectedOption > CurrentReservations.Count)
        {
            RemoveReserevation(true);
        }

        // --- REMOVE RESERVATION
        var removeThis = CurrentReservations[selectedOption-1];

        Console.Clear();
        Console.WriteLine("CHECKOUT ON THIS RESERVATION");
        Console.WriteLine($"Value Per Day: {removeThis.Suite.ValorDiaria.ToString("C")}");
        Console.WriteLine($"Total: {removeThis.CalcularValorDiaria().ToString("C")}");

        CurrentReservations.Remove(removeThis);
    }

}
