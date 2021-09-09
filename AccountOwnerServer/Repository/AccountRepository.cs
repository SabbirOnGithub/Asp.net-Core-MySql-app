using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
   public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return FindAll()
                .OrderByDescending(ac => ac.DateCreated)
                .ToList();
        }

        public Account GetAccountById(Guid accountId)
        {
            return FindByCondition(ac => ac.Id.Equals(accountId)).FirstOrDefault();
        }

        public Account GetAccountWithDetails(Guid accountId)
        {
            return FindByCondition(ac => ac.Id.Equals(accountId))
                .Include(o => o.Owner)
                .FirstOrDefault();
        }

        public void CreateAccount(Account account)
        {
            Create(account);
        }

        public void UpdateAccount(Account account)
        {
            Update(account);
        }

        public void DeleteAccount(Account account)
        {
            Delete(account);
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
