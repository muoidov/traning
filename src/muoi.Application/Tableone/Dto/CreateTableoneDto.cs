using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace muoi.Application.Tableone
{
    [AutoMapTo(typeof(muoi.Core.Tableone))]
    public class CreateTableoneDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
     

    }
}
