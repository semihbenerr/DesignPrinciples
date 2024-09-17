using _06_InterfaceSegregationPrinciple.IdealCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceSegregationPrinciple.NotIdealCode;

interface IPrintter
{
    void Fax();
    void Print();
    void PrintDuplex();
    void Scan();
}

class SamsungPrinter : IPrintter
{
    public void Fax()
    {
        Console.WriteLine("Fax işlemleri");
    }

    public void Print()
    {
        Console.WriteLine("Print işlemleri");
    }

    public void PrintDuplex()
    {
        Console.WriteLine("PrintDuplex işlemleri");
    }

    public void Scan()
    {
        Console.WriteLine("Scan işlemleri");
    }
}

class HPPrinter: IPrintter
{
    public void Fax()
    {
        Console.WriteLine("Fax işlemleri");
    }

    public void Print()
    {
        Console.WriteLine("Print işlemleri");
    }

    public void PrintDuplex()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        Console.WriteLine("Scan işlemleri");

    }
}

class LexmarkPrinter : IPrintter
{
    public void Fax()
    {
        Console.WriteLine("Fax işlemleri");
    }

    public void Print()
    {
        Console.WriteLine("Print işlemleri");

    }

    public void PrintDuplex()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }
}