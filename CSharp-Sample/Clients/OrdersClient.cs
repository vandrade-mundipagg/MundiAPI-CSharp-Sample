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
    public static class OrdersClient {

        internal static string CreateCardOrder(IMundiAPIClient client) {

            var request = OrderBuilders.BuildCreateOrderRequest();

            try {
                var response = client.Orders.CreateOrder(request);

                FileHelper.SaveResponse(response, "CreateCardOrder");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreateCardOrder");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreateCardOrder");
                return null;
            }

        }

        internal static void GetOrder(IMundiAPIClient client, string orderId) {
            try {
                var response = client.Orders.GetOrder(orderId);
                FileHelper.SaveResponse(response, "GetOrder");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetOrder");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetOrder");
            }
        }

        internal static void GetOrders(IMundiAPIClient client) {
            try {
                var response = client.Orders.GetOrders();
                FileHelper.SaveResponse(response, "GetOrders");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetOrders");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetOrders");
            }
        }

    }
}
