// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The workflow trigger filter.
    /// </summary>
    public partial class WorkflowTriggerFilter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerFilter class.
        /// </summary>
        public WorkflowTriggerFilter() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerFilter class.
        /// </summary>
        public WorkflowTriggerFilter(WorkflowState? state = default(WorkflowState?))
        {
            State = state;
        }

        /// <summary>
        /// Gets or sets the state of workflow trigger. Possible values
        /// include: 'NotSpecified', 'Completed', 'Enabled', 'Disabled',
        /// 'Deleted', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public WorkflowState? State { get; set; }

    }
}
