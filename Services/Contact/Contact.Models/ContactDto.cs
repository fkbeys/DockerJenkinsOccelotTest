namespace Contact.Models
{
    public class ContactDto
    {
        public int contactId { get; set; }
        public string contactName { get; set; }
        public string contactSurname { get; set; }
         
        public string contactFullName => contactName+" "+contactSurname;

        public double contactLat { get; set; }
        public double contactLong { get; set; }
    }
}
