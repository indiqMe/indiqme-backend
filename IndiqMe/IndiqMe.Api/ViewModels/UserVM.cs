using IndiqMe.Domain;

namespace IndiqMe.Api.ViewModels
{
    public class UserVM : BaseViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Linkedin { get; set; }

        public string Phone { get; set; }

        public Address Address { get; set; }
    }
}
