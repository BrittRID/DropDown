namespace WebContactsRedo.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string Brand { get; set; }

        public string Sphere { get; set; }
        public string Cylinder { get; set; }
        public double Axis { get; set; }
        public double BaseCurve { get; set; }
        public double Dia { get; set; }
        public string MF { get; set; }

        public ContactForm()
        {

        }
    }
}
