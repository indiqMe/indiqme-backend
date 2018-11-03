using IndiqMe.Domain;
using System.Threading.Tasks;

namespace IndiqMe.Service
{
    public interface IContactUsEmailService
    {
        Task SendEmailContactUs(ContactUs contactUs);
    }
}
