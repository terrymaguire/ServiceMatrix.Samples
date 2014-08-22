using System;
using NServiceBus;
using OnlineSales.Internal.Commands.Billing;
using OnlineSales.Contracts.Sales;
using OnlineSales.Internal.Messages.Billing;
using NServiceBus.Saga;


namespace OnlineSales.Billing
{
    public partial class OrderAcceptedHandler
    {
        public override void ConfigureHowToFindSaga()
        {
            
            // ConfigureMapping<SubmitPaymentResponse>(m => /* specify message property */).ToSaga(s =>  /* specify saga property */ );

            
            // If you add new messages to be handled by your saga, you will need to manually add a call to ConfigureMapping for them.
        }
    }
}
