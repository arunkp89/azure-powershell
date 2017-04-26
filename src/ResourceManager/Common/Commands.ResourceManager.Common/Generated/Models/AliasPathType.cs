// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using Azure;
    using Management;
    using Internal;
    using Resources;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The type of the paths for alias.
    /// </summary>
    public partial class AliasPathType
    {
        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        public AliasPathType() { }

        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        /// <param name="path">The path of an alias.</param>
        /// <param name="apiVersions">The API versions.</param>
        public AliasPathType(string path = default(string), IList<string> apiVersions = default(IList<string>))
        {
            Path = path;
            ApiVersions = apiVersions;
        }

        /// <summary>
        /// Gets or sets the path of an alias.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the API versions.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

    }
}

