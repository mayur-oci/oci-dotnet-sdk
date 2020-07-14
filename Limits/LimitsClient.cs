/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.LimitsService.Requests;
using Oci.LimitsService.Responses;

namespace Oci.LimitsService
{
    /// <summary>Service client instance for Limits.</summary>
    public class LimitsClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/";

        public LimitsPaginators Paginators { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public LimitsClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "LIMITS",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://limits.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
            Paginators = new LimitsPaginators(this);
        }

        /// <summary>
        /// For a given compartmentId, resource limit name, and scope, returns the following:
        ///   - the number of available resources associated with the given limit
        ///   - the usage in the selected compartment for the given limit
        ///   Note: not all resource limits support this API. If the value is not available, the API will return 404.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<GetResourceAvailabilityResponse> GetResourceAvailability(GetResourceAvailabilityRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getResourceAvailability");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20190729/services/{serviceName}/limits/{limitName}/resourceAvailability".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<GetResourceAvailabilityResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetResourceAvailability failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Includes a list of resource limits that are currently supported.
        /// If the &#39;areQuotasSupported&#39; property is true, you can create quota policies on top of this limit at the
        /// compartment level.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListLimitDefinitionsResponse> ListLimitDefinitions(ListLimitDefinitionsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listLimitDefinitions");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20190729/limitDefinitions".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListLimitDefinitionsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListLimitDefinitions failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Includes a full list of resource limits belonging to a given service.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListLimitValuesResponse> ListLimitValues(ListLimitValuesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listLimitValues");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20190729/limitValues".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListLimitValuesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListLimitValues failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Returns the list of supported services.
        /// This will include the programmatic service name, along with the friendly service name.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListServicesResponse> ListServices(ListServicesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listServices");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20190729/services".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListServicesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListServices failed with error: {e.Message}");
                throw;
            }
        }

    }
}