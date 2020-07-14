/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FunctionsService.Models;
using Oci.FunctionsService.Requests;
using Oci.FunctionsService.Responses;

namespace Oci.FunctionsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FunctionsManagement.
    /// </summary>
    public class FunctionsManagementWaiters
    {
        private readonly FunctionsManagementClient client;

        public  FunctionsManagementWaiters(FunctionsManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, params Application.LifecycleStateEnum[] targetStates)
        {
            return this.ForApplication(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, WaiterConfiguration config, params Application.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetApplicationRequest, GetApplicationResponse>(
                request,
                request => client.GetApplication(request),
                response => targetStates.Contains(response.Application.LifecycleState.Value),
                targetStates.Contains(Application.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetApplicationRequest, GetApplicationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFunctionRequest, GetFunctionResponse> ForFunction(GetFunctionRequest request, params Function.LifecycleStateEnum[] targetStates)
        {
            return this.ForFunction(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFunctionRequest, GetFunctionResponse> ForFunction(GetFunctionRequest request, WaiterConfiguration config, params Function.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetFunctionRequest, GetFunctionResponse>(
                request,
                request => client.GetFunction(request),
                response => targetStates.Contains(response.Function.LifecycleState.Value),
                targetStates.Contains(Function.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetFunctionRequest, GetFunctionResponse>(config, agent);
        }
    }
}