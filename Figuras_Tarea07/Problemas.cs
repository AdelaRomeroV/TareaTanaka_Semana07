using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Tarea07
{
    internal class Problemas
    {
        public void Start()
        {
            problemas();
        }

        bool continueflag = true;

        public void problemas()
        {
            while (continueflag)
            {
                Console.WriteLine("Elige una figuta: ");

                Console.WriteLine("Rectangulo");
                Console.WriteLine("Circulos");
                Console.WriteLine("Triangulo");

                string Option = Console.ReadLine();

                switch(Option) 
                {
                    case "Rectangulo":

                        float rBase, rAltura;
                        

                        Console.WriteLine("Ingresa la base de su rectangulo");
                        rBase = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la altura de su rectangulo");
                        rAltura = float.Parse(Console.ReadLine());  

                        Rectangulo rectangulo = new Rectangulo(rBase, rAltura);
                        Console.WriteLine($"El area del rectangulo es {rectangulo.AreaRectangulo()}");
                        break;


                    case "Circulo":
                        float radio,pi = 3.14f;
                        
                        Console.WriteLine("ingresa el radio del circulo: ");

                        radio = float.Parse(Console.ReadLine());
                        radio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo (radio, pi);
                        Console.WriteLine($"El area del circulo es {circulo.AreaCirculo()}");
                        break;

                    case "Triangulo":

                        float tBase,tAltura;

                        Console.WriteLine("Inserte la base de su triangulo");
                        tBase = float.Parse(Console.ReadLine());

                        Console.WriteLine("Inserte la altura de su triangulo");
                        tAltura = float.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(tBase,tAltura);
                        Console.WriteLine($"El area del triangulo es {triangulo.AreaTriangulo()}");
                        break;
                }

                Console.WriteLine("Desea continuar, SI/NO");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }
            }

            Console.WriteLine();

        }
    }
}
