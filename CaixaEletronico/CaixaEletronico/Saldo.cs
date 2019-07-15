using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class Saldo
    {
        private int _cinquenta;
        private int _vinte;
        private int _dez;
        private int _saldo;

        //verificar quantidade de notas
        public int notasCinquenta {
            get { return this._cinquenta; }
        }
        public int notasVinte
        {
            get { return this._vinte; }
        }
        public int notasDez
        {
            get { return this._dez; }
        }

        public int saldo {
            get { return this._saldo; }
        }

        //depositar notas
        public void addCinquenta (int valor)
        {
            this._cinquenta += valor;
        }
        public void addVinte (int valor)
        {
            this._vinte += valor;
        }
        public void addDez (int valor)
        {
            this._dez += valor;
        }

        //retirarnotas
        public void retiraCinquenta(int valor)
        {
            this._cinquenta -= valor;
        }
        public void retiraVinte(int valor)
        {
            this._vinte -= valor;
        }
        public void retiraDez(int valor)
        {
            this._dez -= valor;
        }

        public void calculaSaldo()
        {
            this._saldo = (this._cinquenta * 50) + (this._vinte * 20) + (this._dez * 10);
        }
    }
}

