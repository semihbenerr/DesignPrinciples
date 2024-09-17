using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceSegregationPrinciple.IdealCode;

interface IScan
{
    void Scan();
}
interface IFax
{
    void Fax();
}
interface IPrint
{
    void Print();
}
interface IPrintDuplex
{
    void PrintDuplex();
}

class SamsungPrinter : IScan, IFax, IPrint, IPrintDuplex
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

class HPPrinter : IScan, IFax
{
    public void Fax()
    {
        Console.WriteLine("Fax işlemleri");
    }

    public void Scan()
    {
        Console.WriteLine("Scan işlemleri");
    }
}

class LexmarkPrinter : IScan, IPrintDuplex
{
    public void PrintDuplex()
    {
        Console.WriteLine("PrintDuplex işlemleri");
    }

    public void Scan()
    {
        Console.WriteLine("Scan işlemleri");
    }
}