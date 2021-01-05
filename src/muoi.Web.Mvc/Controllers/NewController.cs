using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using muoi.Application;
using muoi.Application.Tableone;
using muoi.Tableone.Dto;
using System;
using System.Threading.Tasks;

namespace muoi.Web.Controllers
{
    public class NewController : ControllerBase
    {
        private readonly ITableoneService _tableoneService;  
        public NewController(ITableoneService tableoneAppService)
        {
            _tableoneService = tableoneAppService;
        }
        public ActionResult Index()=>View();

        private ActionResult View()
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult> EditTable(int tableId)
        {
            return View();
        }
    }
        
    }

