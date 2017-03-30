using CSharp_Sample.Builders;
using CSharp_Sample.Clients;
using CSharp_Sample.Helpers;
using MundiAPI.PCL;
using MundiAPI.PCL.Exceptions;
using MundiAPI.PCL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Sample
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Program Start");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = BuildClient();

            //Criar + Atualizar + Obter
            Console.WriteLine("Criar + Atualizar + Obter");
            var customerId = CustomersClient.CreateCustomer(client);
            CustomersClient.UpdateCustomer(client, customerId);
            CustomersClient.GetCustomer(client, customerId);

            //Listar
            Console.WriteLine("Listar");
            CustomersClient.GetCustomers(client);

            Console.WriteLine("Program End");

        }

        static void RunChargesClient(IMundiAPIClient client) {
            //Criação + cancelamento total
            Console.WriteLine("Create + Cancel");
            var chargeId = ChargesClient.CreateCardCharge(client);
            ChargesClient.CancelCharge(client, chargeId);

            //Criação + cancelamento parcial
            Console.WriteLine("Create + Partial Cancel");
            chargeId = ChargesClient.CreateCardCharge(client);
            ChargesClient.CancelCharge(client, chargeId);

            //Criação com boleto
            Console.WriteLine("Boleto");
            ChargesClient.CreateBoletoCharge(client);

            //NotAuthorized + troca de cartão
            Console.WriteLine("NotAuthorized + Change Card");
            chargeId = ChargesClient.CreateCardNotAuthorizedCharge(client);
            ChargesClient.ChangeCard(client, chargeId);

            //NotAuthorized + troca para boleto
            Console.WriteLine("NotAuthorized + Change Payment");
            chargeId = ChargesClient.CreateCardNotAuthorizedCharge(client);
            ChargesClient.ChangePaymentMethod(client, chargeId);

            //Pre autorização + Captura
            Console.WriteLine("PreAuth + Capture");
            chargeId = ChargesClient.CreateChargePreAuth(client);
            ChargesClient.CaptureCharge(client, chargeId);

            //Consulta
            ChargesClient.GetCharge(client, chargeId);
            ChargesClient.GetCharges(client);
        }

        static void RunOrdersClient(IMundiAPIClient client) {
            //Criação + Consulta
            Console.WriteLine("Criação + consulta");
            var orderId = OrdersClient.CreateCardOrder(client);
            OrdersClient.GetOrder(client, orderId);

            //Listagem
            Console.WriteLine("Listagem");
            OrdersClient.GetOrders(client);
        }

        static IMundiAPIClient BuildClient()
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "sk_test_jY7RoLcM2Bd6VLWH"; // The username to use with basic authentication
            string basicAuthPassword = ""; // The password to use with basic authentication

            IMundiAPIClient client = new MundiAPIClient(basicAuthUserName, basicAuthPassword);

            return client;
        }

    }
}
