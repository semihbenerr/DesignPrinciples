using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LiskovSubstitutionPrinciple.NotIdealCode;

abstract class Cloud
{
    public abstract void Translate();
    public abstract void MachineLearning();
}
class AWS : Cloud
{
    public override void MachineLearning()
    {
        Console.WriteLine("AWS Machine Learning");
    }

    public override void Translate()
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

    public override void Translate()
    {
        throw new NotImplementedException();
    }
}

class Google : Cloud
{
    public override void MachineLearning()
    {
        Console.WriteLine("Google Machine Learning");
    }

    public override void Translate()
    {
        Console.WriteLine("Google Translate");
    }
}