namespace ACME.Models
{
    public class Postcodes
    {
        public int ID { get; set; }

        public string Pcode { get; set; }

        public string Locality { get; set; }

        public string State { get; set; }

        public string Comments { get; set; }

        public string DeliveryOffice { get; set; }

        public string PreSortIndicator { get; set; }

        public string ParcelZone { get; set; }

        public string BSPNumber { get; set; }

        public string BSPName { get; set; }

        public string Category { get; set; }
    }
}