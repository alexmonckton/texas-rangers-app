using System;
using SQLite;

namespace TexasRangersApp.Models
{
    public class Reservation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Reservation_Date { get; set; }
        public TimeSpan Reservation_Time { get; set; }
        public int Num_People { get; set; }
        public string Person_Name { get; set; }
        public DateTime Timestamp { get; set; }
    }
}