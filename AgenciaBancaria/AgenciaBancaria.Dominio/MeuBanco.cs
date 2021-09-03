using System;
using System.Collections.Generic;
namespace AgenciaBancaria.Dominio
{
    public class MeuBanco
    {
       public MeuBanco(){
           Contas= new List<ContaBancaria>();
       }

        public void AdicionarConta(ContaBancaria conta){
            Contas.Add(conta);
        }
        
        public string ListarContas(){
            Console.WriteLine("flag1");
            string aux="****Lista de Contas Cadastradas****"+Environment.NewLine;
            if (Contas.Count==0){ aux+="OPS: Não ha Contas Cadastradas"+ Environment.NewLine;}
            foreach (ContaBancaria c in Contas)
            {
                aux+= "Conta " + c.Situacao + ": " + c.NumeroConta + "-" + 
                    c.DigitoVerificador + Environment.NewLine;
    
            }
            aux +="*********************************"+Environment.NewLine;

            return aux;
        }
        //transfere de uma conta para outra
        public void Transferir(int de, int para, decimal valor, string senha){
            int indiceDe= IndiceConta(de);
            int indicePara=IndiceConta(para);

            if (indiceDe==-1 || indicePara==-1 || indiceDe==indicePara)
                throw new Exception("Ops: Conta Incorreta");
            

            //se tiver problema um throw sera lançado dentro do metodo
            Contas[indiceDe].Sacar(valor,senha);
            Contas[indicePara].Depositar(valor);

        }
        //retorna indice da lista de um numero de conta específico
        public int IndiceConta(int Numero){
            for(int i=0; i<Contas.Count;i++){
                if(Contas[i].NumeroConta==Numero)
                    return i;
            }
            return -1;
        }
        public ContaBancaria RetornaConta(int Numero){
          
            int i = IndiceConta(Numero);
            if (i==-1){
                throw new Exception("Conta Incorreta");
            }
            return Contas[i];
                
        }


        private List<ContaBancaria> Contas {get; set;}


    }
}