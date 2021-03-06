﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip22.Models
{
    public class BookingCreate
    {
        public int BookingId { get; set; }
        public int ProfileId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? NumOfWeekend { get; set; }
        public int? NumOfWeekDay { get; set; }
        public double TotalPrice { get; set; }
    }
}
