namespace DesafioProjetoHospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string nome)
    {
        Name = nome;
    }

    public Person(string nome, string sobrenome)
    {
        Name = nome;
        LastName = sobrenome;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{Name} {LastName}".ToUpper();
}