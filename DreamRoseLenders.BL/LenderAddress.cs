namespace DreamRoseLenders.BL
{
    public class LenderAddress
    {
        public LenderAddress()
        {

        }
        public LenderAddress(int addressId)
        {
            AddressId = addressId;
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
    }
}
