﻿namespace banking.Service
{
    public interface IUserService
    {
        string GetUserId();

        bool IsAuthenticated();
    }
}