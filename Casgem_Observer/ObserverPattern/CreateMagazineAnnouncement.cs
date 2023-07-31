using Casgem_Observer.DAL;

namespace Casgem_Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine="Spor Dergisi",
                Content="Spor derginizin Ağustos 2023 sayısı bayinize geldi"
            });
            context.SaveChanges();
        }
    }
}
