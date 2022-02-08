using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamRoseLenders.BL
{
    
        public class Lender
        {
            public int CompanyId { get; private set; } = 0;
            public string ContactFirstName { get; set; }
            public string ContactLastName { get; set; }

            public Lender(string contactFirstName) => ContactFirstName = contactFirstName;

        public Lender()
        {
        }

        public string CompanyName { get; set; }

            public string EmailAddress { get; set; }
            public string FullName
        {
                get
                {
                    string fullName = ContactLastName;
                    if (!string.IsNullOrWhiteSpace(ContactFirstName))
                    {
                        if (string.IsNullOrWhiteSpace(fullName))
                        {
                            fullName += ", ";
                        }
                        fullName += ContactFirstName;
                    }
                    return fullName;
                }
            }
            public static int InstanceCount { get; set; }
        }

    }

