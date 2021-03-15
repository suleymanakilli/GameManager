using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    abstract class CampaignManager
    {


        public abstract string CampaignName { get; }
        



        /*public string getCampaignName()
        {
            return CampaignName;
        }*/
        public abstract double DiscountedPrice(GameObject gameObject);
        public abstract void Update(double discountRate, List<ILoggerService> loggerServices);
    }
}
