namespace RealHouzing.DTOLayer.ContactDTOs
{
    public class UpdateContactDTO
    {
        public int ContactID { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
