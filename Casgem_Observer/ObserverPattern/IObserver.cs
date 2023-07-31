using Casgem_Observer.DAL;

namespace Casgem_Observer.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
