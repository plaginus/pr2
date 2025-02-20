public class Tringle
{
    private double a = 0;
    private double b = 0;
    private double c = 0;
    private double peremeter = 0;
    private double area = 0;
    private bool is_tringle;
    private string type;

    public Tringle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;

        is_tringle = Is_tringle();
        if(is_tringle)
        {
            type = TypeIdentifier();
            peremeter = PeremeterCalculate();
            area = AreaCalculate();
        }
    }


    private double PeremeterCalculate()
    {
        return a + b + c;
    }

    private double AreaCalculate()
    {
        return Math.Sqrt(peremeter * (peremeter - a) * (peremeter - b) * (peremeter - c));
    }

    private bool Is_tringle()
    {
        if ((a + b > c && a + c > b && c + b > a) && (a > 0 && b > 0 && c > 0)) return true;
        else return false;
    }

    private string TypeIdentifier()
    {
        if (a == b && b == c) return "equilateral";
        else if (a == b || b == c || a == c) return "rectangular";
        else return "versatile";
    }

    public void ShowAll()
    {
        Console.WriteLine($"\nSide A: {a:f2}\nSide B: {b:f2}\nSide C: {c:f2}");
        switch(is_tringle) 
        {
            case true:
                Console.WriteLine($"Perermeter: {peremeter:f2}\nArea: {area:f2}\nTringle type is {type}");
                break;
            case false:
                Console.WriteLine("Not is tringle");
                break;
        }
    }

    public double GetSideA()
    {
        return a;
    }

    public double GetSideB()
    {
        return b;
    }

    public double GetSideC()
    {
        return c;
    }

    public double GetPeremeter() 
    {
        return peremeter;
    }

    public double GetArea()
    {
        return area;
    }

    public bool GetIsTringle()
    {
        return is_tringle;
    }
}