
namespace Banco 
{

    public class Program {


        public static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.SetBanco("Itau");
            cc.SetNumeroConta(568941);
            cc.SetTitular("Jose");
            
            Console.WriteLine("Conta: " + cc.GetNumeroConta());
            Console.WriteLine("Titular: " + cc.GetTitular());
            Console.WriteLine("Saldo: " + cc.GetSaldo());
            Console.WriteLine("  ");
            Console.WriteLine("###################################");
            ContaCorrente cc2 = new ContaCorrente();
            cc2.SetBanco("Itau");
            cc2.SetNumeroConta(432875);
            cc2.SetTitular("João");
            
            Console.WriteLine("Conta: " + cc2.GetNumeroConta());
            Console.WriteLine("Titular: " + cc2.GetTitular());
            Console.WriteLine("Saldo: " + cc2.GetSaldo());
            Console.WriteLine("  ");
            Console.WriteLine("###################################");
            cc2.Deposito(150.00);

            Console.WriteLine("Novo Saldo: " + cc2.GetSaldo());

            Poupanca cp = new Poupanca();
            
            cp.SetBanco("Santander");
            cp.SetNumeroConta(43289);
            cp.SetTitular("Maria");
            

            cc.Tranferir(cc2, 45.00);

            Console.WriteLine("Conta: " + cp.GetNumeroConta());
            Console.WriteLine("Novo Saldo: " + cp.GetSaldo());
            Console.WriteLine("  ");
            Console.WriteLine("###################################");
            Console.WriteLine("Conta: " + cc.GetNumeroConta());
            Console.WriteLine("Novo Saldo: " + cc.GetSaldo());
            Console.WriteLine("  ");
            Console.WriteLine("###################################");
            cp.Deposito(1200.00);
            Console.WriteLine("Poupança: " + cp.GetNumeroConta());
            Console.WriteLine("Titular: " + cp.GetTitular());
            Console.WriteLine("Saldo: " + cp.GetSaldo());
            cp.ReajustarSaldo();
            Console.WriteLine("  ");
            Console.WriteLine("###################################");
            Console.WriteLine("Poupança: " + cp.GetNumeroConta());
            Console.WriteLine("Novo Saldo: " + cp.GetSaldo());


        }
    }
}

