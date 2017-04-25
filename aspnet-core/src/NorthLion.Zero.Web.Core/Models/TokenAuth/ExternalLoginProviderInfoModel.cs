using Abp.AutoMapper;
using NorthLion.Zero.Authentication.External;

namespace NorthLion.Zero.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
