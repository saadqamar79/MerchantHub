using MerchantHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantHub.Domain.Entities
{
    public partial class Tenant
    {
        public int Id { get; set; }
        //store info
        public string StoreName { get; set; } = string.Empty;
        public string StoreDomain { get; set; } = string.Empty;
        public string StoreCategory { get; set; } = string.Empty;
        public string StoreLogoPath { get; set; } = string.Empty;
        public bool IsApproved { get; set; } = false;
        public bool IsBlocked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string PhysicalAddress { get; set; } = string.Empty;

        //Owner info
        public string FullName { get; set; } = string.Empty; //as per CNIC | just to match with CNIC, login will be done in User table
        public string FatherName { get; set; } = string.Empty; //as per CNIC
        public string CNIC { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty; //as per CNIC current address OR permanent address

        //payment info
        public List<PaymentMethodsEnum> SelectedPaymentMethods { get; set; } = [];
        public string? BankAccountNumber { get; set; } = string.Empty;

    }
}
