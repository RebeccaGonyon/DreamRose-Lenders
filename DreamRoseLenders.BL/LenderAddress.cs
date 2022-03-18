namespace DreamRoseLenders.BL
{
    public class LenderAddress
    {
        public LenderAddress(int addressId, string city, String zipCode, string state, string streetLine1, string streetLine2)
        {
            AddressId = addressId;
            City = city;
            ZipCode = zipCode;
            State = state;
            StreetLine1 = streetLine1;
            StreetLine2 = streetLine2;
        }
         
        public int AddressId { get; private set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string? State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        //Validates the address data
        public bool Validate()
        {
            var isValid = true;

            if (ZipCode == null) isValid = false;

            return isValid;
        }

        public static implicit operator LenderAddress(string v)
        {
            throw new NotImplementedException();
        }
    }
}
