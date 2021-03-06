// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup item.
    /// </summary>
    public partial class IaaSVMProtectableItem : WorkloadProtectableItem
    {
        /// <summary>
        /// Initializes a new instance of the IaaSVMProtectableItem class.
        /// </summary>
        public IaaSVMProtectableItem() { }

        /// <summary>
        /// Initializes a new instance of the IaaSVMProtectableItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup managemenent to
        /// backup an item.</param>
        /// <param name="friendlyName">Friendly name of the backup
        /// item.</param>
        /// <param name="protectionState">State of the back up item. Possible
        /// values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected'</param>
        /// <param name="virtualMachineId">Fully qualified ARM ID of the
        /// virtual machine.</param>
        public IaaSVMProtectableItem(string backupManagementType = default(string), string friendlyName = default(string), ProtectionStatus? protectionState = default(ProtectionStatus?), string virtualMachineId = default(string))
            : base(backupManagementType, friendlyName, protectionState)
        {
            VirtualMachineId = virtualMachineId;
        }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; set; }

    }
}
