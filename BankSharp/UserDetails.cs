using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSharp
{
    public class UserDetails
    {
        private static string _username;
        private static string _saldo;
        private static string _cardsaldo;

        public static string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public static string Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public static string Cardsaldo
        {
            get
            {
                return _cardsaldo;
            }
            set
            {
                _cardsaldo = value;
            }
        }
    }
}
