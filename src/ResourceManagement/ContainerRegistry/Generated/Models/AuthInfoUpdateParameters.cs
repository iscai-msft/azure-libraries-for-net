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
    using System.Linq;

    /// <summary>
    /// The authorization properties for accessing the source code repository.
    /// </summary>
    public partial class AuthInfoUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the AuthInfoUpdateParameters class.
        /// </summary>
        public AuthInfoUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthInfoUpdateParameters class.
        /// </summary>
        /// <param name="tokenType">The type of Auth token. Possible values
        /// include: 'PAT', 'OAuth'</param>
        /// <param name="token">The access token used to access the source
        /// control provider.</param>
        /// <param name="refreshToken">The refresh token used to refresh the
        /// access token.</param>
        /// <param name="scope">The scope of the access token.</param>
        /// <param name="expiresIn">Time in seconds that the token remains
        /// valid</param>
        public AuthInfoUpdateParameters(string tokenType = default(string), string token = default(string), string refreshToken = default(string), string scope = default(string), int? expiresIn = default(int?))
        {
            TokenType = tokenType;
            Token = token;
            RefreshToken = refreshToken;
            Scope = scope;
            ExpiresIn = expiresIn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of Auth token. Possible values include:
        /// 'PAT', 'OAuth'
        /// </summary>
        [JsonProperty(PropertyName = "tokenType")]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or sets the access token used to access the source control
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the refresh token used to refresh the access token.
        /// </summary>
        [JsonProperty(PropertyName = "refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the scope of the access token.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets time in seconds that the token remains valid
        /// </summary>
        [JsonProperty(PropertyName = "expiresIn")]
        public int? ExpiresIn { get; set; }

    }
}
