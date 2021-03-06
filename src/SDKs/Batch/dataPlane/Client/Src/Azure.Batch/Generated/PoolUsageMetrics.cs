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
    /// The usage metrics for a single pool in a certain time range.
    /// </summary>
    public partial class PoolUsageMetrics : IPropertyMetadata
    {
        private readonly double dataEgressGiB;
        private readonly double dataIngressGiB;
        private readonly DateTime endTime;
        private readonly string poolId;
        private readonly DateTime startTime;
        private readonly double totalCoreHours;
        private readonly string virtualMachineSize;

        #region Constructors

        internal PoolUsageMetrics(Models.PoolUsageMetrics protocolObject)
        {
            this.dataEgressGiB = protocolObject.DataEgressGiB;
            this.dataIngressGiB = protocolObject.DataIngressGiB;
            this.endTime = protocolObject.EndTime;
            this.poolId = protocolObject.PoolId;
            this.startTime = protocolObject.StartTime;
            this.totalCoreHours = protocolObject.TotalCoreHours;
            this.virtualMachineSize = protocolObject.VmSize;
        }

        #endregion Constructors

        #region PoolUsageMetrics

        /// <summary>
        /// Gets the cross data center network egress from the pool during this interval, in gibibytes.
        /// </summary>
        public double DataEgressGiB
        {
            get { return this.dataEgressGiB; }
        }

        /// <summary>
        /// Gets the cross data center network ingress to the pool during this interval, in gibibytes.
        /// </summary>
        public double DataIngressGiB
        {
            get { return this.dataIngressGiB; }
        }

        /// <summary>
        /// Gets the end time of the aggregation interval for this entry.
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the id of the pool whose metrics are aggregated in this entry.
        /// </summary>
        public string PoolId
        {
            get { return this.poolId; }
        }

        /// <summary>
        /// Gets the start time of the aggregation interval covered by this entry.
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the total core hours used in the pool during this aggregation interval.
        /// </summary>
        public double TotalCoreHours
        {
            get { return this.totalCoreHours; }
        }

        /// <summary>
        /// Gets the size of virtual machine in the pool. All virtual machines in a pool are the same size. Azure Batch supports 
        /// all Azure virtual machine sizes except ExtraSmall.
        /// </summary>
        public string VirtualMachineSize
        {
            get { return this.virtualMachineSize; }
        }

        #endregion // PoolUsageMetrics

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