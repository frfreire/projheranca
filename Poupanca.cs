
namespace Banco 
{
    public class Poupanca : Conta {

        private double taxaJuros = 0.05;

        public double GetTaxaJuros()
        {
            return taxaJuros;
        }

        public void SetTaxaJuros(double valor)
        {
            taxaJuros = valor;
        }

        public void ReajustarSaldo()
        {
            this.SetSaldo(this.GetSaldo() * this.GetTaxaJuros() + this.GetSaldo());
        }
    }
}