//using _07_DependencyInversionPrinciple.NotIdealCode;
//MailService mailService = new();
//mailService.SendMail(new Gmail());

using _07_DependencyInversionPrinciple.IdealCode;
MailService mailService = new();
mailService.SendMail(new Gmail(), "Gmail");
mailService.SendMail(new Hotmail(), "Hotmail");
