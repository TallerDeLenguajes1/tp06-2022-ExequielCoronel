namespace Ejercicio1
{
    public class Calculadora
    {
        //campos
        public double resultado;
        //metodos
        public void Iniciar(double valorInicial)
        {
            resultado=valorInicial;
        }
        public void Sumar(double valor)
        {
            resultado+=valor;
        }
        public void Restar(double valor)
        {
            resultado-=valor;
        }
        public void Multiplicar(double valor)
        {
            resultado*=valor;
        }
        public void Dividir(double valor)
        {
            resultado/=valor;
        }
        public void Limpiar()
        {
            resultado=0;
        }
    }
}

   

