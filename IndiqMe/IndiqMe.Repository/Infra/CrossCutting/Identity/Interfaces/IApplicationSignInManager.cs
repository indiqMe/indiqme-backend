using IndiqMe.Domain;
using IndiqMe.Repository.Infra.CrossCutting.Identity.Configurations;

namespace IndiqMe.Repository.Infra.CrossCutting.Identity.Interfaces
{
    public interface IApplicationSignInManager
    {
        object GenerateTokenAndSetIdentity(User user, SigningConfigurations signingConfigurations, TokenConfigurations tokenConfigurations);
    }
}
