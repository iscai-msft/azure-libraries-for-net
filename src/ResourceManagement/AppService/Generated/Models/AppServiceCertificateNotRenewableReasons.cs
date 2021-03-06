// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for AppServiceCertificateNotRenewableReasons.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<AppServiceCertificateNotRenewableReasons>))]
    public class AppServiceCertificateNotRenewableReasons : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<AppServiceCertificateNotRenewableReasons>
    {
        public static readonly AppServiceCertificateNotRenewableReasons RegistrationStatusNotSupportedForRenewal = Parse("RegistrationStatusNotSupportedForRenewal");
        public static readonly AppServiceCertificateNotRenewableReasons ExpirationNotInRenewalTimeRange = Parse("ExpirationNotInRenewalTimeRange");
        public static readonly AppServiceCertificateNotRenewableReasons SubscriptionNotActive = Parse("SubscriptionNotActive");
    }
}
