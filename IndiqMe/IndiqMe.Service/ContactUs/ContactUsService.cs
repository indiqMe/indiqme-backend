using FluentValidation;
using IndiqMe.Domain;
using IndiqMe.Domain.Common;

namespace IndiqMe.Service
{
    public class ContactUsService : IContactUsService
    {
        IContactUsEmailService _contactUsEmailService;
        IValidator<ContactUs> _validator;
        public ContactUsService(IContactUsEmailService contactUsEmailService, IValidator<ContactUs> validator)
        {
            _contactUsEmailService = contactUsEmailService;
            _validator = validator;
        }
        public Result<ContactUs> SendContactUs(ContactUs entity)
        {

            var result = new Result<ContactUs>(_validator.Validate(entity));

            if (!result.Success)
                return result;

            _contactUsEmailService.SendEmailContactUs(entity);

            return result;
        }
    }
}
