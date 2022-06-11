using CommonConfiguration.Core.Data.Data.Common;

namespace BlogAndShop.Data.Data.Email
{
    public partial class EmailAccount : BaseEntity
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool EnableSsl { get; set; }
        public bool UserDefaultCredentials { get; set; }
        public string FriendlyName { get; set; }
        public bool IsDefault { get; set; }
    }
}
