using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    internal static class CustomerBuilders {

        internal static CreateCustomerRequest BuildCreateCustomerRequest() {
            var request = new CreateCustomerRequest() {
                Name = "Vitor de Andrade",
                Email = $"{Guid.NewGuid().ToString().Substring(0, 6)}@mundipagg.com",
                Document = "12728994706",
                PersonType = "person",
                Phone = "21999044903",
                Address = new CreateAddressRequest() {
                    City = "City",
                    Complement = "Complement",
                    Country = "BR",
                    Neighborhood = "Neighborhood",
                    Number = "123",
                    State = "RJ",
                    Street = "Street",
                    ZipCode = "22221010"
                }
            };
            return request;
        }

        internal static UpdateCustomerRequest BuildUpdateCustomerRequest() {
            var request = new UpdateCustomerRequest() {
                Name = "Updated Customer",
                Email = $"{Guid.NewGuid().ToString().Substring(0,6)}@gmail.com"
            };

            return request;
        }
    }
}
