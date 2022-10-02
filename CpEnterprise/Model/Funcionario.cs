using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEnterprise.Model
{
    internal abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Genero Genero { get; set; }

        public Funcionario(int id, string nome, Genero genero)
        {
            Id = id;
            Nome = nome;
            Genero = genero;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Gênero: {Genero},";
        }
    }

    public enum Genero
    {
        Masculino, Feminino, Outros
    }
}
