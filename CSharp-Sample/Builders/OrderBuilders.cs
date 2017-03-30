using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    public static class OrderBuilders {

        internal static CreateOrderRequest BuildCreateOrderRequest(string paymentMethod = "credit_card") {
            var request = new CreateOrderRequest() {
                Customer = new CreateCustomerRequest() {
                    Name = "Vitor de Andrade"
                },
                Items = new List<CreateOrderItemRequest>() {
                    new CreateOrderItemRequest() {
                        Amount = 100,
                        Description = "SDK Test Item",
                        Quantity = 1
                    }
                },
                Payment = new CreatePaymentRequest() {
                    PaymentMethod = paymentMethod
                },
                Shipping = new CreateShippingRequest() {
                    Amount = 100,
                    Description = "Frete expresso",
                    RecipientName = "Vitor",
                    RecipientPhone = "21999044903",
                    Address = new CreateAddressRequest() {
                        City = "City",
                        Complement = "Complement",
                        Country = "BR",
                        Neighborhood = "Neighborhood",
                        Number = "123",
                        State = "RJ",
                        Street = "Street",
                        ZipCode = "22221010"
                    }
                }
            };

            if(paymentMethod == "credit_card") {
                request.Payment.CreditCard = new CreateCreditCardPaymentRequest() {
                    CreditCardInfo = new CreateCreditCardRequest() {
                        Number = "4556604245849434",
                        HolderName = "VITOR DE ANDRADE",
                        Cvv = "123",
                        ExpMonth = 12,
                        ExpYear = 21
                    },
                    StatementDescriptor = "STATEMENT TEST",
                    Installments = 3
                };
            }

            return request;
        }

    }
}
