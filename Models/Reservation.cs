namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }
        public readonly int DaysToApplyDiscout = 10;
        public readonly decimal Discout = 0.1M;

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void AddGuests(List<Person> guests)
        {
            bool overLimitRoom = guests.Count > Suite.MaxPeople;

            if (!overLimitRoom) Guests = guests;
            else throw new Exception("The number of guests is greater than the suite's capacity ❌");
            
        }

        public void AddSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetCurrentGuests()
        {
            return Guests.Count;
        }

        public decimal GetTotalValue()
        {
            
            // --- TOTAL PRICE FOR THIS SUITE
            decimal totalValue = ReservedDays * Suite.ValuePerDay;

            // --- DISCOUT ROLE
            if (ReservedDays >= DaysToApplyDiscout)
            {
                totalValue -= totalValue* Discout;
            }

            return totalValue;
        }
    }
}