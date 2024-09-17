using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OpenClosedPrinciple.IdealCode;

class ParaGonderici
{
    void Gonder(IBanka banka, int tutar, string hesapNo)
    {
        banka.ParaTransferi(tutar, hesapNo);
    }
}
interface IBanka
{
    bool ParaTransferi(int tutar, string hesapNo);
}
class Garanti : IBanka
{
    public string HesapNo { get; set; }
    void ParaGonder(int tutar)
    {
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            HesapNo = hesapNo;
            ParaGonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
class Halkbank : IBanka
{
    void GonderilecekHesapNo(string hesapNo)
    {
    }
    void Gonder(int tutar)
    {
    }
    public bool ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            GonderilecekHesapNo(hesapNo);
            Gonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
