using DnssWebApi.Dto;
using DnssWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi.Controllers
{
    [ApiController]
    [Route("models")]
    public class AdmaController : ControllerBase
    {
        private readonly IInMemModelRepo repository;

        public AdmaController(IInMemModelRepo repository)
        {
            this.repository = repository;
        }

        public AdmaController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<AdmaModel>> GetModels()
        {
            return (await repository.GetModels()).Select(model => model.AsDtoAdmaModel());
        }

        [HttpGet("userName{name}/")]
        public async Task<ActionResult<AdmaModel>> GetModel(string name)
        {
            var model = await repository.GetModel(name);
            if (model is null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        //[HttpGet("{type}")]
        //public async Task<ActionResult<AdmaModel>> GetType(string type)
        //{
        //    var model = await repository.GetVersion(type);
        //    if (model is null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(model);
        //}

        [HttpPost]
        public async Task<ActionResult<AdmaModelDto>> CreateModel(CreateModelDto modelDto)
        {
            AdmaModel model = new()
            {
                CurrentWeight = modelDto.CurrentWeight,
                WantedWeight = modelDto.WantedWeight,
                Height = modelDto.Height,
                Name = modelDto.Name
            };

            await repository.CreateModel(model);

            return CreatedAtAction(nameof(GetModel), model.AsDtoAdmaModel());
        }
    }
}
