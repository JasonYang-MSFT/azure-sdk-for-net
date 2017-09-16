// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The endpoint configuration for the compute node.
    /// </summary>
    public partial class ComputeNodeEndpointConfiguration : IPropertyMetadata
    {
        #region Constructors

        internal ComputeNodeEndpointConfiguration(Models.ComputeNodeEndpointConfiguration protocolObject)
        {
            this.InboundEndpoints = InboundEndpoint.ConvertFromProtocolCollectionReadOnly(protocolObject.InboundEndpoints);
        }

        #endregion Constructors

        #region ComputeNodeEndpointConfiguration

        /// <summary>
        /// Gets the list of inbound endpoints that are accessible on the compute node.
        /// </summary>
        public IReadOnlyList<InboundEndpoint> InboundEndpoints { get; }

        #endregion // ComputeNodeEndpointConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}