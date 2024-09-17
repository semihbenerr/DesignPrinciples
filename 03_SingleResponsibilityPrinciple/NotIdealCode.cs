using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SingleResponsibilityPrinciple.NotIdealCode;

class Database
{
    public void Connect()
    {
        Console.WriteLine("Bağlandı.");
    }
    public void Disconnect()
    {
        Console.WriteLine("Bağlantı kesildi.");
    }
    public string State { get; set; }
    public List<Person> Get()
    {
        return new()
        {
            new(){Ad="Semih",Soyad="Bener"},
            new(){Ad="Semih",Soyad="Bener"},
            new(){Ad="Semih",Soyad="Bener"}
        };
    }
}
