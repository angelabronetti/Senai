using System;
using Senai.POO.CadastroDeAlunos.SomenteModel.Models;


namespace Senai.POO.CadastroDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();

            Console.Clear(); // Limpa a tela
            
            aluno1.CadastrarAlunos();
            aluno1.ListarAluno();
            aluno1.IrAoBanheiro();

            /// // Exibindo as informações
            System.Console.WriteLine("Nome: " + aluno1.Nome);
            System.Console.WriteLine("Curso: " + aluno1.Curso);
            System.Console.WriteLine("RG: " + aluno1.Rg);
            System.Console.WriteLine("Idade: " + aluno1.Idade);
        }

    }
}
