using Microsoft.EntityFrameworkCore;
using Sklep.Context;

namespace Sklep.Service
{
    public class AccountService
    {
        private readonly ApplicationDBContext _applicationDbContext;
        public AccountService(ApplicationDBContext applicationDBContext) 
        {
            _applicationDbContext = applicationDBContext;
        }

        // Dostać wszystkie konta z bazy danych
        public async Task<List<Shared.Account>> GetAllAccounts()
        {
            return await _applicationDbContext.Accounts.ToListAsync();
        }

        // Dodać nowy rekord do bazy danych
        public async Task<bool> AddNewAccount(Shared.Account account)
        {
            await _applicationDbContext.Accounts.AddAsync(account);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Dostać kontą za pomocą logina w bazie danych
        public async Task<Shared.Account> GetAccountsById(int id)
        {
            Shared.Account account = await _applicationDbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
            return account;
        }
    }
}
