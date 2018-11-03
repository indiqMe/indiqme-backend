using IndiqMe.Domain;
using IndiqMe.Domain.Enums;
using IndiqMe.Service;
using IndiqMe.Test.Unit.Mocks;
using System;
using System.Text;
using Xunit;

namespace IndiqMe.Test.Unit.Services
{
    public class EmailTemplateTests
    {
        readonly IEmailTemplate emailTemplate;

        private User user;
        private User administrator;
        private User requestingUser;
        private ContactUs contactUs;

        public EmailTemplateTests()
        {
            emailTemplate = new EmailTemplate();

            user = UserMock.GetDonor();

            requestingUser = UserMock.GetGrantee();

            administrator = UserMock.GetAdmin();

           
            contactUs = new ContactUs()
            {
                Name = "Rafael Rocha",
                Email = "rafael@sharebook.com.br",
                Message = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                Phone = "(11) 954422-2765"
            };
        }

        [Fact]
        public void VerifyEmailContactUsNotificationParse()
        {

            var contactUs = new ContactUs()
            {
                Name = "Rafael Rocha",
                Email = "rafael.rochaoliveira@yahoo.com.br"
            };
          

            var result = emailTemplate.GenerateHtmlFromTemplateAsync("ContactUsNotificationTemplate", contactUs).Result;
            Assert.Contains("Olá, Rafael Rocha", result);

        }

        [Fact]
        public void VerifyEmailContactUsTemplateParse()
        {
            var result = emailTemplate.GenerateHtmlFromTemplateAsync("ContactUsTemplate", contactUs).Result;

            Assert.Contains("Olá, Administrador(a)!", result);
            Assert.Contains("Nome: Rafael Rocha", result);
            Assert.Contains("Email: rafael@sharebook.com.br", result);
            Assert.Contains("Telefone: (11) 954422-2765", result);
            Assert.Contains("Mensagem: At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", result);

        }
    }
}