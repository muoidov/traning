using Abp.Application.Services;
using muoi.Application.Tableone;
using muoi.Tableone.Dto;
using System.Threading.Tasks;

namespace muoi.Application
{
    public interface ITableoneService : IApplicationService
    {
        void CreateTableone(string input);
        Task<TableoneDto> GetAsync(CreateTableoneDto input);
        
    }
}
