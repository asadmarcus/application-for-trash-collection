using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        //[Key, ForeignKey("ApplicationUser")]
        //public int ApplicationUser { get; set; }
        //public virtual ApplicationUser applicationUser { get; set; }
        [Display(Name = "Customer Account Name")]
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //Regular Pickup.
        [Display(Name = "Regular Pickup Active")]
        public bool RegularPickupActive { get; set; }
        [Display(Name = "Regular Pickup Day of Week")]
        public DayOfWeek RegularPickupDayOfWeek { get; set; }
        [Display(Name = "Regular Pickup Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupStartDate { get; set; }
        [Display(Name = "Regular Pickup End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegularPickupEndDate { get; set; }
        [Display(Name = "Price per Regular Pickup")]
        public double RegularPickupPrice { get; set; }

        //Special Pickup.
        [Display(Name = "Special Pickup Active")]
        public bool SpecialPickupActive { get; set; }
        [Display(Name = "Special Pickup Day of Week")]
        public DayOfWeek SpecialPickupDayOfWeek { get; set; }
        [Display(Name = "Special Pickup Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SpecialPickupStartDate { get; set; }
        [Display(Name = "Special Pickup End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SpecialPickupEndDate { get; set; }
        [Display(Name = "Price per Special Pickup")]
        public double SpecialPickupPrice { get; set; }
        //Vacation Schedule.
        [Display(Name = "Vacation Active, Service Paused")]
        public bool VacationActivePickupPaused { get; set; }
        [Display(Name = "Vacation Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationStartDate { get; set; }
        [Display(Name = "Vacation End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime VacationEndDate { get; set; }
    }
}