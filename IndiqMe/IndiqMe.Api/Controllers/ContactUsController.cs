using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using IndiqMe.Api.ViewModels;
using IndiqMe.Domain;
using IndiqMe.Domain.Common;
using IndiqMe.Service;

namespace IndiqMe.Api.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    public class ContactUsController : Controller
    {
        IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        [HttpPost("SendMessage")]
        public Result<ContactUs> SendMessage([FromBody]ContactUsVM contactUsVM)
        { 
            var contactUS = Mapper.Map<ContactUs>(contactUsVM);

            return _contactUsService.SendContactUs(contactUS);
        }
    }
}
