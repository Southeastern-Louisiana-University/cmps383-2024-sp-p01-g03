﻿namespace Selu383.SP24.Api.Dto
{
    public class HotelDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class HotelCreateDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class HotelUpdateDto
    {
        public string name { get; set; }
        public string address { get; set; }
    }
}