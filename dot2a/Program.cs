using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class KVADRAT
{

    protected Point[] koord = new Point[4];
    public KVADRAT()
    {
        Console.WriteLine("Квадрат создан конструктором по умолчанию!");
    }
    public KVADRAT(int nachalo_x, int nachalo_y, int razmer)
    {
        this.koord[0] = new Point(nachalo_x, nachalo_y);
        this.koord[1] = new Point(nachalo_x + razmer, nachalo_y);
        this.koord[2] = new Point(nachalo_x, nachalo_y + razmer);
        this.koord[3] = new Point(nachalo_x + razmer, nachalo_y + razmer);
        Console.WriteLine("Квадрат создан полным конструктором!");
    }
    public int getShirina()
    {
        return (this.koord[1].X - this.koord[0].X);
    }
    public int getVisota()
    {
        return (this.koord[3].Y - this.koord[0].Y);
    }
    public double Perimeter() // Периметр
    {
        return (getShirina() * 4);
    }
    public double Area() // Площадь
    {
        return (Math.Pow(getShirina(), 2));
    }
    public double Diagonal() // Диагональ
    {
        return (Math.Pow(Math.Pow((getShirina()), 2) * 2, 0.5));
    }
    public bool isPryamoug(KVADRAT kvad)
    {
        if (kvad.getShirina() != kvad.getVisota())
        {
            return true;
        }
        else
            return false;
    }
}
