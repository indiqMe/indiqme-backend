using IndiqMe.Domain;
using IndiqMe.Domain.Common;

namespace IndiqMe.Service
{
    public interface IContactUsService
    {
        Result<ContactUs> SendContactUs(ContactUs contactUs);
    }
}
