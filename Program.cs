using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OOP;
// can be used in c# 9 https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace

class NumericalValue
{
    public NumericalValue()
    {

    }
}


class Integer : NumericalValue
{
    private int value_;

    public int Value
    {
        get { return value_; }
        set { value_ = value; }
    }

}
class Decimal : NumericalValue
{
    public Decimal()
    {

    }
}

class Complex
{
    public Complex()
    {

    }
}



internal class Practice
{
    static void Main(string[] args)
    {


    }
}
