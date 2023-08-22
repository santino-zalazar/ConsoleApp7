namespace parcialsantino
{
    class Program
    {
        static void Main(string[] args)
        {
            int largo, altura, ancho, cantidaddeprisma = 0;
            double calcularbase, calcularaltura, calcularancho;

            do
            {
                Console.Write("Ingrese valor del largo: ");
                largo = int.Parse(Console.ReadLine());

                if (largo > 0)
                {
                    Console.Write("Ingrese el valor de la altura: ");
                    altura = int.Parse(Console.ReadLine());

                    if (altura > 0)
                    {
                        Console.Write("Ingrese el ancho: ");
                        ancho = int.Parse(Console.ReadLine());

                        if (ancho > 0)
                        {
                            calcularbase = ancho * largo;
                            calcularaltura = altura * largo;
                            calcularancho = altura * ancho;

                            Console.WriteLine($"Área de la base: {calcularbase}");
                            Console.WriteLine($"Área de la altura: {calcularaltura}");
                            Console.WriteLine($"Área del ancho: {calcularancho}");

                            cantidaddeprisma++;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número mayor a 0 para el ancho.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un número mayor a 0 para la altura.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un número mayor a 0 para el largo.");
                }

                Console.Write("¿Desea ingresar otro prisma? (0 para salir, otro número para continuar): ");
                cantidaddeprisma = int.Parse(Console.ReadLine());

            } while (cantidaddeprisma != 0);

            Console.WriteLine($"Cantidad de prismas ingresados: {cantidaddeprisma}");
        }
    }
}
