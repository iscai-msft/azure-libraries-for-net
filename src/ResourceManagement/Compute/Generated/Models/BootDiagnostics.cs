// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Boot Diagnostics is a debugging feature which allows you to view
    /// Console Output and Screenshot to diagnose VM status.
    /// &lt;br&gt;&lt;br&gt; You can easily view the output of your console
    /// log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of
    /// the VM from the hypervisor.
    /// </summary>
    public partial class BootDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the BootDiagnostics class.
        /// </summary>
        public BootDiagnostics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BootDiagnostics class.
        /// </summary>
        /// <param name="enabled">Whether boot diagnostics should be enabled on
        /// the Virtual Machine.</param>
        /// <param name="storageUri">Uri of the storage account to use for
        /// placing the console output and screenshot.</param>
        public BootDiagnostics(bool? enabled = default(bool?), string storageUri = default(string))
        {
            Enabled = enabled;
            StorageUri = storageUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether boot diagnostics should be enabled on the
        /// Virtual Machine.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets uri of the storage account to use for placing the
        /// console output and screenshot.
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; set; }

    }
}
