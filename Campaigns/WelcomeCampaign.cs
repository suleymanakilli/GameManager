using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProgrammingGameBackend
{
    class WelcomeCampaign : CampaignManager
    {
        public double DiscountRate;
        public double discountedPrice;
        public WelcomeCampaign()
        {
            DiscountRate = 0.20;
        }
        
        public override string CampaignName
        {
            get
            {
                return "Welcome Campaign";
            }
        }
       

        public override double DiscountedPrice(GameObject gameObject)
        {
            return discountedPrice= gameObject.Price - (gameObject.Price * DiscountRate);
            
        //gameObject.Price = gameObject.Price-(gameObject.Price * DiscountRate);
        }

        public override void Update(double discountRate,List<ILoggerService> loggerServices)
        {
            double tmpDiscountRate = DiscountRate;
            DiscountRate = discountRate;
            Console.WriteLine("Previous Discount Rate : "+tmpDiscountRate+" \nCurrent Discount Rate : "+DiscountRate);
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
            
        }
    }
}
