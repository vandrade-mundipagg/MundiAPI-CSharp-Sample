using MundiAPI.PCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample.Builders {
    internal static class PlanBuilders {

        internal static CreatePlanRequest BuildCreatePlanRequest() {
            var request = new CreatePlanRequest() {
                BillingType = "prepaid",
                PaymentMethods = new List<string> { "credit_card", "boleto" },
                Name = "Nome do plano",
                Items = new List<CreatePlanItemRequest>() {
                    new CreatePlanItemRequest() {
                        Description = "Plan Item Test SDK",
                        Name = "Item",
                        Quantity = 1,
                        PricingScheme = new CreatePricingSchemeRequest() {
                            Price = 100,
                            SchemeType = "unit"
                        }
                    }
                }
            };
            return request;
        }

        internal static UpdatePlanRequest BuildUpdatePlanRequest() {
            var request = new UpdatePlanRequest() {
                BillingType = "postpaid",
                Metadata = new Dictionary<string, string>() {
                    { "update", "plan" }
                },
                Name = "Novo nome",
                PaymentMethods = new List<string> { "credit_card" },
                Currency = "BRL",
                Interval = "month",
                IntervalCount = 1,
                Status = "active"
            };
            return request;
        }

        internal static CreatePlanItemRequest BuildCreatePlanItemRequest() {
            var request = new CreatePlanItemRequest() {
                Name = "Novo item",
                Description = "Descrição do novo item",
                Quantity = 1,
                PricingScheme = new CreatePricingSchemeRequest() {
                    Price = 200,
                    SchemeType = "unit"
                }
            };
            return request;
        }

        internal static UpdatePlanItemRequest BuildUpdatePlanItemRequest() {
            var request = new UpdatePlanItemRequest() {
                Name = "Novo item atualizado",
                Description = "Nova descrição",
                Quantity = 2,
                PricingScheme = new UpdatePricingSchemeRequest() {
                    SchemeType = "unit",
                    Price = 300
                },
                Status = "active"
            };
            return request;
        }

    }
}
