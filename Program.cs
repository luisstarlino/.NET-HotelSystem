using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// --- MAIN MENU
Menu SystemHotel = new Menu();



while (SystemHotel.Online)
{
    SystemHotel.ShowOptions();
    var selectedOption = Console.ReadLine();

    switch (selectedOption)
    {
        case "1":
            SystemHotel.CreateNewSuite();
            break;
        case "2":
            SystemHotel.ListSuites();
            break;
        case "3":
            SystemHotel.AddNewReservation();
            break;
        case "4":
            SystemHotel.RemoveReserevation();
            break;
        case "5":
            SystemHotel.ListReservations();

            break;
        case "6":
            SystemHotel.Logout();
            break;
    }
}
