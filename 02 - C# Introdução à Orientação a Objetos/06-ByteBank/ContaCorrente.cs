namespace _06_ByteBank
{
    public class ContaCorrente
    {
        /*
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        */
        public Cliente Titular { get; set;}

        
        // public int agencia;
        public int Agencia { get; set; }
        
        
        // public int numero;
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

        /*
        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }
        */
    }
}