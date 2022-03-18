namespace DreamRoseLenders.BL
{

    public class Lender
    {
        public LenderAddress lenderAddress;
        public string? FullName
        {
            get
            {
                return ContactFirstName + " " + ContactLastName;
            }
        }
        public static int instanceCount;
        

        public int CompanyId { get; private set; } = 0;
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public List<LenderAddress> AddressList { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string States { get; set; }



        public Lender(string companyName, string lenderAddress, string contactFirstName, string contactLastName)
        {
            CompanyName = companyName;
            ContactFirstName = contactFirstName;
            ContactLastName = contactLastName;
            this.lenderAddress = lenderAddress;
            CompanyPhoneNumber = CompanyPhoneNumber;
            AddressList = new List<LenderAddress>();


        }

        public Lender(string companyName, string lenderAddress, string fullName)
        {
            CompanyName = companyName;
            this.lenderAddress = lenderAddress;
           
        }

        public Lender()
        {
        }

        public Lender(string companyName, string lenderAddress, string fullName, int companyPhoneNumber) : this(companyName, lenderAddress, fullName)
        {
        }

        public static int InstanceCount { get => instanceCount; set => instanceCount = value; }
    }

}

