using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Account
    {
        private Guid _Id;
        private decimal _TotalAccount;
        private Guid _IdUser;
        private DateTime _DateCreated;

        public Guid Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public decimal TotalAccount
        {
            set { _TotalAccount = value; }
            get { return _TotalAccount; }
        }
        public Guid IdUser
        {
            set { _IdUser = value; }
            get { return _IdUser; }
        }
        public DateTime DateCreated
        {
            set { _DateCreated = value; }
            get { return _DateCreated; }
        }

        public Account(Guid id, decimal totalAccount, Guid idUser, DateTime dateCreated)
        {
            Id = id;
            TotalAccount = totalAccount;
            IdUser = idUser;
            DateCreated = dateCreated;
        }

        public static Account Create(Guid id, decimal totalAccount, Guid idUser, DateTime dateCreated) {

            return new Account( id,  totalAccount,  idUser,  dateCreated);
        }
    }
}
