/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ManagementagentService.Models;
using Oci.ManagementagentService.Requests;
using Oci.ManagementagentService.Responses;

namespace Oci.ManagementagentService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ManagementAgent.
    /// </summary>
    public class ManagementAgentWaiters
    {
        private readonly ManagementAgentClient client;

        public  ManagementAgentWaiters(ManagementAgentClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementAgentRequest, GetManagementAgentResponse> ForManagementAgent(GetManagementAgentRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForManagementAgent(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementAgentRequest, GetManagementAgentResponse> ForManagementAgent(GetManagementAgentRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetManagementAgentRequest, GetManagementAgentResponse>(
                request,
                request => client.GetManagementAgent(request),
                response => targetStates.Contains(response.ManagementAgent.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Terminated)
            );
            return new Waiter<GetManagementAgentRequest, GetManagementAgentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementAgentInstallKeyRequest, GetManagementAgentInstallKeyResponse> ForManagementAgentInstallKey(GetManagementAgentInstallKeyRequest request, params LifecycleStates[] targetStates)
        {
            return this.ForManagementAgentInstallKey(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagementAgentInstallKeyRequest, GetManagementAgentInstallKeyResponse> ForManagementAgentInstallKey(GetManagementAgentInstallKeyRequest request, WaiterConfiguration config, params LifecycleStates[] targetStates)
        {
            var agent = new WaiterAgent<GetManagementAgentInstallKeyRequest, GetManagementAgentInstallKeyResponse>(
                request,
                request => client.GetManagementAgentInstallKey(request),
                response => targetStates.Contains(response.ManagementAgentInstallKey.LifecycleState.Value),
                targetStates.Contains(LifecycleStates.Terminated)
            );
            return new Waiter<GetManagementAgentInstallKeyRequest, GetManagementAgentInstallKeyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
