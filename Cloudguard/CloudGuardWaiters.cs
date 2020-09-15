/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CloudguardService.Models;
using Oci.CloudguardService.Requests;
using Oci.CloudguardService.Responses;

namespace Oci.CloudguardService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of CloudGuard.
    /// </summary>
    public class CloudGuardWaiters
    {
        private readonly CloudGuardClient client;

        public  CloudGuardWaiters(CloudGuardClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRequest, GetDetectorResponse> ForDetector(GetDetectorRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDetector(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRequest, GetDetectorResponse> ForDetector(GetDetectorRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDetectorRequest, GetDetectorResponse>(
                request,
                request => client.GetDetector(request),
                response => targetStates.Contains(response.Detector.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDetectorRequest, GetDetectorResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRecipeRequest, GetDetectorRecipeResponse> ForDetectorRecipe(GetDetectorRecipeRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDetectorRecipe(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRecipeRequest, GetDetectorRecipeResponse> ForDetectorRecipe(GetDetectorRecipeRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDetectorRecipeRequest, GetDetectorRecipeResponse>(
                request,
                request => client.GetDetectorRecipe(request),
                response => targetStates.Contains(response.DetectorRecipe.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDetectorRecipeRequest, GetDetectorRecipeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRecipeDetectorRuleRequest, GetDetectorRecipeDetectorRuleResponse> ForDetectorRecipeDetectorRule(GetDetectorRecipeDetectorRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDetectorRecipeDetectorRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRecipeDetectorRuleRequest, GetDetectorRecipeDetectorRuleResponse> ForDetectorRecipeDetectorRule(GetDetectorRecipeDetectorRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDetectorRecipeDetectorRuleRequest, GetDetectorRecipeDetectorRuleResponse>(
                request,
                request => client.GetDetectorRecipeDetectorRule(request),
                response => targetStates.Contains(response.DetectorRecipeDetectorRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDetectorRecipeDetectorRuleRequest, GetDetectorRecipeDetectorRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRuleRequest, GetDetectorRuleResponse> ForDetectorRule(GetDetectorRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDetectorRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDetectorRuleRequest, GetDetectorRuleResponse> ForDetectorRule(GetDetectorRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDetectorRuleRequest, GetDetectorRuleResponse>(
                request,
                request => client.GetDetectorRule(request),
                response => targetStates.Contains(response.DetectorRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDetectorRuleRequest, GetDetectorRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagedListRequest, GetManagedListResponse> ForManagedList(GetManagedListRequest request, params LifecycleState[] targetStates)
        {
            return this.ForManagedList(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetManagedListRequest, GetManagedListResponse> ForManagedList(GetManagedListRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetManagedListRequest, GetManagedListResponse>(
                request,
                request => client.GetManagedList(request),
                response => targetStates.Contains(response.ManagedList.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetManagedListRequest, GetManagedListResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProblemRequest, GetProblemResponse> ForProblem(GetProblemRequest request, params ProblemLifecycleState[] targetStates)
        {
            return this.ForProblem(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProblemRequest, GetProblemResponse> ForProblem(GetProblemRequest request, WaiterConfiguration config, params ProblemLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetProblemRequest, GetProblemResponse>(
                request,
                request => client.GetProblem(request),
                response => targetStates.Contains(response.Problem.LifecycleState.Value)
            );
            return new Waiter<GetProblemRequest, GetProblemResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRecipeRequest, GetResponderRecipeResponse> ForResponderRecipe(GetResponderRecipeRequest request, params LifecycleState[] targetStates)
        {
            return this.ForResponderRecipe(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRecipeRequest, GetResponderRecipeResponse> ForResponderRecipe(GetResponderRecipeRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetResponderRecipeRequest, GetResponderRecipeResponse>(
                request,
                request => client.GetResponderRecipe(request),
                response => targetStates.Contains(response.ResponderRecipe.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetResponderRecipeRequest, GetResponderRecipeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRecipeResponderRuleRequest, GetResponderRecipeResponderRuleResponse> ForResponderRecipeResponderRule(GetResponderRecipeResponderRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForResponderRecipeResponderRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRecipeResponderRuleRequest, GetResponderRecipeResponderRuleResponse> ForResponderRecipeResponderRule(GetResponderRecipeResponderRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetResponderRecipeResponderRuleRequest, GetResponderRecipeResponderRuleResponse>(
                request,
                request => client.GetResponderRecipeResponderRule(request),
                response => targetStates.Contains(response.ResponderRecipeResponderRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetResponderRecipeResponderRuleRequest, GetResponderRecipeResponderRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRuleRequest, GetResponderRuleResponse> ForResponderRule(GetResponderRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForResponderRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetResponderRuleRequest, GetResponderRuleResponse> ForResponderRule(GetResponderRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetResponderRuleRequest, GetResponderRuleResponse>(
                request,
                request => client.GetResponderRule(request),
                response => targetStates.Contains(response.ResponderRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetResponderRuleRequest, GetResponderRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetRequest, GetTargetResponse> ForTarget(GetTargetRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTarget(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetRequest, GetTargetResponse> ForTarget(GetTargetRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTargetRequest, GetTargetResponse>(
                request,
                request => client.GetTarget(request),
                response => targetStates.Contains(response.Target.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTargetRequest, GetTargetResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDetectorRecipeRequest, GetTargetDetectorRecipeResponse> ForTargetDetectorRecipe(GetTargetDetectorRecipeRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTargetDetectorRecipe(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDetectorRecipeRequest, GetTargetDetectorRecipeResponse> ForTargetDetectorRecipe(GetTargetDetectorRecipeRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTargetDetectorRecipeRequest, GetTargetDetectorRecipeResponse>(
                request,
                request => client.GetTargetDetectorRecipe(request),
                response => targetStates.Contains(response.TargetDetectorRecipe.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTargetDetectorRecipeRequest, GetTargetDetectorRecipeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDetectorRecipeDetectorRuleRequest, GetTargetDetectorRecipeDetectorRuleResponse> ForTargetDetectorRecipeDetectorRule(GetTargetDetectorRecipeDetectorRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTargetDetectorRecipeDetectorRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetDetectorRecipeDetectorRuleRequest, GetTargetDetectorRecipeDetectorRuleResponse> ForTargetDetectorRecipeDetectorRule(GetTargetDetectorRecipeDetectorRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTargetDetectorRecipeDetectorRuleRequest, GetTargetDetectorRecipeDetectorRuleResponse>(
                request,
                request => client.GetTargetDetectorRecipeDetectorRule(request),
                response => targetStates.Contains(response.TargetDetectorRecipeDetectorRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTargetDetectorRecipeDetectorRuleRequest, GetTargetDetectorRecipeDetectorRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetResponderRecipeResponderRuleRequest, GetTargetResponderRecipeResponderRuleResponse> ForTargetResponderRecipeResponderRule(GetTargetResponderRecipeResponderRuleRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTargetResponderRecipeResponderRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTargetResponderRecipeResponderRuleRequest, GetTargetResponderRecipeResponderRuleResponse> ForTargetResponderRecipeResponderRule(GetTargetResponderRecipeResponderRuleRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTargetResponderRecipeResponderRuleRequest, GetTargetResponderRecipeResponderRuleResponse>(
                request,
                request => client.GetTargetResponderRecipeResponderRule(request),
                response => targetStates.Contains(response.TargetResponderRecipeResponderRule.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTargetResponderRecipeResponderRuleRequest, GetTargetResponderRecipeResponderRuleResponse>(config, agent);
        }
    }
}
