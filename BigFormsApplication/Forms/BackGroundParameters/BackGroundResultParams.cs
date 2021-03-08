using System;

namespace BigFormsApplication.Forms.BackGroundParameters
{
    public class BackGroundResultParams
    {
        public DateTime ProcessStarted { get; set; }
        public DateTime ProcessEnded { get; set; }
        public String AuteurVanDitAlles
        {
            get
            {
                return "Jan-Pieter van Acht"; 
            }
        }
    }

}
