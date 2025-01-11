namespace DesafioProjetoHospedagem.Models;

public class Menu
{
    public bool Online { get; set; }
    public Menu() { 
        Online = true;
    }

    public void Logout () 
    {
        Online = false;
    }

    public void ShowOptions () 
    {
        Console.Clear();
        Console.WriteLine("🏨 Hotel System - Type one of This Option 🏨");
        Console.WriteLine("1 - Create New Suite 🛏️");
        Console.WriteLine("2 - (CHECKIN) New Reservetion 🔵");
        Console.WriteLine("3 - (CHECKOUT) ENd Reservetion 🔴");
        Console.WriteLine("4-Out");
    }

}
