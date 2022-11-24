using Core.Application.Dtos;

namespace ETradeApi.Application.Features.Auths.Dtos
{
    public class EnabledOtpAuthenticatorDto : IDto
    {
        public string SecretKey { get; set; }

        public EnabledOtpAuthenticatorDto()
        {
        }

        public EnabledOtpAuthenticatorDto(string secretKey)
        {
            SecretKey = secretKey;
        }
    }
}
