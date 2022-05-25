using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Operacion, ejecutar, marca=0;
            Calculadora calculadora = new Calculadora();
            do{
                ejecutar=0;
                if(marca==0)
                {
                    Console.WriteLine("Escriba un numero: ");
                    calculadora.Iniciar(Convert.ToDouble(Console.ReadLine()));
                }
                
                do{
                    Console.WriteLine($"\nQue operacion desea aplicarle a {calculadora.resultado}?: \n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir\n5)Limpiar");
                    Operacion=Convert.ToInt32(Console.ReadLine());
                }while(Operacion!=1&&Operacion!=2&&Operacion!=3&&Operacion!=4&&Operacion!=5);

                marca=1;
                switch(Operacion){
                    case 1:
                        Console.WriteLine("Escriba otro numero: ");
                        calculadora.Sumar(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Escriba otro numero: ");
                        calculadora.Restar(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Escriba otro numero: ");
                        calculadora.Multiplicar(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Escriba otro numero: ");
                        calculadora.Dividir(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 5:
                        calculadora.Limpiar();
                        marca=0;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break; 
                }
                Console.WriteLine($"\nResultado = {calculadora.resultado}\n");
                if(ejecutar==0)
                {
                    do{
                        Console.WriteLine("\nDesea ejecutar de nuevo?: \n0)No \n1)Si\n");
                        ejecutar=Convert.ToInt32(Console.ReadLine());
                    }while(ejecutar!=0&&ejecutar!=1);
                }
            }while(ejecutar!=0);
        }
    }
}