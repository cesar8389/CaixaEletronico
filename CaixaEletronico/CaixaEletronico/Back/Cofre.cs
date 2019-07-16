using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class Cofre
    {
        private int _saldo;
        private int _cinquenta;
        private int _vinte;
        private int _dez;


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

        //Tratar saldo
        public void aSaldo()
        {
            this._saldo = (this._cinquenta * 50) + (this._vinte * 20) + (this._dez * 10);
        }
        public int valorSaldo
        {
            get { return this._saldo; }
        }
    }
}

