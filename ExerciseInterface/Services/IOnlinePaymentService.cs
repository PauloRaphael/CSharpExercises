using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInterface.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(Double amount);
        public double interest(Double amount, int months);
    }
}
