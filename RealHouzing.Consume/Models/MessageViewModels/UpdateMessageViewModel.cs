namespace RealHouzing.Consume.Models.MessageViewModels
{
    public class UpdateMessageViewModel
    {
        public int ContactID { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
