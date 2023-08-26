using _Logger_.Library;
using Calculator;

var calc = new Calc()
{
    Logger = new FileLog("test.log", "test.log", "test.log", "test.log")
};

try
{
    calc.Add(5, 0);
    calc.Div(5, 0);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
