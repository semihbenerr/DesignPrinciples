using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LiskovSubstitutionPrinciple.IdealCode;

abstract class Cloud
{
    public abstract void MachineLearning();
}

interface ITranslatable
{
    public void Translate();
}
class AWS : Cloud,ITranslatable
{
    public override void MachineLearning()
    {
        Console.WriteLine("AWS Machine Learning");
    }

    public void Translate()
    {
        Console.WriteLine("AWS Translate");
    }
}

class Azure : Cloud
{
    public override void MachineLearning()
    {
        Console.WriteLine("Azure Machine Learning");
    }
}

class Google : Cloud,ITranslatable
{
    public override void MachineLearning()
    {
        Console.WriteLine("Google Machine Learning");
    }

    public void Translate()
    {
        Console.WriteLine("Google Translate");
    }
}