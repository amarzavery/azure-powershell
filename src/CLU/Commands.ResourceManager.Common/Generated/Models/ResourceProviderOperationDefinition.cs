// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource provider operation information.
    /// </summary>
    public partial class ResourceProviderOperationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDefinition class.
        /// </summary>
        public ResourceProviderOperationDefinition() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderOperationDefinition class.
        /// </summary>
        public ResourceProviderOperationDefinition(string name = default(string), ResourceProviderOperationDisplayProperties display = default(ResourceProviderOperationDisplayProperties))
        {
            Name = name;
            Display = display;
        }

        /// <summary>
        /// Gets or sets the provider operation name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display property of the provider operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ResourceProviderOperationDisplayProperties Display { get; set; }

    }
}
