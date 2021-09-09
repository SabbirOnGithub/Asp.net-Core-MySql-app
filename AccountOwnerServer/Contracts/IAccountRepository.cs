using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> GetAllAccounts();
        Account GetAccountById(Guid accountId);
        Account GetAccountWithDetails(Guid accountId);

        void CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}
