using _04_OpenClosedPrinciple.IdealCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OpenClosedPrinciple.NotIdealCode;

class ParaGonderici
{
    void Gonder(int tutar)
    {
        Garanti garanti = new();
        garanti.HesapNo = "123";
        garanti.ParaGonder(tutar);

        Halkbank halkbank = new();
        halkbank.GonderilecekHesapNo("123");
        halkbank.Gonder(tutar);
    }
}
class Garanti
{
    public string HesapNo { get; set; }
    public void ParaGonder(int tutar)
    {
    }
}
class Halkbank
{
    public void GonderilecekHesapNo(string hesapNo)
    {
    }
    public void Gonder(int tutar)
    {
    }
}

