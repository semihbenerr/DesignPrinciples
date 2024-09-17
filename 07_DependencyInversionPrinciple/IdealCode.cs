using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DependencyInversionPrinciple.IdealCode;


class MailService
{
    public void SendMail(IMailServer _mailServer,string mail)
    {
        _mailServer.Send("Mail");
    }
}

interface IMailServer
{
    void Send(string mail);
}

class Gmail : IMailServer
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Gmail");
    }
}
class Hotmail : IMailServer
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Hotmail");
    }
}
class Yandex : IMailServer
{
    public void Send(string mail)
    {
        Console.WriteLine("Send Yandex");
    }
}