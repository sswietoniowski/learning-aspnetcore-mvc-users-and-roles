﻿namespace learning_aspnetcore_mvc_users_and_logins.Models
{
    public class LoginVm
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public bool RememberMe { get; set; }
    }
}