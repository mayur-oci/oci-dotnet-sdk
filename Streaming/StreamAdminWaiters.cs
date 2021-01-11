/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.StreamingService.Models;
using Oci.StreamingService.Requests;
using Oci.StreamingService.Responses;

namespace Oci.StreamingService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of StreamAdmin.
    /// </summary>
    public class StreamAdminWaiters
    {
        private readonly StreamAdminClient client;

        public  StreamAdminWaiters(StreamAdminClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectHarnessRequest, GetConnectHarnessResponse> ForConnectHarness(GetConnectHarnessRequest request, params ConnectHarness.LifecycleStateEnum[] targetStates)
        {
            return this.ForConnectHarness(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetConnectHarnessRequest, GetConnectHarnessResponse> ForConnectHarness(GetConnectHarnessRequest request, WaiterConfiguration config, params ConnectHarness.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetConnectHarnessRequest, GetConnectHarnessResponse>(
                request,
                request => client.GetConnectHarness(request),
                response => targetStates.Contains(response.ConnectHarness.LifecycleState.Value),
                targetStates.Contains(ConnectHarness.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetConnectHarnessRequest, GetConnectHarnessResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStreamRequest, GetStreamResponse> ForStream(GetStreamRequest request, params Stream.LifecycleStateEnum[] targetStates)
        {
            return this.ForStream(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStreamRequest, GetStreamResponse> ForStream(GetStreamRequest request, WaiterConfiguration config, params Stream.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetStreamRequest, GetStreamResponse>(
                request,
                request => client.GetStream(request),
                response => targetStates.Contains(response.Stream.LifecycleState.Value),
                targetStates.Contains(Stream.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetStreamRequest, GetStreamResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStreamPoolRequest, GetStreamPoolResponse> ForStreamPool(GetStreamPoolRequest request, params StreamPool.LifecycleStateEnum[] targetStates)
        {
            return this.ForStreamPool(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetStreamPoolRequest, GetStreamPoolResponse> ForStreamPool(GetStreamPoolRequest request, WaiterConfiguration config, params StreamPool.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetStreamPoolRequest, GetStreamPoolResponse>(
                request,
                request => client.GetStreamPool(request),
                response => targetStates.Contains(response.StreamPool.LifecycleState.Value),
                targetStates.Contains(StreamPool.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetStreamPoolRequest, GetStreamPoolResponse>(config, agent);
        }
    }
}
