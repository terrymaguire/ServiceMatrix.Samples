using System;
using NServiceBus;
using OnlineSales.Internal.Commands.Sales;


namespace OnlineSales.Sales
{
    public partial class SubmitOrderHandler
    {
		
        partial void HandleImplementation(SubmitOrder message)
        {
            // TODO: SubmitOrderHandler: Add code to handle the SubmitOrder message.
            Console.WriteLine("Sales received " + message.GetType().Name + " from " + message.CustomerName);

            var orderAccepted = new OnlineSales.Contracts.Sales.OrderAccepted();
            Bus.Publish(orderAccepted);
        }

    }
}
