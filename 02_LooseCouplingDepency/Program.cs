Console.WriteLine("");
interface IMailServer
{
    void Send(string to, string body);
}

class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("to", "body");
    }

}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        throw new NotImplementedException();
    }
}
class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        throw new NotImplementedException();
    }
}
class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        throw new NotImplementedException();
    }
}