namespace Banco 
{
    public class ContaCorrente : Conta
    {

        private string nivelConta = "basic";

        public void Tranferir(ContaCorrente conta, double valor)
        {
            conta.SetSaldo(conta.GetSaldo() + valor);
            this.SetSaldo(this.GetSaldo() - valor);

        }

        public string GetNivelConta()
        {
            return nivelConta;
        }

        public void SetNivelConta(string valor)
        {
            nivelConta = valor;
        }
    }
}