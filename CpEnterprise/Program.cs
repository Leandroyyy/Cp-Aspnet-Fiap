using System;
using CpEnterprise.Exceptions;
using CpEnterprise.Model;

var leandro = new Clt(1, "Leandro Cavallari", Genero.Masculino, 5000, true);
var julia = new Clt(2, "Julia Pereira", Genero.Feminino, 2000, false);

var todosClt = new List<Clt>();

todosClt.Add(leandro);
todosClt.Add(julia);

var joao = new Pj(1, "Joao Victor", Genero.Masculino, 20, 160, 83791802000194);
var maria = new Pj(2, "Maria José", Genero.Outros, 15, 160, 93993770000163);

var todosPj = new List<Pj>();
todosPj.Add(joao);
todosPj.Add(maria);

int opcao;
do
{
    Console.WriteLine("Escolha uma opção:\n" +
        "1-Exibir todos os funcionários CLT\n" +
        "2-Exibir todos os funcionários PJ\n" +
        "3-Exibir a soma do custo total mensal de todos os funcionários\n" +
        "4-Aumentar Salário CLT (%)\n"+
        "5-Aumentar Salário PJ (R$)\n" +
        "6-Pesquisar CLT\n" +
        "7-Pesquisar PJ\n" +
        "8-Pesquisar custo total do Funcionario CLT\n" +
        "9-Pesquisar custo total do Funcionario PJ\n" +
        "0-sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Todos funcionários CLT");
            foreach(var clt in todosClt)
            {
                Console.WriteLine(clt.ToString());
            }
            break;
        case 2:
            Console.WriteLine("Todos funcionários PJ");
            foreach(var pj in todosPj)
            {
                Console.WriteLine(pj.ToString());
            }
            break;
        case 3:
            double custoClt = 0;
            double custoPj = 0;
            foreach(var clt in todosClt)
            {
                var custo = clt.CustoTotal();
                custoClt = custo + custoClt;
            }
            foreach(var pj in todosPj)
            {
                var custo = pj.CustoTotal();
                custoPj = custo + custoPj;
            }
            var custoTotal = custoClt + custoPj;
            Console.WriteLine($"Custo de todos os funcionarios: {custoTotal}");
            break;
        case 4:
            Console.WriteLine("Digite o ID do funcionario:");
            var idClt = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Digite a porcentagem de aumento de salario, apenas numeros");
                var porcClt = Convert.ToInt32(Console.ReadLine());
                foreach (var clt in todosClt)
                {
                    if (clt.Id == idClt)
                    {
                        clt.AumentarSalario(porcClt);
                    }
                }
            }
            catch(ValorInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case 5:
            Console.WriteLine("Digite o ID do funcionario:");
            var idPj = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Digite o valor de aumento de valor por hora, apenas numeros");
                var valorPj = Convert.ToInt32(Console.ReadLine());
                foreach (var pj in todosPj)
                {
                    if (pj.Id == idPj)
                    {
                        pj.AumentarSalario(valorPj);
                    }
                }
            }
            catch(ValorInvalidoException e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case 6:
            Console.WriteLine("Digite o ID do funcionario:");
            var idFunClt = Convert.ToInt32(Console.ReadLine());
            foreach(var clt in todosClt)
            {
                if(clt.Id == idFunClt)
                {
                    Console.WriteLine(clt.ToString());
                }
            }
            break;
        case 7:
            Console.WriteLine("Digite o ID do funcionario:");
            var idFunPj = Convert.ToInt32(Console.ReadLine());
            foreach (var pj in todosPj)
            {
                if (pj.Id == idFunPj)
                {
                    Console.WriteLine(pj.ToString());
                }
            }
            break;
        case 8:
            Console.WriteLine("Digite o ID do funcionario:");
            var idCustoClt = Convert.ToInt32(Console.ReadLine());
            foreach (var clt in todosClt)
            {
                if (clt.Id == idCustoClt)
                {
                    Console.WriteLine($"O custo total do {clt.Nome} é {clt.CustoTotal()}");
                }
            }
            break;
        case 9:
            Console.WriteLine("Digite o ID do funcionario:");
            var idCustoPj = Convert.ToInt32(Console.ReadLine());
            foreach (var pj in todosPj)
            {
                if (pj.Id == idCustoPj)
                {
                    Console.WriteLine($"O custo total do {pj.Nome} é {pj.CustoTotal()}");
                }
            }
            break;
        case 0:
            Console.WriteLine("Adeus");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 0);