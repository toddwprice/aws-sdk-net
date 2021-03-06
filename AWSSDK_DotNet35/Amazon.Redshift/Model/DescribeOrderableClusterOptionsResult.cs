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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the DescribeOrderableClusterOptions action. </para>
    /// </summary>
    public partial class DescribeOrderableClusterOptionsResult : AmazonWebServiceResponse
    {
        
        private List<OrderableClusterOption> orderableClusterOptions = new List<OrderableClusterOption>();
        private string marker;


        /// <summary>
        /// An <a>OrderableClusterOption</a> structure containing information about orderable options for the Cluster.
        ///  
        /// </summary>
        public List<OrderableClusterOption> OrderableClusterOptions
        {
            get { return this.orderableClusterOptions; }
            set { this.orderableClusterOptions = value; }
        }

        // Check to see if OrderableClusterOptions property is set
        internal bool IsSetOrderableClusterOptions()
        {
            return this.orderableClusterOptions.Count > 0;
        }

        /// <summary>
        /// A value that indicates the starting point for the next set of response records in a subsequent request. If a value is returned in a
        /// response, you can retrieve the next set of records by providing this returned marker value in the <c>Marker</c> parameter and retrying the
        /// command. If the <c>Marker</c> field is empty, all response records have been retrieved for the request.
        ///  
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
    }
}
