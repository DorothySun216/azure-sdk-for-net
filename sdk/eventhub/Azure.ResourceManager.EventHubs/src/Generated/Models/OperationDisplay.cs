// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The object that represents the operation. </summary>
    public partial class OperationDisplay
    {
        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        internal OperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> Service provider: Microsoft.EventHub. </param>
        /// <param name="resource"> Resource on which the operation is performed: Invoice, etc. </param>
        /// <param name="operation"> Operation type: Read, write, delete, etc. </param>
        internal OperationDisplay(string provider, string resource, string operation)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
        }

        /// <summary> Service provider: Microsoft.EventHub. </summary>
        public string Provider { get; }
        /// <summary> Resource on which the operation is performed: Invoice, etc. </summary>
        public string Resource { get; }
        /// <summary> Operation type: Read, write, delete, etc. </summary>
        public string Operation { get; }
    }
}
