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

namespace CSharp_Sample.Clients
{
    public static class ChargesClient
    {

        internal static string CreateChargePreAuth(IMundiAPIClient client)
        {
            var request = ChargeBuilders.BuildCreateChargeRequest(capture: false);

            try
            {
                var response = client.Charges.CreateCharge(request);

                FileHelper.SaveResponse(response, "CreateChargePreAuth");

                return response.Id;
            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, "CreateChargePreAuth");
                return null;
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, "CreateChargePreAuth");
                return null;
            }

        }

        internal static void CaptureCharge(IMundiAPIClient client, string chargeId)
        {
            try
            {
                var response = client.Charges.CaptureCharge(chargeId, null);
                FileHelper.SaveResponse(response, "CaptureCharge");
            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, "CaptureCharge");
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, "CaptureCharge");
            }
        }

        internal static void ChangePaymentMethod(IMundiAPIClient client, string chargeId)
        {
            var request = ChargeBuilders.BuildUpdateChargePaymentMethodRequest();

            try 
            {
                var response = client.Charges.UpdateChargePaymentMethod(chargeId, request);
                FileHelper.SaveResponse(response, "ChangePaymentMethod");
            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, "ChangePaymentMethod");
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, "ChangePaymentMethod");
            }
        }

        internal static void GetCharges(IMundiAPIClient client)
        {
            try
            {
                var response = client.Charges.GetCharges();
                FileHelper.SaveResponse(response, "GetCharges");
            }
            catch(ErrorException e)
            {
                FileHelper.SaveApiError(e, "GetCharges");
            }
            catch(Exception e)
            {
                FileHelper.SaveException(e, "GetCharges");
            }
        }

        internal static void GetCharge(IMundiAPIClient client, string chargeId)
        {
            try
            {
                var response = client.Charges.GetCharge(chargeId);
                FileHelper.SaveResponse(response, "GetCharge");
            }
            catch(ErrorException e)
            {
                FileHelper.SaveApiError(e, "GetCharge");
            }
            catch(Exception e)
            {
                FileHelper.SaveException(e, "GetCharge");
            }
        }

        internal static void ChangeCard(IMundiAPIClient client, string chargeId)
        {
            var request = ChargeBuilders.BuildUpdateChargeCreditCardRequest();

            try
            {
                var response = client.Charges.UpdateChargeCreditCard(chargeId, request);
                FileHelper.SaveResponse(response, "ChangeCard");
            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, "ChangeCard");
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, "ChangeCard");
            }
        }

        internal static void CancelCharge(IMundiAPIClient client, string id)
        {
            try
            {
                var response = client.Charges.CancelCharge(id);

                FileHelper.SaveResponse(response, "CancelCharge");

            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, "CancelCharge");
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, "CancelCharge");
            }
        }

        internal static string CreateBoletoCharge(IMundiAPIClient client)
        {
            var request = ChargeBuilders.BuildCreateChargeRequest("boleto");
            return CreateCharge(client, request);
        }

        internal static string CreateCardCharge(IMundiAPIClient client)
        {
            var request = ChargeBuilders.BuildCreateChargeRequest();

            return CreateCharge(client, request);

        }

        internal static string CreateCardNotAuthorizedCharge(IMundiAPIClient client)
        {
            var request = ChargeBuilders.BuildCreateChargeRequest("credit_card", 1000000);
            return CreateCharge(client, request);
        }

        internal static string CreateCharge(IMundiAPIClient client, CreateChargeRequest request)
        {
            try
            {
                var response = client.Charges.CreateCharge(request);

                FileHelper.SaveResponse(response, $"CREATE{request.Payment.PaymentMethod.ToUpper()}CHARGE");

                return response.Id;

            }
            catch (ErrorException e)
            {
                FileHelper.SaveApiError(e, $"CREATE{request.Payment.PaymentMethod.ToUpper()}CHARGE");

                return null;
            }
            catch (Exception e)
            {
                FileHelper.SaveException(e, $"CREATE{request.Payment.PaymentMethod.ToUpper()}CHARGE");

                return null;
            }
        }

    }
}
