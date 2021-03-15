using System;
using System.Collections.Generic;

namespace ProgrammingGameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject gameObject1 = new GameObject() {ID=1,Name="Sport Car",Price=154.80 };
            GameObject gameObject2 = new GameObject() { ID = 2, Name = "Gun", Price = 15.80 };
            GameObject gameObject3 = new GameObject() { ID = 3, Name = "Village", Price = 245.80 };

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();

            User user1 = new User() {ID=1,Name="Süleyman",Surname="AKILLI",BirthYear=2000,TC="12345678910" };
            Console.WriteLine("--------------------------");
            User user2 = new User() { ID = 2, Name = "Mehmet",Surname="Koçak", BirthYear = 1995,TC="21345678910"};
            Console.WriteLine("--------------------------");
            User user3 = new User() { ID = 3, Name = "Ali", Surname="Yılmaz",BirthYear = 1968 ,TC="32145678910"};
            Console.WriteLine("--------------------------");
            User user4 = new User() { ID = 4, Name = "Nail",Surname="Solak", BirthYear = 2005,TC="43215678910" };
            Console.WriteLine("--------------------------");

            UserManager userManager = new UserManager();
            userManager.Add(user1, new List<ILoggerService> { fileLoggerService, dataBaseLoggerService});
            Console.WriteLine("--------------------------");
            userManager.Add(user2, new List<ILoggerService> { fileLoggerService});
            Console.WriteLine("--------------------------");
            userManager.Add(user3, new List<ILoggerService> { dataBaseLoggerService, fileLoggerService });
            Console.WriteLine("--------------------------");
            userManager.Add(user4, new List<ILoggerService> { dataBaseLoggerService, fileLoggerService });
            Console.WriteLine("--------------------------");

            userManager.Delete(user4, new List<ILoggerService> { dataBaseLoggerService, fileLoggerService });
            Console.WriteLine("--------------------------");

            userManager.Update(user2, new List<ILoggerService> { fileLoggerService },"Furkan",40);
            Console.WriteLine("--------------------------");
            Console.WriteLine("User 2 Name : "+user2.Name+"\n"+"User 2 Age : "+user2.BirthYear+"\n");
            Console.WriteLine("--------------------------");

            CampaignManager welcomeCampaign = new WelcomeCampaign();
            CampaignManager bestSellerCampaign = new BestSellerCampaign();
            CampaignManager ultimateCampaign = new UltimateCampaign();
            
            

            GameObjectManager gameObjectManager = new GameObjectManager();
            Console.WriteLine("\n\n\n");
            gameObjectManager.Buy(user1, gameObject3, new List<ILoggerService> { dataBaseLoggerService }, ultimateCampaign);
            Console.WriteLine("--------------------------");
            gameObjectManager.Buy(user3, gameObject2, new List<ILoggerService> { fileLoggerService, dataBaseLoggerService },welcomeCampaign);
            Console.WriteLine("--------------------------");
            gameObjectManager.Buy(user2, gameObject1, new List<ILoggerService> { fileLoggerService }, bestSellerCampaign);
            Console.WriteLine("--------------------------");
            gameObjectManager.Buy(user1, gameObject1, new List<ILoggerService> { dataBaseLoggerService });
            Console.WriteLine("--------------------------");


        }
    }
}
