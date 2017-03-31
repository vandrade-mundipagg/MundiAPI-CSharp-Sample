using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    internal static class AddressBuilders {

        internal static CreateAddressRequest BuildCreateAddressRequest() {
            var request = new CreateAddressRequest() {
                City = "City",
                Complement = "Complement",
                Country = "BR",
                Neighborhood = "Neighborhood",
                Number = "123",
                State = "RJ",
                Street = "Street",
                ZipCode = "22221010"
            };

            return request;
        }

        internal static UpdateAddressRequest BuildUpdateAddressRequest() {
            var request = new UpdateAddressRequest() {
                Complement = "New complement",
                Number = "222"
            };

            return request;
        }

    }
}
