using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    internal static class SubscriptionBuilders {

        internal static CreateSubscriptionRequest BuildCreateSubscriptionByPlanRequest(string planId) {
            var request = new CreateSubscriptionRequest() {
                PlanId = planId,
                Customer = new CreateCustomerRequest() {
                    Name = "Vitor",
                    Email = "vandrade@mundipagg.com"
                },
                CreditCard = new CreateCreditCardRequest() {
                    Number = "4556604245849434",
                    HolderName = "VITOR DE ANDRADE",
                    Cvv = "123",
                    ExpMonth = 12,
                    ExpYear = 21,
                    Brand = "Visa",
                },
                PaymentMethod = "credit_card"
            };

            return request;

        }

        internal static CreateSubscriptionRequest BuildCreateSubscriptionRequest() {
            var request = new CreateSubscriptionRequest() {
                Items = new List<CreateSubscriptionItemRequest>() {
                    new CreateSubscriptionItemRequest() {
                        Description = "Descrição",
                        Quantity = 1,
                        PricingScheme = new CreatePricingSchemeRequest() {
                            Price = 100,
                            SchemeType = "unit"
                        }
                    }
                },
                BillingType = "prepaid",
                Setup = new CreateSetupRequest() {
                    Amount = 100,
                    Description = "Descrição",
                    Payment = new CreatePaymentRequest() {
                        CreditCard = new CreateCreditCardPaymentRequest() {
                            Capture = true,
                            CreditCardInfo = new CreateCreditCardRequest() {
                                Number = "4556604245849434",
                                HolderName = "VITOR DE ANDRADE",
                                Cvv = "123",
                                ExpMonth = 12,
                                ExpYear = 21,
                                Brand = "Visa",
                            }
                        },
                        PaymentMethod = "credit_card"
                    }
                },
                Customer = new CreateCustomerRequest() {
                    Name = "Vitor",
                    Email = "vandrade@mundipagg.com"
                },
                CreditCard = new CreateCreditCardRequest() {
                    Number = "4556604245849434",
                    HolderName = "VITOR DE ANDRADE",
                    Cvv = "123",
                    ExpMonth = 12,
                    ExpYear = 21,
                    Brand = "Visa",
                },
                PaymentMethod = "credit_card"
            };

            return request;
        }

        internal static CreateSubscriptionItemRequest BuildCreateSubscriptionItemRequest() {
            var request = new CreateSubscriptionItemRequest() {
                Description = "Novo item",
                Quantity = 1,
                PricingScheme = new CreatePricingSchemeRequest() {
                    SchemeType = "volume",
                    PriceBrackets = new List<CreatePriceBracketRequest>() {
                        new CreatePriceBracketRequest() {
                            StartQuantity = 0,
                            Price = 100
                        }
                    }
                }
            };

            return request;
        }

        internal static UpdateSubscriptionItemRequest BuildUpdateSubscriptionItemRequest() {
            var request = new UpdateSubscriptionItemRequest() {
                Description = "Novo item atualizado",
                Quantity = 2,
                PricingScheme = new UpdatePricingSchemeRequest() {
                    SchemeType = "tier",
                    PriceBrackets = new List<UpdatePriceBracketRequest>() {
                        new UpdatePriceBracketRequest() {
                            StartQuantity = 0,
                            Price = 200
                        }
                    }
                },
                Status = "active"
            };

            return request;
        }

        internal static CreateUsageRequest BuildCreateUsageRequest() {
            var request = new CreateUsageRequest() {
                Quantity = 10,
                Description = "usou",
                UsedAt = DateTime.UtcNow
            };

            return request;
        }

        internal static CreateDiscountRequest BuildCreateDiscountOnItemRequest(string subscriptionItemId) {
            var request = new CreateDiscountRequest() {
                Value = 100,
                Cycles = 1,
                DiscountType = "percentage",
                ItemId = subscriptionItemId
            };

            return request;
        }

        internal static CreateDiscountRequest BuildCreateDiscountRequest() {
            var request = new CreateDiscountRequest() {
                Value = 100,
                Cycles = 1,
                DiscountType = "flat"
            };

            return request;

        }

        internal static UpdateSubscriptionPaymentMethodRequest BuildUpdateSubscriptionPaymentMethodRequest() {
            var request = new UpdateSubscriptionPaymentMethodRequest() {
                PaymentMethod = "boleto"
            };

            return request;
        }

        internal static UpdateSubscriptionCreditCardRequest BuildUpdateSubscriptionCreditCardRequest() {
            var request = new UpdateSubscriptionCreditCardRequest() {
                CreditCard = new CreateCreditCardRequest() {
                    Number = "4556604245849434",
                    HolderName = "VITOR DE ANDRADE",
                    Cvv = "123",
                    ExpMonth = 12,
                    ExpYear = 21,
                    Brand = "Visa",
                }
            };

            return request;
        }

        internal static UpdateSubscriptionBillingDateRequest BuildUpdateSubscriptionBillingDateRequest() {
            var request = new UpdateSubscriptionBillingDateRequest() {
                NextBillingAt = new DateTime(2017, 05, 01)
            };
            return request;
        }
    }
}
