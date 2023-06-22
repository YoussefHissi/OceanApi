using System.Collections.Generic;

namespace OceanApi.Models
{
    public class UserConstant
    {
        public static List<Usermodel> Users = new List<Usermodel>
        {
            new Usermodel { Username = "Youssef", EmailAddress = "hissiyoussef194@gmail.com", Password = "123", Role = "Admin" },
            new Usermodel { Username = "samir", EmailAddress = "hissisamir194@gmail.com", Password = "123", Role = "User" },
            new Usermodel { Username = "nassim", EmailAddress = "hissinassim194@gmail.com", Password = "123", Role = "User" },
            new Usermodel { Username = "khalid", EmailAddress = "hissikhalid194@gmail.com", Password = "123", Role = "Admin" }
        };
    }
}
