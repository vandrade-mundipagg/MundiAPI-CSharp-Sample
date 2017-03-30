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
    internal static class CustomersClient {

        internal static string CreateCustomer(IMundiAPIClient client) {
            var request = CustomerBuilders.BuildCreateCustomerRequest();

            try {
                var response = client.Customers.CreateCustomer(request);

                FileHelper.SaveResponse(response, "CreateCustomer");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreateCustomer");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreateCustomer");
                return null;
            }
        }

        internal static void UpdateCustomer(IMundiAPIClient client, string customerId) {
            
            var request = CustomerBuilders.BuildUpdateCustomerRequest();

            try {
                var response = client.Customers.UpdateCustomer(customerId, request);
                FileHelper.SaveResponse(response, "UpdateCustomer");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateCustomer");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "UpdateCustomer");
            }

        }

        internal static void GetCustomer(IMundiAPIClient client, string customerId) {

            try {
                var response = client.Customers.GetCustomer(customerId);
                FileHelper.SaveResponse(response, "GetCustomer");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetCustomer");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetCustomer");
            }

        }

        internal static void GetCustomers(IMundiAPIClient client) {
            try {
                var response = client.Customers.GetCustomers();
                FileHelper.SaveResponse(response, "GetCustomers");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetCustomers");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetCustomers");
            }
        }

    }
}
