using ExpensiveControlApp.Infra.Database;
using ExpensiveControlApp.Models.Expensives;
using Microsoft.EntityFrameworkCore;

namespace ExpensiveControlApp.Services
{
    public class ExpensiveService : IExpensiveService
    {
        private readonly ExpensiveControlContext _dbcontext;
        public ExpensiveService(ExpensiveControlContext context)
        {
            _dbcontext = context;
        }

        public async Task Create(DTOs.CreateExpensiveDTO createExpensiveDTO)
        {
            await _dbcontext.Expensives.AddAsync(new Expensive()
            {
                Description = createExpensiveDTO.Description,
                Date = createExpensiveDTO.Date,
                Value = createExpensiveDTO.Value,


            });
            await _dbcontext.SaveChangesAsync();             
        }

        public async Task<List<Expensive>> FindBy(DateTime startDate, DateTime enDate)
        { 
            if(startDate > enDate)
            throw  new Exception("Data final deve ser maior que data inicial.");
        
            var  items = await  _dbcontext.Expensives.Where(e => e.Date >=startDate && e.Date <= enDate) .AsNoTracking().ToListAsync();
            return items;
        }


    }
}
