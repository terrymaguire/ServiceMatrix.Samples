using System;
using NServiceBus;
using OnlineSales.Contracts.Sales;


namespace OnlineSales.Billing
{
    public partial class OrderAcceptedHandler
    {
		
        partial void HandleImplementation(OrderAccepted message)
        {
            // TODO: OrderAcceptedHandler: Add code to handle the OrderAccepted message.
            Console.WriteLine("Billing received " + message.GetType().Name);

            Console.WriteLine("Configuring the Submit Payment Message");

            var submitPayment = new OnlineSales.Internal.Commands.Billing.SubmitPayment();
            Bus.Send(submitPayment);
        }

        partial void HandleImplementation(Internal.Messages.Billing.SubmitPaymentResponse message)
        {
            Console.WriteLine("Payment Processed " + message.GetType().Name);
        }

        partial void AllMessagesReceived()
        {
            Console.WriteLine("All messages received. Completing the Saga.");
            MarkAsComplete();
        }
    }
}
