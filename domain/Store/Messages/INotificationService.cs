﻿namespace Store.Messages
{
    public interface INotificationService
    {
        void SendConfirmationCode(string cellPhone, int code);

        void StrtProcces(Order order);
    }
}
