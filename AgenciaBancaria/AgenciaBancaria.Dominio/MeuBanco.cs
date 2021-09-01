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
            string aux="****Lista de Contas Cadastradas****"+Environment.NewLine;
            foreach (ContaBancaria c in Contas)
            {
                aux+= "123Conta " + c.Situacao + ": " + c.NumeroConta + "-" + 
                    c.DigitoVerificador + Environment.NewLine;
    
            }
            aux+="*********************************"+Environment.NewLine;

            return aux;
        }
        //transfere de uma conta para outra
        public void Transferir(int de, int para, decimal valor){
            

        }
        //retorna indice da lista de um numero de conta específico
        public int IndiceConta(int Numero){
            for(int i=0; i<Contas.Count;i++){
                if(Contas[i].NumeroConta==Numero)
                    return i;
            }
            return -1;
        }


        public List<ContaBancaria> Contas {get; private set;}


    }
}