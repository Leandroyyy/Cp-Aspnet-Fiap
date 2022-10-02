using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CpEnterprise.Exceptions;

namespace CpEnterprise.Model
{
    internal class Pj : Funcionario
    {

        public double ValorHora { get; set; }
        public double HorasContratadas { get; set; }
        public long Cpnj { get; set; }

        public Pj(int id, string nome, Genero genero, double valorHora, double horasContratadas, long cpnj) : base(id, nome, genero)
        {
            ValorHora = valorHora;
            HorasContratadas = horasContratadas;
            Cpnj = cpnj;
        }

        public override string ToString()
        {
            return base.ToString() + $" Valor por Hora: {ValorHora}, Horas contratadas: {HorasContratadas}, Cnpj: {Cpnj}";
        }

        public double CustoTotal()
        {
            return ValorHora * HorasContratadas;
        }

        public double HorasExtras(double horas)
        {
            var total = ValorHora * HorasContratadas;
            return horas * total;
        }

        public void AumentarSalario(double aumento)
        {
            if(aumento < 0)
            {
                throw new ValorInvalidoException("Valor inválido");
            }
            ValorHora = ValorHora + aumento;
        }
    }
}
