// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Azure Cosmos DB Database Service Resource Provider REST API
    /// </summary>
    public partial class CosmosDB : FluentServiceClientBase<CosmosDB>, ICosmosDB, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Azure subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Version of the API to be used with the client request. The current version
        /// is 2015-04-08.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IDatabaseAccountsOperations.
        /// </summary>
        public virtual IDatabaseAccountsOperations DatabaseAccounts { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        public virtual IDatabaseOperations Database { get; private set; }

        /// <summary>
        /// Gets the ICollectionOperations.
        /// </summary>
        public virtual ICollectionOperations Collection { get; private set; }

        /// <summary>
        /// Gets the ICollectionRegionOperations.
        /// </summary>
        public virtual ICollectionRegionOperations CollectionRegion { get; private set; }

        /// <summary>
        /// Gets the IDatabaseAccountRegionOperations.
        /// </summary>
        public virtual IDatabaseAccountRegionOperations DatabaseAccountRegion { get; private set; }

        /// <summary>
        /// Gets the IPercentileSourceTargetOperations.
        /// </summary>
        public virtual IPercentileSourceTargetOperations PercentileSourceTarget { get; private set; }

        /// <summary>
        /// Gets the IPercentileTargetOperations.
        /// </summary>
        public virtual IPercentileTargetOperations PercentileTarget { get; private set; }

        /// <summary>
        /// Gets the IPercentileOperations.
        /// </summary>
        public virtual IPercentileOperations Percentile { get; private set; }

        /// <summary>
        /// Gets the ICollectionPartitionRegionOperations.
        /// </summary>
        public virtual ICollectionPartitionRegionOperations CollectionPartitionRegion { get; private set; }

        /// <summary>
        /// Gets the ICollectionPartitionOperations.
        /// </summary>
        public virtual ICollectionPartitionOperations CollectionPartition { get; private set; }

        /// <summary>
        /// Gets the IPartitionKeyRangeIdOperations.
        /// </summary>
        public virtual IPartitionKeyRangeIdOperations PartitionKeyRangeId { get; private set; }

        /// <summary>
        /// Gets the IPartitionKeyRangeIdRegionOperations.
        /// </summary>
        public virtual IPartitionKeyRangeIdRegionOperations PartitionKeyRangeIdRegion { get; private set; }

        /// <summary>
        /// Initializes a new instance of the CosmosDB class.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public CosmosDB(RestClient restClient)
            : base(restClient)
        {
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        protected override void Initialize()
        {
            DatabaseAccounts = new DatabaseAccountsOperations(this);
            Operations = new Operations(this);
            Database = new DatabaseOperations(this);
            Collection = new CollectionOperations(this);
            CollectionRegion = new CollectionRegionOperations(this);
            DatabaseAccountRegion = new DatabaseAccountRegionOperations(this);
            PercentileSourceTarget = new PercentileSourceTargetOperations(this);
            PercentileTarget = new PercentileTargetOperations(this);
            Percentile = new PercentileOperations(this);
            CollectionPartitionRegion = new CollectionPartitionRegionOperations(this);
            CollectionPartition = new CollectionPartitionOperations(this);
            PartitionKeyRangeId = new PartitionKeyRangeIdOperations(this);
            PartitionKeyRangeIdRegion = new PartitionKeyRangeIdRegionOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2015-04-08";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
