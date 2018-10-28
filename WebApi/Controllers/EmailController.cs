using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Contracts;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/emails")]
    public class EmailController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public EmailController(IMapper mapper, IEmailService emailService)
        {
            _mapper = mapper;
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]CreateEmailContract contract)
        {
            var model = _mapper.Map<CreateEmailModel>(contract);
            var result = _emailService.SendEmail(model);

            return Ok(result);
        }
    }
}
