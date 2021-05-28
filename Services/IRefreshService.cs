using System;
using System.Threading.Tasks;

namespace Surveymatic.Services
{

    public interface IRefreshService
    {

        public event Action RefreshRequested;
        public void CallRequestRefresh();


    }

    public class RefreshService : IRefreshService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}