// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A backend pool is a collection of backends that can be routed to.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackendPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the BackendPool class.
        /// </summary>
        public BackendPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendPool class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="backends">The set of backends for this pool</param>
        /// <param name="loadBalancingSettings">Load balancing settings for a
        /// backend pool</param>
        /// <param name="healthProbeSettings">L7 health probe settings for a
        /// backend pool</param>
        /// <param name="resourceState">Resource status. Possible values
        /// include: 'Creating', 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Deleting'</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public BackendPool(string id = default(string), IList<Backend> backends = default(IList<Backend>), SubResource loadBalancingSettings = default(SubResource), SubResource healthProbeSettings = default(SubResource), string resourceState = default(string), string name = default(string), string type = default(string))
            : base(id)
        {
            Backends = backends;
            LoadBalancingSettings = loadBalancingSettings;
            HealthProbeSettings = healthProbeSettings;
            ResourceState = resourceState;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of backends for this pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.backends")]
        public IList<Backend> Backends { get; set; }

        /// <summary>
        /// Gets or sets load balancing settings for a backend pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingSettings")]
        public SubResource LoadBalancingSettings { get; set; }

        /// <summary>
        /// Gets or sets L7 health probe settings for a backend pool
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthProbeSettings")]
        public SubResource HealthProbeSettings { get; set; }

        /// <summary>
        /// Gets or sets resource status. Possible values include: 'Creating',
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; set; }

        /// <summary>
        /// Gets or sets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}