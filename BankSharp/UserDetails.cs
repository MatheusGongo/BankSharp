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
        private static string _numberAccount;
        private static string _email;
        private static string _password;
        private static string _companyPrice;
        private static string _userId;
        private static string _myTransfer;
        private static string _typePayment;
        private static string _company;


        public static string UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }

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

        public static string NumberAccount
        {
            get
            {
                return _numberAccount;
            }
            set
            {
                _numberAccount = value;
            }
        }

        public static string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public static string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }


        public static string CompanyPrice
        {
            get
            {
                return _companyPrice;
            }
            set
            {
                _companyPrice = value;
            }
        }

        public static string MyTransfer
        {
            get
            {
                return _myTransfer;
            }
            set
            {
                _myTransfer = value;
            }
        }

        public static string TypePayment
        {
            get
            {
                return _typePayment;
            }
            set
            {
                _typePayment = value;
            }
        }

        public static string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
    }
}
