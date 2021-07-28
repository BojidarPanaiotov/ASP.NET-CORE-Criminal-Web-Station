﻿namespace Criminal_Web_Station.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;

    public class Account : IdentityUser
    {
        public DateTime CreatedOn { get; init; } = DateTime.Now;
        public IEnumerable<Item> Hitmans { get; init; } = new HashSet<Item>();
    }
}
