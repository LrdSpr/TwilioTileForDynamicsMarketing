// <auto-generated />

using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace CJTwilioTile.Plugins.ProxyClasses
{
    [EntityLogicalNameAttribute("msdyncrm_customerjourneycustomchannelactivity")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XrmToolkit", "4.0")]
    [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
    public partial class CustomChannelActivity : BaseProxyClass
    {
        public new const string LogicalName = "msdyncrm_customerjourneycustomchannelactivity";
        public const int ObjectTypeCode = 10487;
        public const string PrimaryIdAttribute = "msdyncrm_customerjourneycustomchannelactivityid";
        public const string PrimaryNameAttribute = "msdyncrm_name";
        
        static CustomChannelActivity()
        {
            BaseProxyClass.RegisterProxyType(typeof(CustomChannelActivity), "msdyncrm_customerjourneycustomchannelactivity");
            _textOptions = new Dictionary<string, eTextOptions>();
            _numberOptions = new Dictionary<string, eNumberOptions>();
            _errorStrings = new Dictionary<string, string>();
            TextError = "The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.";
            NumberError = "The value for attribute '{0}' must be between {2} and {3}. The value is {1}";
        }
        public CustomChannelActivity() : base(new Entity("msdyncrm_customerjourneycustomchannelactivity")) { }
        public CustomChannelActivity(Entity original) : base(original) { }
        public static string GetLogicalName() { return BaseProxyClass.GetLogicalName<CustomChannelActivity>(); }
        /// <summary>
        /// Action to perform when the string value is greater than the allowed length.
        /// <para>This is the default for any string attribute in this Entity</para>
        /// </summary>
        public static eTextOptions TextOptions { get; set; }
        private static Dictionary<string, eTextOptions> _textOptions;
        /// <summary>
        /// Use this to set an action and error string when a value is greater than the allowed length
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater than the allowed length</param>
        /// <param name="errorString">Optional: Error to throw if the eTextOptions == ThrowError
        /// <para>If nothing is specified then the 'TextError' string is used.</para>
        /// <para>You may use the following parameters:</para>
        /// <para>{0} = Attribute Logical Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Length</para>
        /// <para>{3} = Max Length</para>
        /// </param>
        public static void SetTextOptions(string logicalName, eTextOptions options, string errorString = null)
        {
            if (_textOptions.ContainsKey(logicalName)) { _textOptions[logicalName] = options; }
            else { _textOptions.Add(logicalName, options); }
            if (!string.IsNullOrEmpty(errorString))
            {
                if (_errorStrings.ContainsKey(logicalName)) { _errorStrings[logicalName] = errorString; }
                else { _errorStrings.Add(logicalName, errorString); }
            }
            else if (_errorStrings.ContainsKey(logicalName)) { _errorStrings.Remove(logicalName); }
        }
        protected override eTextOptions GetTextOptions(string logicalName)
        {
            if (_textOptions.ContainsKey(logicalName)) { return _textOptions[logicalName]; }
            return TextOptions;
        }
        /// <summary>
        /// Action to perform when the number value is greater or less than the allowed value.
        /// <para>This is the default for any int, decimal, double, or money attribute in this Entity</para>
        /// </summary>
        public static eNumberOptions NumberOptions { get; set; }
        private static Dictionary<string, eNumberOptions> _numberOptions;
        /// <summary>
        /// Use this to set an action and error string when a value is greater or less than the allowed value
        /// </summary>
        /// <param name="logicalName">Name of Attribute</param>
        /// <param name="options">Action to perform when the value is greater or less than the allowed value</param>
        /// <param name="errorString">Optional: Error to throw if the eNumberOptions == ThrowError
        /// <para>If nothing is specified then the 'NumberError' string is used.</para>
        /// <para>You may use the following parameters:</para>
        /// <para>{0} = Attribute Logical Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Min Value</para>
        /// <para>{3} = Max Value</para>
        /// </param>
        public static void SetNumberOptions(string logicalName, eNumberOptions options, string errorString = null)
        {
            if (_numberOptions.ContainsKey(logicalName)) { _numberOptions[logicalName] = options; }
            else { _numberOptions.Add(logicalName, options); }
            if (!string.IsNullOrEmpty(errorString))
            {
                if (_errorStrings.ContainsKey(logicalName)) { _errorStrings[logicalName] = errorString; }
                else { _errorStrings.Add(logicalName, errorString); }
            }
            else if (_errorStrings.ContainsKey(logicalName)) { _errorStrings.Remove(logicalName); }
        }
        protected override eNumberOptions GetNumberOptions(string logicalName)
        {
            if (_numberOptions.ContainsKey(logicalName)) { return _numberOptions[logicalName]; }
            return NumberOptions;
        }
        private static Dictionary<string, string> _errorStrings;
        protected override string GetErrorString(string attributeName, BaseProxyClass.eErrorType defaultErrorType)
        {
            if (_errorStrings.ContainsKey(attributeName))
            {
                return _errorStrings[attributeName];
            }
            return defaultErrorType == BaseProxyClass.eErrorType.Text ? TextError : NumberError;
        }
        /// <summary>
        /// <para>Default error string is: The value for attribute '{0}' cannot be longer than {3} characters. The length of the value is {2} characters.</para>
        /// <para>You may use the following parameters</para>
        /// <para>{0} = Attribute Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Length</para>
        /// <para>{3} = Max Length</para>
        /// </summary>
        public static string TextError { get; set; }
        /// <summary>
        /// <para>Default error string is: The value for attribute '{0}' must be between {2} and {3}. The value is {1}.</para>
        /// <para>You may use the following parameters</para>
        /// <para>{0} = Attribute Name</para>
        /// <para>{1} = Value</para>
        /// <para>{2} = Min Value</para>
        /// <para>{3} = Max Value</para>
        /// </summary>
        public static string NumberError { get; set; }

        ///<summary>
///<para>Logical Name: createdonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
public string CreatedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("createdonbehalfbyyominame"); }
}
///<summary>
///<para>Logical Name: msdyncrm_customerjourneyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_customerjourneyname")]
public string Msdyncrm_CustomerJourneyName
{
	get { return this.GetPropertyValue<string>("msdyncrm_customerjourneyname"); }
}
///<summary>
///<para>Logical Name: owneridname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("owneridname")]
public string OwnerIdName
{
	get { return this.GetPropertyValue<string>("owneridname"); }
}
///<summary>
///<para>Logical Name: msdyncrm_customerjourneyiterationname</para>
///<para>Max Length: 256 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_customerjourneyiterationname")]
public string Msdyncrm_CustomerJourneyIterationName
{
	get { return this.GetPropertyValue<string>("msdyncrm_customerjourneyiterationname"); }
}
///<summary>
///<para>Logical Name: msdyncrm_contactyominame</para>
///<para>Max Length: 450 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_contactyominame")]
public string Msdyncrm_ContactYomiName
{
	get { return this.GetPropertyValue<string>("msdyncrm_contactyominame"); }
}
///<summary>
///<para>Logical Name: modifiedbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyyominame")]
public string ModifiedByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedbyyominame"); }
}
///<summary>
///<para>Logical Name: createdbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyyominame")]
public string CreatedByYomiName
{
	get { return this.GetPropertyValue<string>("createdbyyominame"); }
}
///<summary>
///<para>Logical Name: msdyncrm_contactname</para>
///<para>Max Length: 160 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_contactname")]
public string Msdyncrm_ContactName
{
	get { return this.GetPropertyValue<string>("msdyncrm_contactname"); }
}
///<summary>
///<para>Logical Name: modifiedbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedbyname")]
public string ModifiedByName
{
	get { return this.GetPropertyValue<string>("modifiedbyname"); }
}
///<summary>
///<para>Logical Name: owneridtype</para>
///</summary>
[AttributeLogicalNameAttribute("owneridtype")]
public string OwnerIdType
{
	get { return this.GetPropertyValue<string>("owneridtype"); }
	set { this.SetPropertyValue<string>("owneridtype", value, "OwnerIdType"); }
}
///<summary>
///<para>Logical Name: owneridyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("owneridyominame")]
public string OwnerIdYomiName
{
	get { return this.GetPropertyValue<string>("owneridyominame"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfbyyominame</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
public string ModifiedOnBehalfByYomiName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyyominame"); }
}
///<summary>
///<para>Logical Name: createdbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdbyname")]
public string CreatedByName
{
	get { return this.GetPropertyValue<string>("createdbyname"); }
}
///<summary>
///<para>Logical Name: createdonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfbyname")]
public string CreatedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("createdonbehalfbyname"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfbyname</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
public string ModifiedOnBehalfByName
{
	get { return this.GetPropertyValue<string>("modifiedonbehalfbyname"); }
}
///<summary>
///<para>Logical Name: msdyncrm_activityid</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_activityid")]
public string ActivityID
{
	get { return this.GetPropertyValue<string>("msdyncrm_activityid"); }
	set { this.SetPropertyValue("msdyncrm_activityid", value, 100, "ActivityID"); }
}
///<summary>
///<para>Logical Name: msdyncrm_contact</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_contact")]
public EntityReference Contact
{
	get { return this.GetPropertyValue<EntityReference>("msdyncrm_contact"); }
	set { this.SetPropertyValue<EntityReference>("msdyncrm_contact", value, "Contact"); }
}
///<summary>
///<para>Logical Name: createdby</para>
///</summary>
[AttributeLogicalNameAttribute("createdby")]
public EntityReference CreatedBy
{
	get { return this.GetPropertyValue<EntityReference>("createdby"); }
}
///<summary>
///<para>Logical Name: createdonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("createdonbehalfby")]
public EntityReference CreatedBy_delegate
{
	get { return this.GetPropertyValue<EntityReference>("createdonbehalfby"); }
}
///<summary>
///<para>Logical Name: createdon</para>
///</summary>
[AttributeLogicalNameAttribute("createdon")]
public DateTime? CreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("createdon"); }
}
///<summary>
///<para>Key Property (Uniqueidentifier)</para>
///<para>Logical Name: msdyncrm_customerjourneycustomchannelactivityid</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_customerjourneycustomchannelactivityid")]
public Guid CustomChannelActivityId
{
	get
	{
		return base.Id;
	}
	set
	{
		base.Id = value;
		base.SetPropertyValue("msdyncrm_customerjourneycustomchannelactivityid", value, "CustomChannelActivityId");
	}
}
///<summary>
///<para>Logical Name: msdyncrm_customerjourney</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_customerjourney")]
public EntityReference CustomerJourney
{
	get { return this.GetPropertyValue<EntityReference>("msdyncrm_customerjourney"); }
	set { this.SetPropertyValue<EntityReference>("msdyncrm_customerjourney", value, "CustomerJourney"); }
}
///<summary>
///<para>Logical Name: msdyncrm_customerjourneyiteration</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_customerjourneyiteration")]
public EntityReference CustomerJourneyIteration
{
	get { return this.GetPropertyValue<EntityReference>("msdyncrm_customerjourneyiteration"); }
	set { this.SetPropertyValue<EntityReference>("msdyncrm_customerjourneyiteration", value, "CustomerJourneyIteration"); }
}
///<summary>
///<para>Logical Name: msdyncrm_entityid</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_entityid")]
public string EntityID
{
	get { return this.GetPropertyValue<string>("msdyncrm_entityid"); }
	set { this.SetPropertyValue("msdyncrm_entityid", value, 100, "EntityID"); }
}
///<summary>
///<para>Logical Name: msdyncrm_entitytype</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_entitytype")]
public string EntityType
{
	get { return this.GetPropertyValue<string>("msdyncrm_entitytype"); }
	set { this.SetPropertyValue("msdyncrm_entitytype", value, 100, "EntityType"); }
}
///<summary>
///<para>Logical Name: importsequencenumber</para>
///<para>Minimum Value: -2147483648</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("importsequencenumber")]
public int? ImportSequenceNumber
{
	get { return this.GetPropertyValue<int?>("importsequencenumber"); }
	set { this.SetPropertyValue("importsequencenumber", (int?)value, (int)-2147483648, (int)2147483647, "ImportSequenceNumber"); }
}
///<summary>
///<para>Logical Name: modifiedby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedby")]
public EntityReference ModifiedBy
{
	get { return this.GetPropertyValue<EntityReference>("modifiedby"); }
}
///<summary>
///<para>Logical Name: modifiedonbehalfby</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedonbehalfby")]
public EntityReference ModifiedBy_delegate
{
	get { return this.GetPropertyValue<EntityReference>("modifiedonbehalfby"); }
}
///<summary>
///<para>Logical Name: modifiedon</para>
///</summary>
[AttributeLogicalNameAttribute("modifiedon")]
public DateTime? ModifiedOn
{
	get { return this.GetPropertyValue<DateTime?>("modifiedon"); }
}
///<summary>
///<para>Logical Name: msdyncrm_name</para>
///<para>Max Length: 100 characters</para>
///</summary>
[AttributeLogicalNameAttribute("msdyncrm_name")]
public string Name
{
	get { return this.GetPropertyValue<string>("msdyncrm_name"); }
	set { this.SetPropertyValue("msdyncrm_name", value, 100, "Name"); }
}
///<summary>
///<para>Logical Name: ownerid</para>
///</summary>
[AttributeLogicalNameAttribute("ownerid")]
public EntityReference Owner
{
	get { return this.GetPropertyValue<EntityReference>("ownerid"); }
	set { this.SetPropertyValue<EntityReference>("ownerid", value, "Owner"); }
}
///<summary>
///<para>Logical Name: owningbusinessunit</para>
///</summary>
[AttributeLogicalNameAttribute("owningbusinessunit")]
public EntityReference OwningBusinessUnit
{
	get { return this.GetPropertyValue<EntityReference>("owningbusinessunit"); }
}
///<summary>
///<para>Logical Name: owningteam</para>
///</summary>
[AttributeLogicalNameAttribute("owningteam")]
public EntityReference OwningTeam
{
	get { return this.GetPropertyValue<EntityReference>("owningteam"); }
}
///<summary>
///<para>Logical Name: owninguser</para>
///</summary>
[AttributeLogicalNameAttribute("owninguser")]
public EntityReference OwningUser
{
	get { return this.GetPropertyValue<EntityReference>("owninguser"); }
}
///<summary>
///<para>Logical Name: overriddencreatedon</para>
///</summary>
[AttributeLogicalNameAttribute("overriddencreatedon")]
public DateTime? RecordCreatedOn
{
	get { return this.GetPropertyValue<DateTime?>("overriddencreatedon"); }
	set { this.SetPropertyValue<DateTime?>("overriddencreatedon", value, "RecordCreatedOn"); }
}
/// <summary>
///Logical Name: statecode
/// </summary>
[AttributeLogicalNameAttribute("statecode")]
public eStatus? Status
{
	get
	{
		if (Status_OptionSetValue != null) { return (eStatus)Status_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.Status_OptionSetValue = new OptionSetValue((int)value); }
		else this.Status_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: statecode</para>
///</summary>
[AttributeLogicalNameAttribute("statecode")]
public OptionSetValue Status_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("statecode"); }
	set { this.SetPropertyValue<OptionSetValue>("statecode", value, "Status_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string Status_Text(IOrganizationService Service)
{
	return this.Status_OptionSetValue.GetOptionSetText(Service, this, "statecode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string Status_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.Status_OptionSetValue.Value);
}
/// <summary>
///Logical Name: statuscode
/// </summary>
[AttributeLogicalNameAttribute("statuscode")]
public eStatusReason? StatusReason
{
	get
	{
		if (StatusReason_OptionSetValue != null) { return (eStatusReason)StatusReason_OptionSetValue.Value; }
		return null;
	}
	set
	{
		if (value != null) { this.StatusReason_OptionSetValue = new OptionSetValue((int)value); }
		else this.StatusReason_OptionSetValue = null;
	}
}
///<summary>
///<para>Logical Name: statuscode</para>
///</summary>
[AttributeLogicalNameAttribute("statuscode")]
public OptionSetValue StatusReason_OptionSetValue
{
	get { return this.GetPropertyValue<OptionSetValue>("statuscode"); }
	set { this.SetPropertyValue<OptionSetValue>("statuscode", value, "StatusReason_OptionSetValue"); }
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="Service">CRM Organization Service</param>
/// <returns></returns>
public string StatusReason_Text(IOrganizationService Service)
{
	return this.StatusReason_OptionSetValue.GetOptionSetText(Service, this, "statuscode");
}
/// <summary>
/// Retrieves the current value's text in the user's language.
/// </summary>
/// <param name="AttributeMetadata">The attribute metadata previously retrieved using the 'GetAttributeMetadata' extension method on the IOrganizationService object.</param>
/// <returns></returns>
public string StatusReason_Text(EnumAttributeMetadata AttributeMetadata)
{
	return AttributeMetadata.GetOptionSetText(this.StatusReason_OptionSetValue.Value);
}
///<summary>
///<para>Logical Name: timezoneruleversionnumber</para>
///<para>Minimum Value: -1</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("timezoneruleversionnumber")]
public int? Time_zoneRuleVersionNumber
{
	get { return this.GetPropertyValue<int?>("timezoneruleversionnumber"); }
	set { this.SetPropertyValue("timezoneruleversionnumber", (int?)value, (int)-1, (int)2147483647, "Time_zoneRuleVersionNumber"); }
}
///<summary>
///<para>Logical Name: utcconversiontimezonecode</para>
///<para>Minimum Value: -1</para>
///<para>Maximum Value: 2147483647</para>
///</summary>
[AttributeLogicalNameAttribute("utcconversiontimezonecode")]
public int? UTCConversionTime_zoneCode
{
	get { return this.GetPropertyValue<int?>("utcconversiontimezonecode"); }
	set { this.SetPropertyValue("utcconversiontimezonecode", (int?)value, (int)-1, (int)2147483647, "UTCConversionTime_zoneCode"); }
}
///<summary>
///<para>Logical Name: versionnumber</para>
///</summary>
[AttributeLogicalNameAttribute("versionnumber")]
public int? VersionNumber
{
	get { return this.GetPropertyValue<int?>("versionnumber"); }
}


        /// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_AsyncOperations</para>
/// </summary>
public List<Entity> GetSystemJobs (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_AsyncOperations</para>
/// </summary>
public List<Entity> GetSystemJobs (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "asyncoperation", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_BulkDeleteFailures</para>
/// </summary>
public List<Entity> GetBulkDeleteFailures (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_BulkDeleteFailures</para>
/// </summary>
public List<Entity> GetBulkDeleteFailures (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "bulkdeletefailure", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_DuplicateBaseRecord</para>
/// </summary>
public List<Entity> GetDuplicateRecords (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_DuplicateBaseRecord</para>
/// </summary>
public List<Entity> GetDuplicateRecords (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "duplicaterecord", "baserecordid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_DuplicateMatchingRecord</para>
/// </summary>
public List<Entity> GetDuplicateRecords2 (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_DuplicateMatchingRecord</para>
/// </summary>
public List<Entity> GetDuplicateRecords2 (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "duplicaterecord", "duplicaterecordid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_MailboxTrackingFolders</para>
/// </summary>
public List<Entity> GetMailboxAutoTrackingFolders (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_MailboxTrackingFolders</para>
/// </summary>
public List<Entity> GetMailboxAutoTrackingFolders (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "mailboxtrackingfolder", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<Entity> GetFieldSharing (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_PrincipalObjectAttributeAccesses</para>
/// </summary>
public List<Entity> GetFieldSharing (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "principalobjectattributeaccess", "objectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_ProcessSession</para>
/// </summary>
public List<Entity> GetProcessSessions (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_ProcessSession</para>
/// </summary>
public List<Entity> GetProcessSessions (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "processsession", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_SyncErrors</para>
/// </summary>
public List<Entity> GetSyncErrors (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_SyncErrors</para>
/// </summary>
public List<Entity> GetSyncErrors (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "syncerror", "regardingobjectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_UserEntityInstanceDatas</para>
/// </summary>
public List<Entity> GetUserEntityInstanceData (IOrganizationService Service, params string[] Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "userentityinstancedata", "objectid", Columns); }
/// <summary>
/// <para><b>Entity ()</b></para>
/// <para>Schema Name: msdyncrm_customerjourneycustomchannelactivity_UserEntityInstanceDatas</para>
/// </summary>
public List<Entity> GetUserEntityInstanceData (IOrganizationService Service, ColumnSet Columns) { return BaseProxyClass.GetRelatedOneToManyEntities(Service, this.Id, "userentityinstancedata", "objectid", Columns); }


        

        

        public enum eStatus
{
	///<summary><para>Active</para>
	///<para>Value = 0</para></summary>
	[Description("Active")]
	Active = 0, 
	///<summary><para>Inactive</para>
	///<para>Value = 1</para></summary>
	[Description("Inactive")]
	Inactive = 1
}
public enum eStatusReason
{
	///<summary><para>Active</para>
	///<para>Value = 1</para></summary>
	[Description("Active")]
	Active_Active = 1, 
	///<summary><para>Inactive</para>
	///<para>Value = 2</para></summary>
	[Description("Inactive")]
	Inactive_Inactive = 2
}
public void SetState(IOrganizationService Service, eStatus State, eStatusReason Status)
{
	Service.SetState(this, (int)State, (int)Status);
}
public async System.Threading.Tasks.Task SetStateAsync(IOrganizationService Service, eStatus State, eStatusReason Status)
{
	 await Service.SetStateAsync(this, (int)State, (int)Status);
}


        public static class Properties
{
	/// <summary><para>createdonbehalfbyyominame</para>
	/// <para>createdonbehalfbyyominame</para></summary>
	public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
	/// <summary><para>msdyncrm_customerjourneyname</para>
	/// <para>msdyncrm_customerjourneyname</para></summary>
	public const string Msdyncrm_CustomerJourneyName = "msdyncrm_customerjourneyname";
	/// <summary><para>owneridname</para>
	/// <para>owneridname</para></summary>
	public const string OwnerIdName = "owneridname";
	/// <summary><para>msdyncrm_customerjourneyiterationname</para>
	/// <para>msdyncrm_customerjourneyiterationname</para></summary>
	public const string Msdyncrm_CustomerJourneyIterationName = "msdyncrm_customerjourneyiterationname";
	/// <summary><para>msdyncrm_contactyominame</para>
	/// <para>msdyncrm_contactyominame</para></summary>
	public const string Msdyncrm_ContactYomiName = "msdyncrm_contactyominame";
	/// <summary><para>modifiedbyyominame</para>
	/// <para>modifiedbyyominame</para></summary>
	public const string ModifiedByYomiName = "modifiedbyyominame";
	/// <summary><para>createdbyyominame</para>
	/// <para>createdbyyominame</para></summary>
	public const string CreatedByYomiName = "createdbyyominame";
	/// <summary><para>msdyncrm_contactname</para>
	/// <para>msdyncrm_contactname</para></summary>
	public const string Msdyncrm_ContactName = "msdyncrm_contactname";
	/// <summary><para>modifiedbyname</para>
	/// <para>modifiedbyname</para></summary>
	public const string ModifiedByName = "modifiedbyname";
	/// <summary><para>owneridtype</para>
	/// <para>owneridtype</para></summary>
	public const string OwnerIdType = "owneridtype";
	/// <summary><para>owneridyominame</para>
	/// <para>owneridyominame</para></summary>
	public const string OwnerIdYomiName = "owneridyominame";
	/// <summary><para>modifiedonbehalfbyyominame</para>
	/// <para>modifiedonbehalfbyyominame</para></summary>
	public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
	/// <summary><para>createdbyname</para>
	/// <para>createdbyname</para></summary>
	public const string CreatedByName = "createdbyname";
	/// <summary><para>createdonbehalfbyname</para>
	/// <para>createdonbehalfbyname</para></summary>
	public const string CreatedOnBehalfByName = "createdonbehalfbyname";
	/// <summary><para>modifiedonbehalfbyname</para>
	/// <para>modifiedonbehalfbyname</para></summary>
	public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
	/// <summary><para>Activity ID</para>
	/// <para>msdyncrm_activityid</para></summary>
	public const string ActivityID = "msdyncrm_activityid";
	/// <summary><para>Contact</para>
	/// <para>msdyncrm_contact</para></summary>
	public const string Contact = "msdyncrm_contact";
	/// <summary><para>Created by</para>
	/// <para>createdby</para></summary>
	public const string CreatedBy = "createdby";
	/// <summary><para>Created by (delegate)</para>
	/// <para>createdonbehalfby</para></summary>
	public const string CreatedBy_delegate = "createdonbehalfby";
	/// <summary><para>Created on</para>
	/// <para>createdon</para></summary>
	public const string CreatedOn = "createdon";
	/// <summary><para>Custom channel activity</para>
	/// <para>msdyncrm_customerjourneycustomchannelactivityid</para></summary>
	public const string CustomChannelActivityId = "msdyncrm_customerjourneycustomchannelactivityid";
	/// <summary><para>Customer journey</para>
	/// <para>msdyncrm_customerjourney</para></summary>
	public const string CustomerJourney = "msdyncrm_customerjourney";
	/// <summary><para>Customer journey iteration</para>
	/// <para>msdyncrm_customerjourneyiteration</para></summary>
	public const string CustomerJourneyIteration = "msdyncrm_customerjourneyiteration";
	/// <summary><para>Entity ID</para>
	/// <para>msdyncrm_entityid</para></summary>
	public const string EntityID = "msdyncrm_entityid";
	/// <summary><para>Entity type</para>
	/// <para>msdyncrm_entitytype</para></summary>
	public const string EntityType = "msdyncrm_entitytype";
	/// <summary><para>Import sequence number</para>
	/// <para>importsequencenumber</para></summary>
	public const string ImportSequenceNumber = "importsequencenumber";
	/// <summary><para>Modified by</para>
	/// <para>modifiedby</para></summary>
	public const string ModifiedBy = "modifiedby";
	/// <summary><para>Modified by (delegate)</para>
	/// <para>modifiedonbehalfby</para></summary>
	public const string ModifiedBy_delegate = "modifiedonbehalfby";
	/// <summary><para>Modified on</para>
	/// <para>modifiedon</para></summary>
	public const string ModifiedOn = "modifiedon";
	/// <summary><para>Name</para>
	/// <para>msdyncrm_name</para></summary>
	public const string Name = "msdyncrm_name";
	/// <summary><para>Owner</para>
	/// <para>ownerid</para></summary>
	public const string Owner = "ownerid";
	/// <summary><para>Owning business unit</para>
	/// <para>owningbusinessunit</para></summary>
	public const string OwningBusinessUnit = "owningbusinessunit";
	/// <summary><para>Owning team</para>
	/// <para>owningteam</para></summary>
	public const string OwningTeam = "owningteam";
	/// <summary><para>Owning user</para>
	/// <para>owninguser</para></summary>
	public const string OwningUser = "owninguser";
	/// <summary><para>Record created on</para>
	/// <para>overriddencreatedon</para></summary>
	public const string RecordCreatedOn = "overriddencreatedon";
	/// <summary><para>Status</para>
	/// <para>statecode</para></summary>
	public const string Status = "statecode";
	/// <summary><para>Status reason</para>
	/// <para>statuscode</para></summary>
	public const string StatusReason = "statuscode";
	/// <summary><para>Time-zone rule version number</para>
	/// <para>timezoneruleversionnumber</para></summary>
	public const string Time_zoneRuleVersionNumber = "timezoneruleversionnumber";
	/// <summary><para>UTC conversion time-zone code</para>
	/// <para>utcconversiontimezonecode</para></summary>
	public const string UTCConversionTime_zoneCode = "utcconversiontimezonecode";
	/// <summary><para>Version Number</para>
	/// <para>versionnumber</para></summary>
	public const string VersionNumber = "versionnumber";
}

    }
}