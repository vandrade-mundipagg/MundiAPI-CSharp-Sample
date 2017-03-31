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
    internal static class PlansClient {

        internal static string CreatePlan(IMundiAPIClient client) {
            var request = PlanBuilders.BuildCreatePlanRequest();

            try {
                var response = client.Plans.CreatePlan(request);
                FileHelper.SaveResponse(response, "CreatePlan");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreatePlan");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreatePlan");
                return null;
            }
        }

        internal static void UpdatePlan(IMundiAPIClient client, string planId) {

            var request = PlanBuilders.BuildUpdatePlanRequest();

            try {
                var response = client.Plans.UpdatePlan(request, planId);
                FileHelper.SaveResponse(response, "UpdatePlan");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdatePlan");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdatePlan");
            }

        }

        internal static void GetPlan(IMundiAPIClient client, string planId) {

            try {
                var response = client.Plans.GetPlan(planId);
                FileHelper.SaveResponse(response, "GetPlan");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetPlan");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetPlan");
            }

        }

        internal static void GetPlans(IMundiAPIClient client) {

            try {
                var response = client.Plans.GetPlans();
                FileHelper.SaveResponse(response, "GetPlans");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "GetPlans");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "GetPlans");
            }

        }

        internal static void DeletePlan(IMundiAPIClient client, string planId) {
            try {
                var response = client.Plans.DeletePlan(planId);
                FileHelper.SaveResponse(response, "DeletePlan");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeletePlan");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeletePlan");
            }
        }

        internal static string CreatePlanItem(IMundiAPIClient client, string planId) {

            var request = PlanBuilders.BuildCreatePlanItemRequest();

            try {
                var response = client.Plans.CreatePlanItem(request,planId);
                FileHelper.SaveResponse(response, "CreatePlanItem");
                return response.Id;
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "CreatePlanItem");
                return null;
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "CreatePlanItem");
                return null;
            }
        }

        internal static void UpdatePlanItem(IMundiAPIClient client, string planId, string planItemId) {
            var request = PlanBuilders.BuildUpdatePlanItemRequest();

            try {
                var response = client.Plans.UpdatePlanItem(planId, planItemId, request);
                FileHelper.SaveResponse(response, "UpdatePlanItem");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "UpdatePlanItem");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "UpdatePlanItem");
            }

        }

        internal static void DeletePlanItem(IMundiAPIClient client, string planId, string planItemId) {
            try {
                var response = client.Plans.DeletePlanItem(planId, planItemId);
                FileHelper.SaveResponse(response, "DeletePlanItem");
            }
            catch (ErrorException e) {
                FileHelper.SaveApiError(e, "DeletePlanItem");
            }
            catch (Exception e) {
                FileHelper.SaveException(e, "DeletePlanItem");
            }
        }

        internal static void GetPlanItem(IMundiAPIClient client, string planId, string planItemId) {

            try {
                var response = client.Plans.GetPlanItem(planId, planItemId);
                FileHelper.SaveResponse(response, "GetPlanItem");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetPlanItem");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetPlanItem");
            }

        }

        internal static void GetPlanItems(IMundiAPIClient client, string planId) {

            try {
                var response = client.Plans.GetPlanItems(planId);
                FileHelper.SaveResponse(response, "GetPlanItems");
            }
            catch(ErrorException e) {
                FileHelper.SaveApiError(e, "GetPlanItems");
            }
            catch(Exception e) {
                FileHelper.SaveException(e, "GetPlanItems");
            }

        }

    }
}
