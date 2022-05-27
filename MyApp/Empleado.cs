using System;
namespace Ejercicio2
{
    public enum cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4
    }
    public class Empleado
    {
        public string Nombre, Apellido;
        public DateTime FechaDeNacimiento, FechaDeIngresoAEmpresa;
        public char EstadoCivil, Genero;
        public double SueldoBasico;
        public cargos Cargo;

        public int antiguedad()
        {
            int add=0;
            if(DateTime.Now.Year != FechaDeIngresoAEmpresa.Year)
            {
                if((DateTime.Now.Month - FechaDeIngresoAEmpresa.Month)>0)
                {
                    add=1;
                } else if(DateTime.Now.Month - FechaDeIngresoAEmpresa.Month == 0 && DateTime.Now.Day - FechaDeIngresoAEmpresa.Day>=0)
                    {
                        add=1;
                    }
            }
            
            return ((DateTime.Now.Year - FechaDeIngresoAEmpresa.Year)+add);
        }

        public int edad()
        {
            return Math.Abs(Convert.ToInt32(DateTime.Now.Year)-Convert.ToInt32(FechaDeNacimiento.Year));
        }

        public int faltanteJubilacion()
        {
            if(Genero=='M' || Genero=='m')
            {
                return 65-edad();
            } else if(Genero=='F' || Genero=='f')
                    {
                        return 60-edad();
                    }
            return -99;
        }

        public double calcularSalario()
        {
            double Adicional=0, Salario=0;
            if(antiguedad()<20)
            {
                Adicional=SueldoBasico*(antiguedad()/100);
            } else {
                Adicional=SueldoBasico*0.25;
            }
            if(Cargo==cargos.Ingeniero || Cargo==cargos.Especialista)
            {
                Adicional+=Adicional*0.50;
            }
            if(EstadoCivil=='C' || EstadoCivil=='c')
            {
                Adicional+=15000;
            }
            Salario=SueldoBasico+Adicional;
            return Salario;
        }
    }

    
}

   

