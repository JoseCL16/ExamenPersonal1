using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                string option;
                Console.WriteLine("Bienvenido a la tienda, elegir producto: ");
                Console.WriteLine("1. Telas");
                Console.WriteLine("2. Arcillas");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        float n;
                        float s;
                        float m;
                        float c;
                        Console.WriteLine("Casaca(1) o Poncho(2)");
                        n = float.Parse(Console.ReadLine());
                        Console.WriteLine("Tamaño: S(1), M(2) o L(3)");
                        s = float.Parse(Console.ReadLine());
                        Console.WriteLine("Material: Lana(1) o Algodon(2)");
                        m = float.Parse(Console.ReadLine());
                        Console.WriteLine("Color: Rojo(1) o Azul(2)");
                        c = float.Parse(Console.ReadLine());
                        Product Product1 = new Tela(n, s, m, c);
                        Console.WriteLine(Product1.Price());
                        break;
                    case "2":
                        float n1;
                        float w;
                        float s1;
                        float c1;
                        Console.WriteLine("Vasilla(1) o Arte(2)");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Peso: Ligero(1) o pesado(2)");
                        w = float.Parse(Console.ReadLine());
                        Console.WriteLine("Tamaño: S(1), M(2) o L(3)");
                        s1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Color: Rojo(1) o Azul(2)");
                        c1 = float.Parse(Console.ReadLine());
                        Product product2 = new Arcillas(n1, w, s1, c1);
                        Console.WriteLine(product2.Price());
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine("Desea seguir comprando?");
                string continueOption = Console.ReadLine();
                if (continueOption == "no")
                {
                    continueFlag = false;
                }
            }
        }
    }
}