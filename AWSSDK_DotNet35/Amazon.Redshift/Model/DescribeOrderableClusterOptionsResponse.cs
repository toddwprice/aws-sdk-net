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

using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the  DescribeOrderableClusterOptions response and response metadata.
    /// </summary>
    public partial class DescribeOrderableClusterOptionsResponse : DescribeOrderableClusterOptionsResult
    {
        /// <summary>
        /// Gets and sets the DescribeOrderableClusterOptionsResult property.
        /// Contains the output from the DescribeOrderableClusterOptions action.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeOrderableClusterOptionsResult class are now available on the DescribeOrderableClusterOptionsResponse class. You should use the properties on DescribeOrderableClusterOptionsResponse instead of accessing them through DescribeOrderableClusterOptionsResult.")]
        public DescribeOrderableClusterOptionsResult DescribeOrderableClusterOptionsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
