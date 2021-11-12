/*
 Nome: Laidone Mendes de Carvalho
 Trilha .NET Laboratório 4
 */

using System;

namespace Laboratorio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente(100, "Laidone");
            minhaConta.Depositar(20);
            minhaConta.Depositar(60);
            minhaConta.Sacar(90);
            minhaConta.Sacar(10);
            minhaConta.Depositar(100);
            minhaConta.Sacar(40);
            Console.WriteLine(minhaConta.name + " fez uma conta na data " + minhaConta.data);
            Console.WriteLine("O saldo médio do cliente " + minhaConta.name + " foi de " + minhaConta.saldomedio);
        }
    }
}