// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of a request to get container registry quota usages.
    /// </summary>
    public partial class RegistryUsageListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the RegistryUsageListResultInner
        /// class.
        /// </summary>
        public RegistryUsageListResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryUsageListResultInner
        /// class.
        /// </summary>
        /// <param name="value">The list of container registry quota
        /// usages.</param>
        public RegistryUsageListResultInner(IList<RegistryUsage> value = default(IList<RegistryUsage>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of container registry quota usages.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<RegistryUsage> Value { get; set; }

    }
}
