using HoliDayRental.BLL.Models;
using Microsoft.AspNetCore.Http;

namespace HoliDayRental.Infrastructure.Helpers
{
    public class SessionManager
    {
        private readonly ISession _session;
        public SessionManager(HttpContext httpContext)
        {
            _session = httpContext.Session;
        }

        public bool? IsConnected
        {   
            get => _session.GetObjectFromJson<bool>("IsConnected");
            set => _session.SetObjectAsJson("IsConnected", value);
        }

        public MembreModel ConnectedUser
        {
            get => _session.GetObjectFromJson<MembreModel>("ConnectedUser");
            set => _session.SetObjectAsJson("ConnectedUser", value);
        }
    }
}
