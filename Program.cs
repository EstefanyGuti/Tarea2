using System;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datos EMpleado
            Console.WriteLine("Digite el número de cédula del empleado:");
            string cedula = Console.ReadLine();

            Console.WriteLine("Digite el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Digite el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional):");
            int tipoempleado;
            try
            {
                tipoempleado = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de empleado no válido");
                return;
            }

            Console.WriteLine("Digite la cantidad de horas laboradas:");
            int horaslaboradas;
            try
            {
                horaslaboradas = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Cantidad de horas no válida");
                return;
            }

            Console.WriteLine("Digite el precio por hora del empleado:");
            double preciohora;
            try
            {
                preciohora = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Precio por hora no válido");
                return;
            }

            // Calcula el salario ordinario
            double salarioordinario = horaslaboradas * preciohora;

            // Define el porcentaje de aumento
            double porcentajeaumento = 0.0;
            string empleado = "";

            switch (tipoempleado)
            {
                case 1:
                    porcentajeaumento = 0.15;
                    empleado = "Operario";
                    break;
                case 2:
                    porcentajeaumento = 0.10;
                    empleado = "Técnico";
                    break;
                case 3:
                    porcentajeaumento = 0.05;
                    empleado = "Profesional";
                    break;
                default:
                    Console.WriteLine("Tipo de empleado no válido");
                    return;
            }

            // Calcular aumento
            double aumento = salarioordinario * porcentajeaumento;

            // Calcular salario bruto
            double salariobruto = salarioordinario + aumento;

            // Calcular deducciones por CCSS (9.17%)
            double deduccionesCCSS = salariobruto * 0.0917;

            // Calcular salario neto
            double salarioneto = salariobruto - deduccionesCCSS;

            // Mostrar la información
            Console.WriteLine("\nInformación del empleado:");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de empleado: {empleado}");
            Console.WriteLine($"Horas laboradas: {horaslaboradas}");
            Console.WriteLine($"Precio por hora: ₡{preciohora}");
            Console.WriteLine($"Salario ordinario: ₡{salarioordinario}");
            Console.WriteLine($"Aumento ({porcentajeaumento * 100}%): ₡{aumento}");
            Console.WriteLine($"Salario bruto: ₡{salariobruto}");
            Console.WriteLine($"Deducciones CCSS (9.17%): ₡{deduccionesCCSS}");
            Console.WriteLine($"Salario neto ₡: {salarioneto}");

            Console.Read();
        }
    }
}
