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
    internal static class SubscriptionsClient {

        internal static string CreateSubscriptionByPlan(IMundiAPIClient client) {
            var planId = PlansClient.CreatePlan(client);
            var request = SubscriptionBuilders.BuildCreateSubscriptionByPlanRequest(planId);
            try {
                var response = client.Subscriptions.CreateSubscription(request);
                FileHelper.SaveResponse(response, "CreateSubscriptionByPlan");
                return response.Id;
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateSubscriptionByPlan");
                return null;
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateSubscriptionByPlan");
                return null;
            }
        }

        internal static string CreateSubscription(IMundiAPIClient client) {
            var request = SubscriptionBuilders.BuildCreateSubscriptionRequest();
            try {
                var response = client.Subscriptions.CreateSubscription(request);
                FileHelper.SaveResponse(response, "CreateSubscription");
                return response.Id;
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateSubscription");
                return null;
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateSubscription");
                return null;
            }
        }

        internal static void GetSubscription(IMundiAPIClient client, string subscriptionId) {
            try {
                var response = client.Subscriptions.GetSubscription(subscriptionId);
                FileHelper.SaveResponse(response, "GetSubscription");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetSubscription");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetSubscription");
            }
        }

        internal static string CreateSubscriptionItem(IMundiAPIClient client, string subscriptionId) {
            var request = SubscriptionBuilders.BuildCreateSubscriptionItemRequest();
            try {
                var response = client.Subscriptions.CreateSubscriptionItem(request, subscriptionId);
                FileHelper.SaveResponse(response, "CreateSubscriptionItem");
                return response.Id;
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateSubscriptionItem");
                return null;
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateSubscriptionItem");
                return null;
            }
        }

        internal static void UpdateSubscriptionItem(IMundiAPIClient client, string subscriptionId, string subscriptionItemId) {

            var request = SubscriptionBuilders.BuildUpdateSubscriptionItemRequest();

            try {
                var response = client.Subscriptions.UpdateSubscriptionItem(subscriptionId, subscriptionItemId, request);
                FileHelper.SaveResponse(response, "UpdateSubscriptionItem");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateSubscriptionItem");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdateSubscriptionItem");
            }
        }

        internal static string CreateUsage(IMundiAPIClient client, string subscriptionId, string subscriptionItemId) {

            var request = SubscriptionBuilders.BuildCreateUsageRequest();

            try {
                var response = client.Subscriptions.CreateUsage(subscriptionId, subscriptionItemId, request);
                FileHelper.SaveResponse(response, "CreateUsage");
                return response.Id;
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateUsage");
                return null;
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateUsage");
                return null;
            }
        }

        internal static void DeleteUsage(IMundiAPIClient client, string subscriptionId, string subscriptionItemId, string usageId) {
            try {
                var response = client.Subscriptions.DeleteUsage(subscriptionId, subscriptionItemId, usageId);
                FileHelper.SaveResponse(response, "DeleteUsage");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteUsage");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeleteUsage");
            }
        }

        internal static void GetUsages(IMundiAPIClient client, string subscriptionId, string subscriptionItemId) {
            try {
                var response = client.Subscriptions.GetUsages(subscriptionId, subscriptionItemId);
                FileHelper.SaveResponse(response, "GetUsages");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetUsages");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetUsages");
            }
        }

        internal static string CreateDiscount(IMundiAPIClient client, string subscriptionId) {
            var request = SubscriptionBuilders.BuildCreateDiscountRequest();

            try {
                var response = client.Subscriptions.CreateDiscount(request, subscriptionId);
                FileHelper.SaveResponse(response, "CreateDiscount");
                return response.Id;
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateDiscount");
                return null;
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateDiscount");
                return null;
            }
        }

        internal static void CreateDiscountOnItem(IMundiAPIClient client, string subscriptionId, string subscriptionItemId) {
            var request = SubscriptionBuilders.BuildCreateDiscountOnItemRequest(subscriptionItemId);

            try {
                var response = client.Subscriptions.CreateDiscount(request, subscriptionId);
                FileHelper.SaveResponse(response, "CreateDiscountOnItem");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "CreateDiscountOnItem");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "CreateDiscountOnItem");
            }
        }

        internal static void DeleteDiscount(IMundiAPIClient client, string subscriptionId, string discountId) {
            try {
                var response = client.Subscriptions.DeleteDiscount(subscriptionId, discountId);
                FileHelper.SaveResponse(response, "DeleteDiscount");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteDiscount");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeleteDiscount");
            }
        }

        internal static void DeleteSubscriptionItem(IMundiAPIClient client, string subscriptionId, string subscriptionItemId) {
            try {
                var response = client.Subscriptions.DeleteSubscriptionItem(subscriptionId, subscriptionItemId);
                FileHelper.SaveResponse(response, "DeleteSubscriptionItem");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteSubscriptionItem");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeleteSubscriptionItem");
            }
        }

        internal static void GetSubscriptionItems(IMundiAPIClient client, string subscriptionId) {
            try {
                var response = client.Subscriptions.GetSubscriptionItems(subscriptionId);
                FileHelper.SaveResponse(response, "GetSubscriptionItems");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetSubscriptionItems");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetSubscriptionItems");
            }
        }

        internal static void UpdateSubscriptionPaymentMethod(IMundiAPIClient client, string subscriptionId) {

            var request = SubscriptionBuilders.BuildUpdateSubscriptionPaymentMethodRequest();

            try {
                var response = client.Subscriptions.UpdateSubscriptionPaymentMethod(request, subscriptionId);
                FileHelper.SaveResponse(response, "UpdateSubscriptionPaymentMethod");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateSubscriptionPaymentMethod");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdateSubscriptionPaymentMethod");
            }
        }

        internal static void UpdateSubscriptionCreditCard(IMundiAPIClient client, string subscriptionId) {

            var request = SubscriptionBuilders.BuildUpdateSubscriptionCreditCardRequest();

            try {
                var response = client.Subscriptions.UpdateSubscriptionCreditCard(request, subscriptionId);
                FileHelper.SaveResponse(response, "UpdateSubscriptionCreditCard");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateSubscriptionCreditCard");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdateSubscriptionCreditCard");
            }
        }

        internal static void UpdateSubscriptionBillingDate(IMundiAPIClient client, string subscriptionId) {

            var request = SubscriptionBuilders.BuildUpdateSubscriptionBillingDateRequest();

            try {
                var response = client.Subscriptions.UpdateSubscriptionBillingDate(subscriptionId, request);
                FileHelper.SaveResponse(response, "UpdateSubscriptionDueDate");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdateSubscriptionDueDate");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdateSubscriptionDueDate");
            }
        }

        internal static void GetSubscriptionInvoices(IMundiAPIClient client, string subscriptionId) {
            try {
                var response = client.Subscriptions.GetSubscriptionInvoices(subscriptionId);
                FileHelper.SaveResponse(response, "GetSubscriptionInvoices");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetSubscriptionInvoices");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetSubscriptionInvoices");
            }
        }

        internal static void GetSubscriptions(IMundiAPIClient client) {
            try {
                var response = client.Subscriptions.GetSubscriptions();
                FileHelper.SaveResponse(response, "GetSubscriptions");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetSubscriptions");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetSubscriptions");
            }
        }

        internal static void DeleteSubscription(IMundiAPIClient client, string subscriptionId) {
            try {
                var response = client.Subscriptions.DeleteSubscription(subscriptionId);
                FileHelper.SaveResponse(response, "DeleteSubscription");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeleteSubscription");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeleteSubscription");
            }
        }

    }
}
