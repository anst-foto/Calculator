using _Logger_.Library;

namespace Calculator;

public class Calc
{
    public ILogger Logger { get; set; }

    public int Add(int x, int y)
    {
        Logger.LogInfo($"Сложение {x} и {y}");
        var result = x + y;
        Logger.LogSuccess($"{x} + {y} = {result}");
        return result;
    }
    
    public int Div(int x, int y)
    {
        Logger.LogInfo($"Деление {x} и {y}");
        if (y == 0)
        {
            Logger.LogError("Делить на ноль нельзя");
            throw new DivideByZeroException();
        }
        
        var result = x / y;
        Logger.LogSuccess($"{x} / {y} = {result}");
        return result;
    }
}