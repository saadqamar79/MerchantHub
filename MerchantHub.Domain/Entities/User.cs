using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerchantHub.Domain.Enums;

namespace MerchantHub.Domain.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string FullName { get; set; } = string.Empty;
        //login credentials
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        //Authentication and Authorization
        public string? RefreshJwtToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set;}
        public List<UserRolesEnum> Role { get; set; } = [];
        public Tenant? Tenant { get; set; } // Navigation property to Tenant
    }
}
