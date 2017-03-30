using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders
{
    internal static class ChargeBuilders
    {

        internal static UpdateChargePaymentMethodRequest BuildUpdateChargePaymentMethodRequest()
        {
            var request = new UpdateChargePaymentMethodRequest()
            {
                PaymentMethod = "boleto"
            };

            return request;
        }

        internal static UpdateChargeCreditCardRequest BuildUpdateChargeCreditCardRequest()
        {

            var request = new UpdateChargeCreditCardRequest()
            {
                CreditCard = new CreateCreditCardRequest()
                {
                    Number = "5598193511496317",
                    Cvv = "321",
                    ExpMonth = 1,
                    ExpYear = 23,
                    HolderName = "NOVO COMPRADOR",
                }
            };

            return request;
        }

        internal static CreateChargeRequest BuildCreateChargeRequest(string paymentMethod = "credit_card", int amount = 100, bool capture = true)
        {
            var request = new CreateChargeRequest();
            request.Amount = amount;
            request.Code = Guid.NewGuid().ToString().Substring(0, 6);
            request.Customer = new CreateCustomerRequest()
            {
                Name = "Vitor de Andrade",
                Email = "vandrade@mundipagg.com"
            };
            request.Payment = new CreatePaymentRequest()
            {
                PaymentMethod = paymentMethod,
            };

            switch (paymentMethod)
            {
                case "boleto":
                    break;
                case "credit_card":
                    request.Payment.CreditCard = new CreateCreditCardPaymentRequest()
                    {
                        CreditCardInfo = new CreateCreditCardRequest()
                        {
                            Number = "4556604245849434",
                            HolderName = "VITOR DE ANDRADE",
                            Cvv = "123",
                            ExpMonth = 12,
                            ExpYear = 21
                        },
                        StatementDescriptor = "STATEMENT TEST",
                        Installments = 3
                    };

                    break;
            }

            return request;
        }


    }
}
