namespace Location
{
    public class Address
    {
        public Address(string street, string? apt, string city, string state, string postalCode)
        {
            Street = street;
            Apt = apt;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public string Street { get; set; }
        public string? Apt { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public override string ToString() 
            => $"{Street}\n{Apt}\n{City}, {State} {PostalCode}";
    }

}