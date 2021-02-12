﻿using System;

namespace BL.DTO
{
    public class TicketDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string VendorName { get; set; }

        public string DiscountName { get; set; }

        public string VendorEmail { get; set; }

        public string VendorPhone { get; set; }

        public string PromoCode { get; set; }

        public int DiscountAmount { get; set; }

        public DateTime OrderDate { get; set; }

        public bool IsExpired { get; set; }
    }
}
