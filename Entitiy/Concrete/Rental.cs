﻿using Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrete
{
   public  class car:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
