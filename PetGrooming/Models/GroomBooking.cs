using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */
        [Key]
        // primary key
        public int GroomBookingsID { get; set; }

        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Room { get; set; }
        public string Price { get; set; }

        // foreign key
        public int PetsID { get; set; }
        [ForeignKey("PetsID")]
        public virtual Pet Pet { get; set; }
        public int GroomServicesID { get; set; }
        [ForeignKey("GroomServicesID")]
        public virtual GroomService GroomService{ get; set; }
    }
}