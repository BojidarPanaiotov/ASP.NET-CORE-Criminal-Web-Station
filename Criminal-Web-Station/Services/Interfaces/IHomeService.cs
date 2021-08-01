﻿using Criminal_Web_Station.Services.Models;
using System.Collections.Generic;

namespace Criminal_Web_Station.Services.Interfaces
{
    public interface IHomeService
    {
        int GetItemsCount();
        int GetAccountsCount();
        IEnumerable<T> TopThreeItems<T>();
        HomeServiceModel GetMainContext();
    }
}
