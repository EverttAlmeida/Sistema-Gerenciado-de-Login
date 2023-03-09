namespace SistemaGerenciadorDeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConfirmarOuNegarConta, LembrarSenha; string Email, Senha, SenhaNovamente;

            Console.WriteLine("Vc já tem uma conta? (S/N)");
            ConfirmarOuNegarConta = Console.ReadLine().ToUpper();

            if (ConfirmarOuNegarConta == "S")
            {
                Console.WriteLine("Se lembra da senha?(S/N)");
                LembrarSenha = Console.ReadLine().ToUpper();

                if (LembrarSenha == "S")
                {
                    Console.Write("E-mail: ");
                    Email = Console.ReadLine();
                    if (Email.Substring(Email.Length- 10)=="@gmail.com")
                    {
                        Console.Write("Senha: ");
                        Senha = Console.ReadLine();
                        Console.WriteLine("O E-mail: " + Email + "/ Senha: " + Senha);
                    }
                    else
                    {
                        Console.WriteLine("E-mail invalido!");
                    }
                }
                else if (LembrarSenha == "N")
                {
                    Console.Write("Coloque seu E-mail para recriar outra conta: ");
                    Email = Console.ReadLine();
                    Console.WriteLine("Pronto.");
                }

            }
            else if (ConfirmarOuNegarConta == "N")
            {
                Console.Write("Digite o seu melhor E-mail: ");
                Email=Console.ReadLine();
                do
                {
                    Console.Write("Digite uma senha: ");
                    Senha = Console.ReadLine();
                    Console.Write("Digite novamente: ");
                    SenhaNovamente = Console.ReadLine();
                    if (Senha != SenhaNovamente)
                    {
                        Console.WriteLine("Elas não estão iguais.");
                    }
                    else if (Senha.Length < 5)
                    {
                        Console.WriteLine("Não pode senha com menos que 5 caracateres.");
                    }
                } while (Senha != SenhaNovamente || Senha.Length < 5);
                Console.WriteLine("Tudo certo! Conta e Login feito");
                Console.WriteLine("O E-mail: " + Email + "/ Senha: " + Senha);
            }


        }
    }
}
