using ExerciseInterface.Entities;

namespace ExerciseInterface.Services
{
    internal class ContractService
    {
        IOnlinePaymentService OnlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            OnlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            for (int i = 1; i <= months; i++)
            {
                double amount = OnlinePaymentService.interest(contract.TotalValue / months, i);
                amount += OnlinePaymentService.PaymentFee(amount);

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i), amount));
            }
        }
    }
}