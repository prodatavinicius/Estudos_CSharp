namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        
    }
}