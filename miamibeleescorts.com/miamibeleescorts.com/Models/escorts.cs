using System;
using System.ComponentModel.DataAnnotations;

namespace miamibeleescorts.com.Models
{
    public class escorts
    {
        //escortname, age, availability, height, weight, dress, bra, hair, eye, language, nationality, description, file_name1, file_name2, file_name3, file_name4, file_name5, file_name6, file_name7
        [Key]
        public int escort_id { get; set; }
        public string? escortname { get; set; }
        //public string? escortSection { get; set; }
        public int? age { get; set; }
        //public int? dsize { get; set; }
        //public int? dresssize { get; set; }
        public string? availability { get; set; }
        public string? height { get; set; }
        public string? weight { get; set; }

        public string? dress { get; set; }
        public string? bra { get; set; }

        public string? hair { get; set; }
        public string? eye { get; set; }
        public string? language { get; set; }

        public string? nationality { get; set; }
        //public string? origin { get; set; }
        public string? rate1 { get; set; }
        public string? rate2 { get; set; }
        public string? rate3 { get; set; }
        public string? rate4 { get; set; }
        //public string? phone { get; set; }
        //public string? email { get; set; }
        //public string? gmap { get; set; }
        public string? file_name1 { get; set; }
        public string? file_name2 { get; set; }
        public string? file_name3 { get; set; }
        public string? file_name4 { get; set; }
        public string? file_name5 { get; set; }
        public string? file_name6 { get; set; }
        public string? file_name7 { get; set; }
        public string? file_name8 { get; set; }
        public string? file_name9 { get; set; }
        public string? file_name10 { get; set; }
        public string? file_name11 { get; set; }
        public string description { get; set; }
    }
}
