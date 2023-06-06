using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DTOLayer.ProductDTOs
{
    public class UpdateProductDTO
    {
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductAddress { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int Square { get; set; }
        public string CoverImageURL { get; set; }
        public int CategoryID { get; set; }
    }
}
