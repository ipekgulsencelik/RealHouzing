﻿namespace RealHouzing.DTOLayer.BlogDTOs
{
    public class AddBlogDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImageURL { get; set; }
        public string Writer { get; set; }
        public string WriterImageURL { get; set; }
        public DateTime Date { get; set; }
    }
}
