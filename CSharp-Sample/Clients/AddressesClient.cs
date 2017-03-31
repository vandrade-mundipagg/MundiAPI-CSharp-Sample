using CSharp_Sample.Builders;
using CSharp_Sample.Helpers;
using MundiAPI.PCL;
using MundiAPI.PCL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Clients {
    internal static class AddressesClient {

        internal static string CreateAddress(IMundiAPIClient client, string customerId) {
            var request = AddressBuilders.BuildCreateAddressRequest();

            try {
                var response = client.Customers.CreateAddress(customerId, request);
                FileHelper.SaveResponse(response, "CreateAddress");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreateAddress");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreateAddress");
                return null;
            }

        }

        internal static void UpdateAddress(IMundiAPIClient client, string customerId, string addressId) {
            var request = AddressBuilders.BuildUpdateAddressRequest();

            try {
                var response = client.Customers.UpdateAddress(customerId, addressId, request);
                FileHelper.SaveResponse(response, "UpdateAddress");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateAddress");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "UpdateAddress");
            }

        }

        internal static void GetAddress(IMundiAPIClient client, string customerId, string addressId) {

            try {
                var response = client.Customers.GetAddress(customerId, addressId);
                FileHelper.SaveResponse(response, "GetAddress");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetAddress");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetAddress");
            }
        }

        internal static void GetAddresses(IMundiAPIClient client, string customerId) {

            try {
                var response = client.Customers.GetAddresses(customerId);
                FileHelper.SaveResponse(response, "GetAddresses");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetAddresses");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetAddresses");
            }

        }

        internal static void DeleteAddress(IMundiAPIClient client, string customerId, string addressId) {

            try {
                var response = client.Customers.DeleteAddress(customerId, addressId);
                FileHelper.SaveResponse(response, "DeleteAddress");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteAddress");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "DeleteAddress");
            }
        }

    }
}
