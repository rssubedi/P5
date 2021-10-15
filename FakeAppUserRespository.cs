using System.Collections.Generic;

namespace P5
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> _Users;

        public FakeAppUserRepository()
        {
            _Users = new Dictionary<string, AppUser>();
            _Users.Add("rajeepsubedi", new AppUser
            {
                UserName = "rajeepsubedi",
                Password = "password",
                FirstName = "Rajeep",
                LastName = "Subedi",
                EmailAddress = "rajeep.subedi@trojans.dsu.edu",
                IsAuthenticated = false
            });
        }
        public bool Login(string UserName, string Password)
        {
            bool match = false;
            AppUser User;
            if (_Users.TryGetValue(UserName, out User))
            {
                match = User.Password == Password;
            }
            return match;
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            _Users[UserName].IsAuthenticated = IsAuthenticated;
        }
        public List<AppUser> GetAll()
        {
            List<AppUser> appUsers = new List<AppUser>();
            foreach (AppUser User in _Users.Values)
            {
                appUsers.Add(User);
            }
            return appUsers;
        }
        public AppUser GetByUserName(string UserName)
        {
            AppUser curUser;
            try
            {
                curUser = _Users[UserName];
            }
            catch
            {
                curUser = null;
            }
            return curUser;
        }
    }
}
