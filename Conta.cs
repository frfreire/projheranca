
namespace Banco 
{
    public class Conta {

        private int numeroConta;
        private string banco;
        private string titular;
        private double saldo = 0.00;

        public Conta(int numeroConta, string banco, string titular)
        {
            this.banco = banco;
            this.numeroConta = numeroConta;
            this.titular = titular;
        }

        public Conta()
        {

        }

        public void Deposito(double valor)
        {
            SetSaldo(GetSaldo() + valor);
        }

        public int GetNumeroConta()
        {
            return numeroConta;
        }

        public string GetBanco()
        {
            return banco;
        }

        public string GetTitular()
        {
            return titular;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetNumeroConta(int valor)
        {
            numeroConta = valor;
        }

        public void SetBanco(string valor)
        {
            banco = valor;
        }

        public void SetTitular(string valor)
        {
            titular = valor;
        }

        public void SetSaldo(double valor)
        {
            saldo = valor;
        }


    }
}