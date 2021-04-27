using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System;
using System.Security.Permissions;
using ASMXinSharePointEr.CASService;

namespace ASMXinSharePointEr.UsingCasService
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class UsingCasService : SPItemEventReceiver
    {
        private readonly CASService.IntegrationService_UserSoap casService = new 
            IntegrationService_UserSoapClient();
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
        }
    }
}