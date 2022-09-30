using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.Concrete
{
    public class TumControl
    {
        BakiyeControl bakiyeControl = new BakiyeControl();
        LimitControl limitControl = new LimitControl();
        PuanControl puanControl = new PuanControl();
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);
            bool eligible = true;
            // Check creditworthyness of applicant
            if (!bakiyeControl.BakiyeYeterliMi(cust, amount))
            {
                eligible = false;
            }
            else if (!limitControl.LimitYeterliMi(cust))
            {
                eligible = false;
            }
            else if (!puanControl.PuanYeterliMi(cust))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
