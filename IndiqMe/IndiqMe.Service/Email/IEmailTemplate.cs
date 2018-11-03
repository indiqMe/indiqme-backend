using System.Threading.Tasks;

namespace IndiqMe.Service
{
    public interface IEmailTemplate
    {
        Task<string> GenerateHtmlFromTemplateAsync(string template, object model);
    }
}
