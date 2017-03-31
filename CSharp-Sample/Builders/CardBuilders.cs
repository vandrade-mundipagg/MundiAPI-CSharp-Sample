using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    internal static class CardBuilders {

        internal static CreateCreditCardRequest BuildCreateCreditCardRequest() {
            var request = new CreateCreditCardRequest() {
                Number = "4556604245849434",
                HolderName = "VITOR DE ANDRADE",
                Cvv = "123",
                ExpMonth = 12,
                ExpYear = 21,
                Brand = "Visa",
                BillingAddress = new CreateAddressRequest() {
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

        internal static UpdateCreditCardRequest BuildUpdateCreditCardRequest() {
            var request = new UpdateCreditCardRequest() {
                HolderName = "NOME ATUALIZADO",
                ExpYear = 21,
                ExpMonth = 1,
                BillingAddress = new CreateAddressRequest() {
                    City = "New city",
                    Complement = "New complement",
                    Country = "BR",
                    Neighborhood = "New neighborhood",
                    Number = "New number",
                    State = "RJ",
                    Street = "New street",
                    ZipCode = "25966095"
                }
            };
            return request;
        }

    }
}
