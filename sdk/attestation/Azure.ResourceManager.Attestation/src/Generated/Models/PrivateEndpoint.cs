// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The Private Endpoint resource. </summary>
    internal partial class PrivateEndpoint
    {
        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        public PrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpoint. </summary>
        /// <param name="stringId"> The ARM identifier for Private Endpoint. </param>
        internal PrivateEndpoint(string stringId)
        {
            StringId = stringId;
        }

        /// <summary> The ARM identifier for Private Endpoint. </summary>
        public string StringId { get; }
    }
}
