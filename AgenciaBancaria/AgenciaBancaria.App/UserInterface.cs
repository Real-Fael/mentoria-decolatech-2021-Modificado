using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    public class UserInterface
    {
        public UserInterface(){

        }

        public void Menu(){
            try
            {   
                
                string opc;
                MeuBanco meuBanco = new MeuBanco();
                Console.WriteLine("***************Bem Vindo***************");
                do{
                    Console.WriteLine("1 - Cadastrar uma Nova Conta"); 
                    Console.WriteLine("2 - Listar Contas Cadastradas"); 
                    Console.WriteLine("3 - Consultar Extrato"); 
                    Console.WriteLine("4 - Consultar Saldo"); 
                    Console.WriteLine("5 - Sacar");;
                    Console.WriteLine("6 - Depositar") ;
                    Console.WriteLine("7 - Transferir"); 
                    Console.WriteLine("8 - Sair");
                    
                    opc=Console.ReadLine();
                    
                    switch (opc)
                    {
                        case "1":
                            CadastrarNovaConta(meuBanco);
                            break;
                         case "2":
                            Console.WriteLine(meuBanco.ListarContas());
                            
                            break;
                         case "3":
                            ConsultarExtrato(meuBanco);
                            
                            break;
                         case "4":
                            ConsultarSaldo(meuBanco);
                            
                            break;
                         case "5":
                            Sacar(meuBanco);
                            //TODO
                            break;
                         case "6":
                            Depositar(meuBanco);
                            //TODO
                            break;
                         case "7":
                            Transferir(meuBanco);
                            //TODO
                            break;    
                        case "8":
                            Console.WriteLine("Obrigado por utilizar nosso banco");
                            break;
                        
                        default:
                            Console.WriteLine("Opção Inválida tente novamente");
                            break;

                    }


                }while(opc!="8");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
         public static void CadastrarNovaConta( MeuBanco banco){
            
            ContaCorrente conta;
        
            try{
                Console.WriteLine("***********Cadastro de Conta**********");
                Console.WriteLine("Digite sua Rua");
                string rua= Console.ReadLine();

                Console.WriteLine("Digite seu CEP");
                string cep= Console.ReadLine();
                Console.WriteLine("Digite sua Cidade");
                string cidade= Console.ReadLine();
                Console.WriteLine("Digite seu Estado");
                string estado= Console.ReadLine();
                Endereco endereco = new Endereco(rua, cep, cidade, estado);
                
                Console.WriteLine("Digite seu Nome");
                string nome= Console.ReadLine();
                Console.WriteLine("Digite seu CPF");
                string cpf= Console.ReadLine();
                Console.WriteLine("Digite seu RG");
                string rg= Console.ReadLine();
                        
                Cliente cliente = new Cliente(nome, cpf, rg, endereco);
                conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Digite Sua Senha Com letras e numeros");
                string senha= Console.ReadLine();
                conta.Abrir(senha);  
                
            }catch{
                Console.WriteLine("voce digitou algo errado tente novamente");
                return;
            }
                   
            banco.AdicionarConta(conta);

        }

        public static void ConsultarExtrato(MeuBanco banco){
            Console.WriteLine("Digite sua Conta");
            int num=  int.Parse(Console.ReadLine());
            
            try{    
                Console.WriteLine(banco.RetornaConta(num).VerExtrato());
            }catch(Exception err){
                Console.WriteLine("OPS: Ocorreu algum erro",err.Message);
                return;
            }

        }
        public static void ConsultarSaldo( MeuBanco banco){
            Console.WriteLine("Digite sua Conta");
            int num=  int.Parse(Console.ReadLine());
             Console.WriteLine();
            try{
                Console.WriteLine("Saldo: {0:0.00}R$",banco.RetornaConta(num).Saldo);   
            }catch(Exception err){
                Console.WriteLine("OPS: Ocorreu algum erro",err.Message);
                return;
            }
        }
        public static void Sacar(MeuBanco banco){
            Console.WriteLine("Digite sua Conta");
            int num=  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor");
            decimal valor= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua Senha");
            string senha= Console.ReadLine();
            try{
                banco.RetornaConta(num).Sacar(valor,senha);
            }catch(Exception err){
                Console.WriteLine("OPS: Ocorreu algum erro",err.Message);
                return;
            }
            Console.WriteLine("Sacado com sucesso");


        }
        public static void Depositar(MeuBanco banco){
            Console.WriteLine("Digite sua Conta");
            int num=  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor");
            decimal valor= decimal.Parse(Console.ReadLine());
            try{
            banco.RetornaConta(num).Depositar(valor);
            }catch(Exception err){
                Console.WriteLine("OPS: Ocorreu algum erro",err.Message);
                return;
            }
            Console.WriteLine("Depositado com sucesso");


        }

        public static void Transferir(MeuBanco banco){
            Console.WriteLine("Digite sua Conta");
            int num=  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor");
            decimal valor= decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua Senha");
            string senha= Console.ReadLine();
            Console.WriteLine("Digite o destinatario");
            int para=  int.Parse(Console.ReadLine());
            try{
            banco.Transferir(num,para,valor,senha);
            }catch(Exception err){
                Console.WriteLine("OPS: Ocorreu algum erro",err.Message);
                return;
            }
            Console.WriteLine("Transferido com sucesso");


        }

    }
}