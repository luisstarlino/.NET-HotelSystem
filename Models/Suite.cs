namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string name, int maxPeople, decimal valuePerDay)
        {
            Name = name;
            MaxPeople = maxPeople;
            ValuePerDay = valuePerDay;
        }

        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public decimal ValuePerDay { get; set; }
    }
}