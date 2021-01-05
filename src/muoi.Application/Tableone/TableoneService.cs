using Abp.Domain.Repositories;
using muoi.Application.Tableone;
using muoi.Tableone.Dto;
using System.Threading.Tasks;

namespace muoi.Application
{
    public class TableoneService : ITableoneService
    {
       
        public void CreateTableone(string input)
        {
            
        }

       

        public Task<TableoneDto> GetAsync(CreateTableoneDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}
