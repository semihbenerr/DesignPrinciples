Console.WriteLine("");
class MailSender
{
    public void Send()
    {
        Gmail gmail = new();//aşağıdaki açıklama satırları kalkarsa hata verecek ve bu bir sıkı bağımlılık yani en MailSender Gmail classına bağımlı ve  bu en ufak değişiklikte bile bize sürekli hata verecektir.
        gmail.Send();
    }
}
class Gmail
{
    public Gmail(/*string f*/)
    {

    }
    public void Send(/*string to*/)
    {

    }
}
