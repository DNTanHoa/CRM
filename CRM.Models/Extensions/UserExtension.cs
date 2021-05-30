using CRM.SharedUltilities.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Extensions
{
    public static class UserExtension
    {
        public static void SetPassword(this User user)
        {
            if (string.IsNullOrEmpty(user.hashKey))
            {
                user.hashKey = Guid.NewGuid().ToString();
            }

            user.password = SecurityHelpers.Encrypt(user.hashKey, user.password);
        }
    }
}
