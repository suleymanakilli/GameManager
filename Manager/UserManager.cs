using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingGameBackend
{
    class UserManager
    {
        UserValidation _userValidation = new UserValidation();
        
        public void Add(User user, List<ILoggerService> loggerServices)
        {
            if (_userValidation.IsValid(user))
            {
                Console.WriteLine(user.Name + " : has been added\n");
                foreach (var loggerService in loggerServices)
                {
                    loggerService.log();
                }
            }
            else
            {
                Console.WriteLine("There is no person such that. Please check the informations");
            }
        }

        public void Update(User user,List<ILoggerService> loggerServices,string Name=null,int BirthYear=0)
        {
            if (Name != null || (BirthYear > 0 && BirthYear != user.BirthYear))
            {
                if (Name != null)
                {
                    user.Name = Name;
                    
                }
                if (BirthYear > 0 && BirthYear != user.BirthYear)
                {
                    user.BirthYear = BirthYear;
                    
                }
                Console.WriteLine("User ID : " + user.ID + " has been updated!");
                foreach (var loggerService in loggerServices)
                {
                    loggerService.log();
                }
                
            }
            else { Console.WriteLine("User ID : " + user.ID + " has not been updated!"); }
            

        }
        public void Delete(User user, List<ILoggerService> loggerServices)
        {
            Console.WriteLine("User ID : " + user.ID + " has been deleted!");
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
        }
    }
}
