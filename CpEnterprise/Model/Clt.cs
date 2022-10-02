using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CpEnterprise.Exceptions;

namespace CpEnterprise.Model
{
    internal class Clt : Funcionario
    {
        public double Salario { get; set; }
        public bool CargoConfianca { get; set; }

        public Clt(int id, string nome, Genero genero, double salario, bool cargoConfianca) : base(id, nome, genero)
        {
            Salario = salario;
            CargoConfianca = cargoConfianca;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salário: {Salario}, é cargo de confianca?: {CargoConfianca}";
        }

        public double CustoTotal()
        {
            var ferias = Salario * (11.11 / 100);
            var decimoTerceiro = Salario * (8.33 / 100);
            var fgts = Salario * (4 / 100);
            var multa = Salario * (7.93 / 100);

            return Salario + ferias + decimoTerceiro + fgts + multa;
        }

        public void AumentarSalario(double aumento)
        {
            if(aumento < 0)
            {
                throw new ValorInvalidoException("Valor inválido");
            }
            Salario = Salario + (Salario * (aumento / 100));
        }

    }
}
