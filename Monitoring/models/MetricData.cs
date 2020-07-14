/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The set of aggregated data returned for a metric.
    /// For information about metrics, see [Metrics Overview](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#MetricsOverview).
    /// <br/>
    /// Limits information for returned data follows. 
    /// <br/>
    /// * Data points: 100,000.
    /// * Metric streams* within data points: 2,000.
    /// * Time range returned for 1-hour resolution: 90 days.
    /// * Time range returned for 5-minute resolution: 30 days.
    /// * Time range returned for any other resolution: 7 days.
    /// <br/>
    /// *A metric stream is an individual set of aggregated data for a metric, typically specific to a single resource. 
    /// Metric streams cannot be aggregated across metric groups. 
    /// A metric group is the combination of a given metric, metric namespace, and tenancy for the purpose of determining limits. 
    /// For more information about metric-related concepts, see [Monitoring Concepts](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#concepts).
    /// 
    /// </summary>
    public class MetricData 
    {
        
        /// <value>
        /// The reference provided in a metric definition to indicate the source service or
        /// application that emitted the metric.
        /// <br/>
        /// Example: oci_computeagent
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }

        /// <value>
        /// Resource group provided with the posted metric. A resource group is a custom string that can be used as a filter. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the
        /// resources from which the aggregated data was returned.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The name of the metric.
        /// <br/>
        /// Example: CpuUtilization
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Qualifiers provided in the definition of the returned metric.
        /// Available dimensions vary by metric namespace. Each dimension takes the form of a key-value pair.
        /// <br/>
        /// Example: &quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }

        /// <value>
        /// The references provided in a metric definition to indicate extra information about the metric.
        /// <br/>
        /// Example: &quot;unit&quot;: &quot;bytes&quot;
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <value>
        /// The time between calculated aggregation windows. Use with the query interval to vary the
        /// frequency at which aggregated data points are returned. For example, use a query interval of
        /// 5 minutes with a resolution of 1 minute to retrieve five-minute aggregations at a one-minute
        /// frequency. The resolution must be equal or less than the interval in the query. The default
        /// resolution is 1m (one minute). Supported values: `1m`-`60m` (also `1h`).
        /// <br/>
        /// Example: 5m
        /// </value>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }

        /// <value>
        /// The list of timestamp-value pairs returned for the specified request. Metric values are rolled up to the start time specified in the request. 
        /// For important limits information related to data points, see MetricData Reference at the top of this page. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AggregatedDatapoints is required.")]
        [JsonProperty(PropertyName = "aggregatedDatapoints")]
        public System.Collections.Generic.List<AggregatedDatapoint> AggregatedDatapoints { get; set; }
    }
}