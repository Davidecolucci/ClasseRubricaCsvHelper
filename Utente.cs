using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace ProgettoClasseRubrica;

public class Utente
{
    [Index(0)]
    public string Nome { get; set; }

    [Index(1)]
    public string Cognome { get; set; }

    [Index(2)]
    public string Email { get; set; }

    [Index(3)]
    public string NumeroTelefono { get; set; }

    public Utente() { } //costruttore vuoto, utile x creare gli oggetti prima di riempirli con il contenuto preso alla lettura del file

    public Utente(string nome, string cognome, string email, string numeroTelefono) //costruttore
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        NumeroTelefono = numeroTelefono;
    }
}
