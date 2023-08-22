namespace RealHouzing.DTOLayer.ServiceDTOs
{
    public class UpdateServiceDTO
    {
        public int ServiceID { get; set; }
        public string? Title { get; set; }
        public string Icon { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
    }
}
