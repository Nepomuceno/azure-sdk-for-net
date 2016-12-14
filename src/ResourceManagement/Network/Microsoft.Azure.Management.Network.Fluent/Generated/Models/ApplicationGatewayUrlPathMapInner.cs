// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// UrlPathMap of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayUrlPathMapInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayUrlPathMapInner class.
        /// </summary>
        public ApplicationGatewayUrlPathMapInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayUrlPathMapInner class.
        /// </summary>
        /// <param name="defaultBackendAddressPool">Default backend address
        /// pool resource of URL path map </param>
        /// <param name="defaultBackendHttpSettings">Default backend http
        /// settings resource of URL path map </param>
        /// <param name="pathRules">Path rule of URL path map resource</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayUrlPathMapInner(string id = default(string), Microsoft.Azure.Management.Resource.Fluent.SubResource defaultBackendAddressPool = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), Microsoft.Azure.Management.Resource.Fluent.SubResource defaultBackendHttpSettings = default(Microsoft.Azure.Management.Resource.Fluent.SubResource), System.Collections.Generic.IList<ApplicationGatewayPathRuleInner> pathRules = default(System.Collections.Generic.IList<ApplicationGatewayPathRuleInner>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            DefaultBackendAddressPool = defaultBackendAddressPool;
            DefaultBackendHttpSettings = defaultBackendHttpSettings;
            PathRules = pathRules;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets default backend address pool resource of URL path map
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultBackendAddressPool")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource DefaultBackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets default backend http settings resource of URL path
        /// map
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultBackendHttpSettings")]
        public Microsoft.Azure.Management.Resource.Fluent.SubResource DefaultBackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets path rule of URL path map resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.pathRules")]
        public System.Collections.Generic.IList<ApplicationGatewayPathRuleInner> PathRules { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}