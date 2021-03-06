// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the list activity operation.
    /// </summary>
    public partial class ActivityListResponse : OperationResponseWithSkipToken
    {
        private IList<Activity> _activities;
        
        /// <summary>
        /// Optional. Gets or sets a list of activities.
        /// </summary>
        public IList<Activity> Activities
        {
            get { return this._activities; }
            set { this._activities = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ActivityListResponse class.
        /// </summary>
        public ActivityListResponse()
        {
            this.Activities = new LazyList<Activity>();
        }
    }
}
