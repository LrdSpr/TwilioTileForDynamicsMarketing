using CJTwilioTile.Plugins.ProxyClasses;
using Microsoft.Xrm.Sdk;
using System;

namespace CJTwilioTile.Plugins
{
    public class CJTWilioProcessSMS : IPlugin
    {

        public static string ContentSettings = "11f0389d-9ad7-e711-a94a-000d3a31a55c";

        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = 
                (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = 
                (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);
            var inputParams = context.InputParameters;
            if (inputParams.Contains("Target") 
                && inputParams["Target"] != null 
                && inputParams["Target"] is Entity)
            {
                var targetEntity = ((Entity)(inputParams["Target"])).ToEntity<CustomChannelActivity>();
                if (targetEntity != null 
                    && targetEntity.Contact != null
                    && targetEntity.EntityID != null
                    && targetEntity.EntityType != null)
                {
                    if (targetEntity.EntityType == TwilioSMSTemplate.LogicalName)
                    {
                        TwilioSMSTemplate template = 
                            (TwilioSMSTemplate)service.Retrieve
                            (targetEntity.EntityType, 
                            new Guid(targetEntity.EntityID), 
                            new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<TwilioSMSTemplate>();

                        Contact recipient =  (Contact)service.Retrieve
                            (targetEntity.Contact.LogicalName,
                            targetEntity.Contact.Id,
                            new Microsoft.Xrm.Sdk.Query.ColumnSet("mobilephone")).ToEntity<Contact>(); ;

                        OrganizationRequest req = new OrganizationRequest("msdyncrm_ResolveMessageTemplate");
                        req.Parameters.Add("ContactId", targetEntity.Contact.Id.ToString());
                        req.Parameters.Add("ContentSettingsId", ContentSettings);
                        req.Parameters.Add("HtmlContent", template.SMSTemplate);
                        var response = service.Execute(req).Results["ResolvedMessageResult"];

                        var messageResponse = JsonUtils.Deserialize<MessageResponse>((string)response);

                        TwilioSMSAction SMSAction = new TwilioSMSAction();
                        SMSAction.Name = Guid.NewGuid().ToString();
                        SMSAction.SMSMessage = messageResponse.MessagePreview.HtmlPart;
                        SMSAction.MobilePhone = recipient.MobilePhone;
                        SMSAction.Contact = new EntityReference(targetEntity.Contact.LogicalName, targetEntity.Contact.Id);
                        SMSAction.HasIncomingMessages = false;

                        service.Create(SMSAction);
                    }
                }
            }
        }
    }
}
