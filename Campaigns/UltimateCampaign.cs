using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    
    class UltimateCampaign : CampaignManager
    {
        public double DiscountRate;
        public double discountedPrice;
        public UltimateCampaign()
        {
            DiscountRate = 0.80;
        }
        public override string CampaignName
        {
            get
            {
                return "Ultimate Campaing";
            }
        }

        public override double DiscountedPrice(GameObject gameObject)
        {
            return discountedPrice = gameObject.Price - (gameObject.Price * DiscountRate);
        }

        public override void Update(double discountRate, List<ILoggerService> loggerServices)
        {
            double tmpDiscountRate = DiscountRate;
            DiscountRate = discountRate;
            Console.WriteLine("Previous Discount Rate : " + tmpDiscountRate + " \nCurrent Discount Rate : " + DiscountRate);
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
        }
    }
}
