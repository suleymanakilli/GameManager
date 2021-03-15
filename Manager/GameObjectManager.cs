using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    class GameObjectManager
    {
        public void Buy(User user, GameObject gameObject,List<ILoggerService> loggerServices,CampaignManager campaignManager=null)
        {
            if (campaignManager != null)
            {
                double withoutDiscount = gameObject.Price;
                campaignManager.DiscountedPrice(gameObject);
                double withDiscount = campaignManager.DiscountedPrice(gameObject);
                double discountAmount = withoutDiscount - withDiscount;
                Console.WriteLine(user.Name + " bought " + gameObject.Name+" with "+campaignManager.CampaignName+" and paid only "+string.Format("{0:0.00}",withDiscount) +" and saved "+ string.Format("{0:0.00}\n", discountAmount));
            }
            else { 
                Console.WriteLine(user.Name + " bought " + gameObject.Name+" and paid "+ string.Format("{0:0.00}\n", gameObject.Price)); 
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }

        }
    }
}
