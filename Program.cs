using System;


namespace ConversorSimples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao conversor!");
            Console.WriteLine("Qaul tipo de moeda você possui?\n1: Dolar\n2: Libras");
            var moedaDoCliente = (TipoDeValor)int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você quer converter?");
            double valorParaConverter = double.Parse(Console.ReadLine());
            var valorConvertidoFinal = Conversor.Converter(valorParaConverter, moedaDoCliente );
            Console.WriteLine("O valor convertido é de:" + valorConvertidoFinal.ToString("F2"));
        }
    }

    public class Conversor
    {
        public static double Converter(double valorParaConverter, TipoDeValor valor)
        {
            double valorDoClienteConvertido = 0;
            if(valor == TipoDeValor.Libras)
            {
                valorDoClienteConvertido = valorParaConverter / 1.37;
            }
            else if (valor == TipoDeValor.Dolar)
            {
                valorDoClienteConvertido = valorParaConverter*1.37;
            }
            return valorDoClienteConvertido;
        }
    }
    public enum TipoDeValor
    {
        Dolar = 1,
        Libras =2
    }
}