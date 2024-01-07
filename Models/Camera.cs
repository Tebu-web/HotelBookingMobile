using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace HotelBookingMobile.Models
{
    public class Camera
    {
        [PrimaryKey, AutoIncrement]
        public int CameraId { get; set; }
        public string TipCamera { get; set; } // e.g., Single, Double, Suite
        [MaxLength(250), Unique]
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public List<Booking> Booking { get; set; }

    }
}
