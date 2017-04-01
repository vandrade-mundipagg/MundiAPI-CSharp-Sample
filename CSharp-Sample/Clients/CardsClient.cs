using CSharp_Sample.Builders;
using CSharp_Sample.Helpers;
using MundiAPI.PCL;
using MundiAPI.PCL.Exceptions;
using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Clients {
    internal static class CardsClient {

        internal static string CreateCreditCard(IMundiAPIClient client, string customerId) {
            var request = CardBuilders.BuildCreateCreditCardRequest();

            try {
                var response = client.Customers.CreateCreditCard(customerId, request);
                FileHelper.SaveResponse(response, "CreateCreditCard");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreateCreditCard");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreateCreditCard");
                return null;
            }

        }

        internal static void UpdateCreditCard(IMundiAPIClient client, string customerId, string cardId) {
            var request = CardBuilders.BuildUpdateCreditCardRequest();

            try {
                var response = client.Customers.UpdateCreditCard(customerId, cardId, request);
                FileHelper.SaveResponse(response, "UpdateCreditCard");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateCreditCard");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "UpdateCreditCard");
            }
        }

        internal static void GetCreditCard(IMundiAPIClient client, string customerId, string cardId) {
            try {
                var response = client.Customers.GetCreditCard(customerId, cardId);
                FileHelper.SaveResponse(response, "GetCreditCard");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetCreditCard");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetCreditCard");
            }
        }

        internal static void GetCreditCards(IMundiAPIClient client, string customerId) {
            try {
                var response = client.Customers.GetCreditCards(customerId);
                FileHelper.SaveResponse(response, "GetCreditCards");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetCreditCards");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetCreditCards");
            }
        }

        internal static void DeleteCreditCard(IMundiAPIClient client, string customerId, string cardId) {
            try {
                var response = client.Customers.DeleteCreditCard(customerId, cardId);
                FileHelper.SaveResponse(response, "DeleteCreditCard");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteCreditCard");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "DeleteCreditCard");
            }
        }

    }
}
