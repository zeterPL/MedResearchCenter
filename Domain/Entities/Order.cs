﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ExmainationId { get; set; }
        public Examination Examination { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }


    }
}
