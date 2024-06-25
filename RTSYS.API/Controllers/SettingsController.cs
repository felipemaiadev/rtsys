using Microsoft.AspNetCore.Mvc;


namespace RTSYS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
    

        private static readonly User[] Users = new[]
        {
                new User
                {
                    name = "Felipe maia",
                    age = 36,
                    birth = new DateTime(1988,06,02),
                    lastlogin = DateTime.Now.Ticks
                },

                 new User
                {
                    name = "Jose Martines",
                    age = 29,
                    birth = new DateTime(1981,01,15),
                    lastlogin = DateTime.Now.Ticks
                },


};

        private readonly ILogger<SettingsController> _logger;

        public SettingsController(ILogger<SettingsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUsersList")]
        public IEnumerable<User> Get()
        {
            return Users.ToList();
        }
    }
}
