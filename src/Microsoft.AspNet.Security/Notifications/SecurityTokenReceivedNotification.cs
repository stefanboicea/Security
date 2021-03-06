// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


namespace Microsoft.AspNet.Security.Notifications
{
    public class SecurityTokenReceivedNotification
    {
        public SecurityTokenReceivedNotification()
        {
        }

        public bool Cancel { get; set; }
        public string SecurityToken { get; set; }
    }
}