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
    /// The Edifact agreement envelope settings.
    /// </summary>
    public partial class EdifactEnvelopeSettings
    {
        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeSettings class.
        /// </summary>
        public EdifactEnvelopeSettings() { }

        /// <summary>
        /// Initializes a new instance of the EdifactEnvelopeSettings class.
        /// </summary>
        public EdifactEnvelopeSettings(bool applyDelimiterStringAdvice, bool createGroupingSegments, bool enableDefaultGroupHeaders, long interchangeControlNumberLowerBound, long interchangeControlNumberUpperBound, bool rolloverInterchangeControlNumber, long groupControlNumberLowerBound, long groupControlNumberUpperBound, bool rolloverGroupControlNumber, bool overwriteExistingTransactionSetControlNumber, long transactionSetControlNumberLowerBound, long transactionSetControlNumberUpperBound, bool rolloverTransactionSetControlNumber, bool isTestInterchange, string groupAssociationAssignedCode = default(string), string communicationAgreementId = default(string), string recipientReferencePasswordValue = default(string), string recipientReferencePasswordQualifier = default(string), string applicationReferenceId = default(string), string processingPriorityCode = default(string), string interchangeControlNumberPrefix = default(string), string interchangeControlNumberSuffix = default(string), string senderReverseRoutingAddress = default(string), string receiverReverseRoutingAddress = default(string), string functionalGroupId = default(string), string groupControllingAgencyCode = default(string), string groupMessageVersion = default(string), string groupMessageRelease = default(string), string groupControlNumberPrefix = default(string), string groupControlNumberSuffix = default(string), string groupApplicationReceiverQualifier = default(string), string groupApplicationReceiverId = default(string), string groupApplicationSenderQualifier = default(string), string groupApplicationSenderId = default(string), string groupApplicationPassword = default(string), string transactionSetControlNumberPrefix = default(string), string transactionSetControlNumberSuffix = default(string), string senderInternalIdentification = default(string), string senderInternalSubIdentification = default(string), string receiverInternalIdentification = default(string), string receiverInternalSubIdentification = default(string))
        {
            GroupAssociationAssignedCode = groupAssociationAssignedCode;
            CommunicationAgreementId = communicationAgreementId;
            ApplyDelimiterStringAdvice = applyDelimiterStringAdvice;
            CreateGroupingSegments = createGroupingSegments;
            EnableDefaultGroupHeaders = enableDefaultGroupHeaders;
            RecipientReferencePasswordValue = recipientReferencePasswordValue;
            RecipientReferencePasswordQualifier = recipientReferencePasswordQualifier;
            ApplicationReferenceId = applicationReferenceId;
            ProcessingPriorityCode = processingPriorityCode;
            InterchangeControlNumberLowerBound = interchangeControlNumberLowerBound;
            InterchangeControlNumberUpperBound = interchangeControlNumberUpperBound;
            RolloverInterchangeControlNumber = rolloverInterchangeControlNumber;
            InterchangeControlNumberPrefix = interchangeControlNumberPrefix;
            InterchangeControlNumberSuffix = interchangeControlNumberSuffix;
            SenderReverseRoutingAddress = senderReverseRoutingAddress;
            ReceiverReverseRoutingAddress = receiverReverseRoutingAddress;
            FunctionalGroupId = functionalGroupId;
            GroupControllingAgencyCode = groupControllingAgencyCode;
            GroupMessageVersion = groupMessageVersion;
            GroupMessageRelease = groupMessageRelease;
            GroupControlNumberLowerBound = groupControlNumberLowerBound;
            GroupControlNumberUpperBound = groupControlNumberUpperBound;
            RolloverGroupControlNumber = rolloverGroupControlNumber;
            GroupControlNumberPrefix = groupControlNumberPrefix;
            GroupControlNumberSuffix = groupControlNumberSuffix;
            GroupApplicationReceiverQualifier = groupApplicationReceiverQualifier;
            GroupApplicationReceiverId = groupApplicationReceiverId;
            GroupApplicationSenderQualifier = groupApplicationSenderQualifier;
            GroupApplicationSenderId = groupApplicationSenderId;
            GroupApplicationPassword = groupApplicationPassword;
            OverwriteExistingTransactionSetControlNumber = overwriteExistingTransactionSetControlNumber;
            TransactionSetControlNumberPrefix = transactionSetControlNumberPrefix;
            TransactionSetControlNumberSuffix = transactionSetControlNumberSuffix;
            TransactionSetControlNumberLowerBound = transactionSetControlNumberLowerBound;
            TransactionSetControlNumberUpperBound = transactionSetControlNumberUpperBound;
            RolloverTransactionSetControlNumber = rolloverTransactionSetControlNumber;
            IsTestInterchange = isTestInterchange;
            SenderInternalIdentification = senderInternalIdentification;
            SenderInternalSubIdentification = senderInternalSubIdentification;
            ReceiverInternalIdentification = receiverInternalIdentification;
            ReceiverInternalSubIdentification = receiverInternalSubIdentification;
        }

        /// <summary>
        /// Gets or sets the group association assigned code.
        /// </summary>
        [JsonProperty(PropertyName = "groupAssociationAssignedCode")]
        public string GroupAssociationAssignedCode { get; set; }

        /// <summary>
        /// Gets or sets the communication agreement id.
        /// </summary>
        [JsonProperty(PropertyName = "communicationAgreementId")]
        public string CommunicationAgreementId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to apply delimiter
        /// string advice.
        /// </summary>
        [JsonProperty(PropertyName = "applyDelimiterStringAdvice")]
        public bool ApplyDelimiterStringAdvice { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to create grouping
        /// segments.
        /// </summary>
        [JsonProperty(PropertyName = "createGroupingSegments")]
        public bool CreateGroupingSegments { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to enable default group
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "enableDefaultGroupHeaders")]
        public bool EnableDefaultGroupHeaders { get; set; }

        /// <summary>
        /// Gets or sets the recipient reference password value.
        /// </summary>
        [JsonProperty(PropertyName = "recipientReferencePasswordValue")]
        public string RecipientReferencePasswordValue { get; set; }

        /// <summary>
        /// Gets or sets the recipient reference password qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "recipientReferencePasswordQualifier")]
        public string RecipientReferencePasswordQualifier { get; set; }

        /// <summary>
        /// Gets or sets the application reference id.
        /// </summary>
        [JsonProperty(PropertyName = "applicationReferenceId")]
        public string ApplicationReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the processing priority code.
        /// </summary>
        [JsonProperty(PropertyName = "processingPriorityCode")]
        public string ProcessingPriorityCode { get; set; }

        /// <summary>
        /// Gets or sets the interchange control number lower bound.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberLowerBound")]
        public long InterchangeControlNumberLowerBound { get; set; }

        /// <summary>
        /// Gets or sets the interchange control number upper bound.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberUpperBound")]
        public long InterchangeControlNumberUpperBound { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to rollover interchange
        /// control number.
        /// </summary>
        [JsonProperty(PropertyName = "rolloverInterchangeControlNumber")]
        public bool RolloverInterchangeControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the interchange control number prefix.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberPrefix")]
        public string InterchangeControlNumberPrefix { get; set; }

        /// <summary>
        /// Gets or sets the interchange control number suffix.
        /// </summary>
        [JsonProperty(PropertyName = "interchangeControlNumberSuffix")]
        public string InterchangeControlNumberSuffix { get; set; }

        /// <summary>
        /// Gets or sets the sender reverse routing address.
        /// </summary>
        [JsonProperty(PropertyName = "senderReverseRoutingAddress")]
        public string SenderReverseRoutingAddress { get; set; }

        /// <summary>
        /// Gets or sets the receiver reverse routing address.
        /// </summary>
        [JsonProperty(PropertyName = "receiverReverseRoutingAddress")]
        public string ReceiverReverseRoutingAddress { get; set; }

        /// <summary>
        /// Gets or sets the functional group id.
        /// </summary>
        [JsonProperty(PropertyName = "functionalGroupId")]
        public string FunctionalGroupId { get; set; }

        /// <summary>
        /// Gets or sets the group controlling agency code.
        /// </summary>
        [JsonProperty(PropertyName = "groupControllingAgencyCode")]
        public string GroupControllingAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the group message version.
        /// </summary>
        [JsonProperty(PropertyName = "groupMessageVersion")]
        public string GroupMessageVersion { get; set; }

        /// <summary>
        /// Gets or sets the group message release.
        /// </summary>
        [JsonProperty(PropertyName = "groupMessageRelease")]
        public string GroupMessageRelease { get; set; }

        /// <summary>
        /// Gets or sets the group control number lower bound.
        /// </summary>
        [JsonProperty(PropertyName = "groupControlNumberLowerBound")]
        public long GroupControlNumberLowerBound { get; set; }

        /// <summary>
        /// Gets or sets the group control number upper bound.
        /// </summary>
        [JsonProperty(PropertyName = "groupControlNumberUpperBound")]
        public long GroupControlNumberUpperBound { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to rollover group
        /// control number.
        /// </summary>
        [JsonProperty(PropertyName = "rolloverGroupControlNumber")]
        public bool RolloverGroupControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the group control number prefix.
        /// </summary>
        [JsonProperty(PropertyName = "groupControlNumberPrefix")]
        public string GroupControlNumberPrefix { get; set; }

        /// <summary>
        /// Gets or sets the group control number suffix.
        /// </summary>
        [JsonProperty(PropertyName = "groupControlNumberSuffix")]
        public string GroupControlNumberSuffix { get; set; }

        /// <summary>
        /// Gets or sets the group application receiver qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "groupApplicationReceiverQualifier")]
        public string GroupApplicationReceiverQualifier { get; set; }

        /// <summary>
        /// Gets or sets the group application receiver id.
        /// </summary>
        [JsonProperty(PropertyName = "groupApplicationReceiverId")]
        public string GroupApplicationReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the group application sender qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "groupApplicationSenderQualifier")]
        public string GroupApplicationSenderQualifier { get; set; }

        /// <summary>
        /// Gets or sets the group application sender id.
        /// </summary>
        [JsonProperty(PropertyName = "groupApplicationSenderId")]
        public string GroupApplicationSenderId { get; set; }

        /// <summary>
        /// Gets or sets the group application password.
        /// </summary>
        [JsonProperty(PropertyName = "groupApplicationPassword")]
        public string GroupApplicationPassword { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to overwrite existing
        /// transaction set control number.
        /// </summary>
        [JsonProperty(PropertyName = "overwriteExistingTransactionSetControlNumber")]
        public bool OverwriteExistingTransactionSetControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the transaction set control number prefix.
        /// </summary>
        [JsonProperty(PropertyName = "transactionSetControlNumberPrefix")]
        public string TransactionSetControlNumberPrefix { get; set; }

        /// <summary>
        /// Gets or sets the transaction set control number suffix.
        /// </summary>
        [JsonProperty(PropertyName = "transactionSetControlNumberSuffix")]
        public string TransactionSetControlNumberSuffix { get; set; }

        /// <summary>
        /// Gets or sets the transaction set control number lower bound.
        /// </summary>
        [JsonProperty(PropertyName = "transactionSetControlNumberLowerBound")]
        public long TransactionSetControlNumberLowerBound { get; set; }

        /// <summary>
        /// Gets or sets the transaction set control number upper bound.
        /// </summary>
        [JsonProperty(PropertyName = "transactionSetControlNumberUpperBound")]
        public long TransactionSetControlNumberUpperBound { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to rollover transaction
        /// set control number.
        /// </summary>
        [JsonProperty(PropertyName = "rolloverTransactionSetControlNumber")]
        public bool RolloverTransactionSetControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the message is a test
        /// interchange.
        /// </summary>
        [JsonProperty(PropertyName = "isTestInterchange")]
        public bool IsTestInterchange { get; set; }

        /// <summary>
        /// Gets or sets the sender internal identification.
        /// </summary>
        [JsonProperty(PropertyName = "senderInternalIdentification")]
        public string SenderInternalIdentification { get; set; }

        /// <summary>
        /// Gets or sets the sender internal sub identification.
        /// </summary>
        [JsonProperty(PropertyName = "senderInternalSubIdentification")]
        public string SenderInternalSubIdentification { get; set; }

        /// <summary>
        /// Gets or sets the receiver internal identification.
        /// </summary>
        [JsonProperty(PropertyName = "receiverInternalIdentification")]
        public string ReceiverInternalIdentification { get; set; }

        /// <summary>
        /// Gets or sets the receiver internal sub identification.
        /// </summary>
        [JsonProperty(PropertyName = "receiverInternalSubIdentification")]
        public string ReceiverInternalSubIdentification { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
