using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DependencyInversionPrinciple.NotIdealCode;

class MailService
{
    public void SendMail(Gmail gmail)
    {
        gmail.Send("");
    }
}

class Gmail
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Gmail");
    }
}
class Hotmail
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Gmail");
    }
}
class Yandex
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Gmail");
    }
}


