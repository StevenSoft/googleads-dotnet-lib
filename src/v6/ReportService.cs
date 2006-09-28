﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.573.
// 
namespace com.google.api.adwords.v6 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ReportServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v6")]
    public class ReportService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public password passwordValue;
        
        public useragent useragentValue;
        
        public token tokenValue;
        
        public applicationToken applicationTokenValue;
        
        public developerToken developerTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        /// <remarks/>
        public ReportService() {
            this.Url = "https://adwords.google.com/api/adwords/v6/ReportService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("scheduleReportJobReturn")]
        public long scheduleReportJob(ReportJob job) {
            object[] results = this.Invoke("scheduleReportJob", new object[] {
                        job});
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginscheduleReportJob(ReportJob job, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("scheduleReportJob", new object[] {
                        job}, callback, asyncState);
        }
        
        /// <remarks/>
        public long EndscheduleReportJob(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((long)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getReportJobStatusReturn")]
        public ReportJobStatus getReportJobStatus(long reportJobId) {
            object[] results = this.Invoke("getReportJobStatus", new object[] {
                        reportJobId});
            return ((ReportJobStatus)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetReportJobStatus(long reportJobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getReportJobStatus", new object[] {
                        reportJobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public ReportJobStatus EndgetReportJobStatus(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReportJobStatus)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getReportDownloadUrlReturn")]
        public string getReportDownloadUrl(long reportJobId) {
            object[] results = this.Invoke("getReportDownloadUrl", new object[] {
                        reportJobId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetReportDownloadUrl(long reportJobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getReportDownloadUrl", new object[] {
                        reportJobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndgetReportDownloadUrl(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getGzipReportDownloadUrlReturn")]
        public string getGzipReportDownloadUrl(long reportJobId) {
            object[] results = this.Invoke("getGzipReportDownloadUrl", new object[] {
                        reportJobId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetGzipReportDownloadUrl(long reportJobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getGzipReportDownloadUrl", new object[] {
                        reportJobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndgetGzipReportDownloadUrl(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllJobsReturn")]
        public ReportJob[] getAllJobs() {
            object[] results = this.Invoke("getAllJobs", new object[0]);
            return ((ReportJob[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAllJobs(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllJobs", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public ReportJob[] EndgetAllJobs(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ReportJob[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v6", ResponseNamespace="https://adwords.google.com/api/adwords/v6", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void deleteReport(long reportJobId) {
            this.Invoke("deleteReport", new object[] {
                        reportJobId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BegindeleteReport(long reportJobId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("deleteReport", new object[] {
                        reportJobId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EnddeleteReport(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdImageReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AccountReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UrlReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdTextReportJob))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordReportJob))]
    public abstract class ReportJob {
        
        /// <remarks/>
        public AggregationType aggregationType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregationTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clientEmails")]
        public string[] clientEmails;
        
        /// <remarks/>
        public bool crossClient;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool crossClientSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime endDay;
        
        /// <remarks/>
        public long id;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified;
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime startDay;
        
        /// <remarks/>
        public ReportJobStatus status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum AggregationType {
        
        /// <remarks/>
        Summary,
        
        /// <remarks/>
        Daily,
        
        /// <remarks/>
        Monthly,
        
        /// <remarks/>
        Quarterly,
        
        /// <remarks/>
        Yearly,
        
        /// <remarks/>
        HourlyRegardlessDate,
        
        /// <remarks/>
        HourlyByDate,
        
        /// <remarks/>
        Weekly,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum ReportJobStatus {
        
        /// <remarks/>
        Pending,
        
        /// <remarks/>
        InProgress,
        
        /// <remarks/>
        Completed,
        
        /// <remarks/>
        Failed,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class AdImageReportJob : ReportJob {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class AdGroupReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("adGroupStatuses")]
        public AdGroupStatus[] adGroupStatuses;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum AdWordsType {
        
        /// <remarks/>
        SearchOnly,
        
        /// <remarks/>
        ContentOnly,
    }
    
 
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class AccountReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class CampaignReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class CustomReportJob : ReportJob {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("adGroupStatuses")]
        public AdGroupStatus[] adGroupStatuses;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("adGroups")]
        public int[] adGroups;
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaignStatuses")]
        public CampaignStatus[] campaignStatuses;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customOptions")]
        public CustomReportOption[] customOptions;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywordStatuses")]
        public KeywordStatus[] keywordStatuses;
        
        /// <remarks/>
        public KeywordType keywordType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keywordTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public string[] keywords;
        
        /// <remarks/>
        public bool includeZeroImpression;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeZeroImpressionSpecified;
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum CustomReportOption {
        
        /// <remarks/>
        Clicks,
        
        /// <remarks/>
        Impressions,
        
        /// <remarks/>
        Ctr,
        
        /// <remarks/>
        Cpc,
        
        /// <remarks/>
        Cost,
        
        /// <remarks/>
        MinimumCpc,
        
        /// <remarks/>
        MaximumCpc,
        
        /// <remarks/>
        DailyBudget,
        
        /// <remarks/>
        AveragePosition,
        
        /// <remarks/>
        DescriptionLine1,
        
        /// <remarks/>
        DescriptionLine2,
        
        /// <remarks/>
        DescriptionLine3,
        
        /// <remarks/>
        VisibleUrl,
        
        /// <remarks/>
        CreativeStatus,
        
        /// <remarks/>
        Conversions,
        
        /// <remarks/>
        ConversionRate,
        
        /// <remarks/>
        CostPerConversion,
        
        /// <remarks/>
        Transactions,
        
        /// <remarks/>
        CostPerTransaction,
        
        /// <remarks/>
        TotalConversionValue,
        
        /// <remarks/>
        AverageConversionValue,
        
        /// <remarks/>
        ConversionValuePerCost,
        
        /// <remarks/>
        ConversionValuePerClick,
        
        /// <remarks/>
        SaleCount,
        
        /// <remarks/>
        SaleValue,
        
        /// <remarks/>
        LeadCount,
        
        /// <remarks/>
        LeadValue,
        
        /// <remarks/>
        SignupCount,
        
        /// <remarks/>
        SignupValue,
        
        /// <remarks/>
        PageViewCount,
        
        /// <remarks/>
        PageViewValue,
        
        /// <remarks/>
        DefaultConversionCount,
        
        /// <remarks/>
        DefaultConversionValue,
        
        /// <remarks/>
        Campaign,
        
        /// <remarks/>
        AdGroup,
        
        /// <remarks/>
        Keyword,
        
        /// <remarks/>
        KeywordType,
        
        /// <remarks/>
        KeywordStatus,
        
        /// <remarks/>
        AdWordsType,
        
        /// <remarks/>
        AdGroupStatus,
        
        /// <remarks/>
        AccountName,
        
        /// <remarks/>
        CampaignStatus,
        
        /// <remarks/>
        CampaignEndDate,
        
        /// <remarks/>
        CreativeDestinationUrl,
        
        /// <remarks/>
        KeywordDestinationUrl,
        
        /// <remarks/>
        DestinationUrl,
        
        /// <remarks/>
        CampaignId,
        
        /// <remarks/>
        AdGroupId,
        
        /// <remarks/>
        KeywordId,
        
        /// <remarks/>
        CreativeId,
        
        /// <remarks/>
        ImageAdName,
        
        /// <remarks/>
        ImageHostingKey,
        
        /// <remarks/>
        CreativeType,
        
        /// <remarks/>
        BottomPosition,
        
        /// <remarks/>
        CPM,
        
        /// <remarks/>
        CustomerTimeZone,
        
        /// <remarks/>
        MaxContentCPC,
        
        /// <remarks/>
        MaximumCPM,
        
        /// <remarks/>
        TopPosition,
        
        /// <remarks/>
        Website,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public enum KeywordStatus {
        
        /// <remarks/>
        Normal,
        
        /// <remarks/>
        InTrial,
        
        /// <remarks/>
        OnHold,
        
        /// <remarks/>
        Disabled,
        
        /// <remarks/>
        Disapproved,
        
        /// <remarks/>
        Deleted,
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class UrlReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class AdTextReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class KeywordReportJob : ReportJob {
        
        /// <remarks/>
        public AdWordsType adWordsType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool adWordsTypeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("campaigns")]
        public int[] campaigns;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywordStatuses")]
        public KeywordStatus[] keywordStatuses;
        
        /// <remarks/>
        public KeywordType keywordType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keywordTypeSpecified;
        
        /// <remarks/>
        public bool includeZeroImpression;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeZeroImpressionSpecified;
    }
}
