/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para> A complex type that contains the response for the request.</para>
    /// </summary>
    public partial class ListHealthChecksResult : AmazonWebServiceResponse
    {
        
        private List<HealthCheck> healthChecks = new List<HealthCheck>();
        private string marker;
        private bool? isTruncated;
        private string nextMarker;
        private string maxItems;


        /// <summary>
        /// A complex type that contains information about the health checks associated with the current AWS account.
        ///  
        /// </summary>
        public List<HealthCheck> HealthChecks
        {
            get { return this.healthChecks; }
            set { this.healthChecks = value; }
        }

        // Check to see if HealthChecks property is set
        internal bool IsSetHealthChecks()
        {
            return this.healthChecks.Count > 0;
        }

        /// <summary>
        /// If the request returned more than one page of results, submit another request and specify the value of <c>NextMarker</c> from the last
        /// response in the <c>marker</c> parameter to get the next page of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A flag indicating whether there are more health checks to be listed. If your results were truncated, you can make a follow-up request for
        /// the next page of results by using the <c>Marker</c> element. Valid Values: <c>true</c> | <c>false</c>
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// Indicates where to continue listing health checks. If <a>ListHealthChecksResponse$IsTruncated</a> is <c>true</c>, make another request to
        /// <c>ListHealthChecks</c> and include the value of the <c>NextMarker</c> element in the <c>Marker</c> element to get the next page of results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this.nextMarker; }
            set { this.nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this.nextMarker != null;
        }

        /// <summary>
        /// The maximum number of health checks to be included in the response body. If the number of health checks associated with this AWS account
        /// exceeds <c>MaxItems</c>, the value of <a>ListHealthChecksResponse$IsTruncated</a> in the response is <c>true</c>. Call
        /// <c>ListHealthChecks</c> again and specify the value of <a>ListHealthChecksResponse$NextMarker</a> in the
        /// <a>ListHostedZonesRequest$Marker</a> element to get the next page of results.
        ///  
        /// </summary>
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems != null;
        }
    }
}
