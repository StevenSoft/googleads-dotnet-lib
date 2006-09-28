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
    [System.Web.Services.WebServiceBindingAttribute(Name="KeywordToolServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v6")]
    public class KeywordToolService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
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
        public KeywordToolService() {
            this.Url = "https://adwords.google.com/api/adwords/v6/KeywordToolService";
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("getKeywordVariationsResponse", Namespace="https://adwords.google.com/api/adwords/v6")]
        public getKeywordVariationsResponse getKeywordVariations([System.Xml.Serialization.XmlElementAttribute("getKeywordVariations", Namespace="https://adwords.google.com/api/adwords/v6")] getKeywordVariations getKeywordVariations1) {
            object[] results = this.Invoke("getKeywordVariations", new object[] {
                        getKeywordVariations1});
            return ((getKeywordVariationsResponse)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetKeywordVariations(getKeywordVariations getKeywordVariations1, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getKeywordVariations", new object[] {
                        getKeywordVariations1}, callback, asyncState);
        }
        
        /// <remarks/>
        public getKeywordVariationsResponse EndgetKeywordVariations(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((getKeywordVariationsResponse)(results[0]));
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
        [return: System.Xml.Serialization.XmlElementAttribute("getKeywordsFromSiteReturn")]
        public SiteKeywordGroups getKeywordsFromSite(string url, bool includeLinkedPages, [System.Xml.Serialization.XmlElementAttribute("languages")] string[] languages, [System.Xml.Serialization.XmlElementAttribute("countries")] string[] countries) {
            object[] results = this.Invoke("getKeywordsFromSite", new object[] {
                        url,
                        includeLinkedPages,
                        languages,
                        countries});
            return ((SiteKeywordGroups)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetKeywordsFromSite(string url, bool includeLinkedPages, string[] languages, string[] countries, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getKeywordsFromSite", new object[] {
                        url,
                        includeLinkedPages,
                        languages,
                        countries}, callback, asyncState);
        }
        
        /// <remarks/>
        public SiteKeywordGroups EndgetKeywordsFromSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SiteKeywordGroups)(results[0]));
        }
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class getKeywordVariations {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("seedKeywords")]
        public SeedKeyword[] seedKeywords;
        
        /// <remarks/>
        public bool useSynonyms;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("languages")]
        public string[] languages;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("countries")]
        public string[] countries;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class SeedKeyword {
        
        /// <remarks/>
        public bool negative;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool negativeSpecified;
        
        /// <remarks/>
        public string text;
        
        /// <remarks/>
        public KeywordType type;
    }
    

    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class SiteKeyword {
        
        /// <remarks/>
        public int advertiserCompetitionScale;
        
        /// <remarks/>
        public int groupId;
        
        /// <remarks/>
        public int searchVolumeScale;
        
        /// <remarks/>
        public string text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class SiteKeywordGroups {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("groups")]
        public string[] groups;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("keywords")]
        public SiteKeyword[] keywords;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class KeywordVariation {
        
        /// <remarks/>
        public int advertiserCompetitionScale;
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public int searchVolumeScale;
        
        /// <remarks/>
        public string text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class KeywordVariations {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalToConsider", IsNullable=true)]
        public KeywordVariation[] additionalToConsider;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("moreSpecific", IsNullable=true)]
        public KeywordVariation[] moreSpecific;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v6")]
    public class getKeywordVariationsResponse {
        
        /// <remarks/>
        public KeywordVariations getKeywordVariationsReturn;
    }
}
