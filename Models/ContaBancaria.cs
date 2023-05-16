using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBancario{
    public class ContaBancaria{
        // definindo propriedades

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _titular;
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        /*/ definindo construtores

        public ContaBancaria(int _numero, string _titular, decimal _saldo)
        {
            this.Numero = _numero;
            this.Titular = _titular;
            this.Saldo = _saldo;
        }*/

        // Definindo metodos ou funções

        public void Depositar(decimal deposito){
             Saldo += deposito;
        }

        public void Sacar(decimal saque){

            if (Saldo >= saque){
                Saldo -= saque;
            } else {
                Console.WriteLine(Environment.NewLine + "Sinto Muito o seu Saldo é insuficiente!");
            }
            
        }

        public void Transferencia(ContaBancaria contaDestino, decimal valorTransferencia){

            // só deve ser feito a transferencia se o mesmo tiver um saldo suficiente
            if(Saldo >= valorTransferencia){
                Saldo -= valorTransferencia;
                contaDestino.Depositar(valorTransferencia); // estou utilizando o metodo depositar para depositar o valor "valorTransferencia" na outra conta "ContaDestino"
            }else{
                Console.WriteLine("Sinto Muito, Você não possui esse valor em sua conta para transferir");
            }

        }

        public decimal ConsultarSaldoAtual(){
            return Saldo;
        }

        // Definindo o ToSting

        


        


        
        
    }
}
