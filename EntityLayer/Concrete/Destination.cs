﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]  //DATA ANNOTATION  //Key Attribute will assign IDs as Key row of the tables
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        //To do not delete through the solution every moment--helps to just passivate 

        public string CoverImage { get; set; }
        //Destinations coverimage
        public string Details1 { get; set; }
        //there too much sections of descriptions so I will divide them into more than one.
        public string Details2 { get; set; }
        //I guess that will make it more useful
        public string Image2 { get; set; }
        //Image of Descriptions

        public List<Comment> Comments { get; set; }
        //That property relates the Comments to Destinations.
        //Because each destination will have its comments seperately...

        public List<Reservation> Reservations { get; set; }





    }
}
