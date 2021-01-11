/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.KeymanagementService.Models;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;

namespace Oci.KeymanagementService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of KmsVault.
    /// </summary>
    public class KmsVaultWaiters
    {
        private readonly KmsVaultClient client;

        public  KmsVaultWaiters(KmsVaultClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVaultRequest, GetVaultResponse> ForVault(GetVaultRequest request, params Vault.LifecycleStateEnum[] targetStates)
        {
            return this.ForVault(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVaultRequest, GetVaultResponse> ForVault(GetVaultRequest request, WaiterConfiguration config, params Vault.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVaultRequest, GetVaultResponse>(
                request,
                request => client.GetVault(request),
                response => targetStates.Contains(response.Vault.LifecycleState.Value),
                targetStates.Contains(Vault.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetVaultRequest, GetVaultResponse>(config, agent);
        }
    }
}
