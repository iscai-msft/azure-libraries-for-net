// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery Image Definition that you want
    /// to create or update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryImageInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageInner class.
        /// </summary>
        public GalleryImageInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageInner class.
        /// </summary>
        /// <param name="osType">This property allows you to specify the type
        /// of the OS that is included in the disk when creating a VM from a
        /// managed image. &lt;br&gt;&lt;br&gt; Possible values are:
        /// &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**.
        /// Possible values include: 'Windows', 'Linux'</param>
        /// <param name="osState">The allowed values for OS State are
        /// 'Generalized'. Possible values include: 'Generalized',
        /// 'Specialized'</param>
        /// <param name="description">The description of this gallery Image
        /// Definition resource. This property is updatable.</param>
        /// <param name="eula">The Eula agreement for the gallery Image
        /// Definition.</param>
        /// <param name="privacyStatementUri">The privacy statement
        /// uri.</param>
        /// <param name="releaseNoteUri">The release note uri.</param>
        /// <param name="endOfLifeDate">The end of life date of the gallery
        /// Image Definition. This property can be used for decommissioning
        /// purposes. This property is updatable.</param>
        /// <param name="provisioningState">The current state of the gallery
        /// Image Definition.</param>
        public GalleryImageInner(OperatingSystemTypes osType, OperatingSystemStateTypes osState, GalleryImageIdentifier identifier, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), string eula = default(string), string privacyStatementUri = default(string), string releaseNoteUri = default(string), System.DateTime? endOfLifeDate = default(System.DateTime?), RecommendedMachineConfiguration recommended = default(RecommendedMachineConfiguration), Disallowed disallowed = default(Disallowed), ImagePurchasePlan purchasePlan = default(ImagePurchasePlan), ProvisioningState provisioningState = default(ProvisioningState))
            : base(location, id, name, type, tags)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            OsType = osType;
            OsState = osState;
            EndOfLifeDate = endOfLifeDate;
            Identifier = identifier;
            Recommended = recommended;
            Disallowed = disallowed;
            PurchasePlan = purchasePlan;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of this gallery Image Definition
        /// resource. This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Eula agreement for the gallery Image Definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eula")]
        public string Eula { get; set; }

        /// <summary>
        /// Gets or sets the privacy statement uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacyStatementUri")]
        public string PrivacyStatementUri { get; set; }

        /// <summary>
        /// Gets or sets the release note uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.releaseNoteUri")]
        public string ReleaseNoteUri { get; set; }

        /// <summary>
        /// Gets or sets this property allows you to specify the type of the OS
        /// that is included in the disk when creating a VM from a managed
        /// image. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Windows**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Linux**. Possible values
        /// include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes OsType { get; set; }

        /// <summary>
        /// Gets or sets the allowed values for OS State are 'Generalized'.
        /// Possible values include: 'Generalized', 'Specialized'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osState")]
        public OperatingSystemStateTypes OsState { get; set; }

        /// <summary>
        /// Gets or sets the end of life date of the gallery Image Definition.
        /// This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endOfLifeDate")]
        public System.DateTime? EndOfLifeDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.identifier")]
        public GalleryImageIdentifier Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommended")]
        public RecommendedMachineConfiguration Recommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.disallowed")]
        public Disallowed Disallowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasePlan")]
        public ImagePurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// Gets the current state of the gallery Image Definition.
        /// </summary>
        /// <remarks>
        /// The provisioning state, which only appears in the response.
        /// Possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
            if (Identifier != null)
            {
                Identifier.Validate();
            }
        }
    }
}
