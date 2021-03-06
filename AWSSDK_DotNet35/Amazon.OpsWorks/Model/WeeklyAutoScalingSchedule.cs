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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a time-based instance's auto scaling schedule. The schedule consists of a set of key-value pairs.</para>
    /// <ul>
    /// <li>The key is the time period (a UTC hour) and must be an integer from 0 - 23.</li>
    /// <li>The value indicates whether the instance should be online or offline for the specified period, and must be set to "on" or "off"</li>
    /// 
    /// </ul>
    /// <para>The default setting for all time periods is off, so you use the following parameters primarily to specify the online periods. You
    /// don't have to explicitly specify offline periods unless you want to change an online period to an offline period. </para> <para>The
    /// following example specifies that the instance should be online for four hours, from UTC 1200 - 1600. It will be off for the remainder of the
    /// day.</para> <para> <c> { "12":"on", "13":"on", "14":"on", "15":"on" } </c> </para>
    /// </summary>
    public partial class WeeklyAutoScalingSchedule
    {
        
        private Dictionary<string,string> monday = new Dictionary<string,string>();
        private Dictionary<string,string> tuesday = new Dictionary<string,string>();
        private Dictionary<string,string> wednesday = new Dictionary<string,string>();
        private Dictionary<string,string> thursday = new Dictionary<string,string>();
        private Dictionary<string,string> friday = new Dictionary<string,string>();
        private Dictionary<string,string> saturday = new Dictionary<string,string>();
        private Dictionary<string,string> sunday = new Dictionary<string,string>();


        /// <summary>
        /// The schedule for Monday.
        ///  
        /// </summary>
        public Dictionary<string,string> Monday
        {
            get { return this.monday; }
            set { this.monday = value; }
        }

        // Check to see if Monday property is set
        internal bool IsSetMonday()
        {
            return this.monday != null;
        }

        /// <summary>
        /// The schedule for Tuesday.
        ///  
        /// </summary>
        public Dictionary<string,string> Tuesday
        {
            get { return this.tuesday; }
            set { this.tuesday = value; }
        }

        // Check to see if Tuesday property is set
        internal bool IsSetTuesday()
        {
            return this.tuesday != null;
        }

        /// <summary>
        /// The schedule for Wednesday.
        ///  
        /// </summary>
        public Dictionary<string,string> Wednesday
        {
            get { return this.wednesday; }
            set { this.wednesday = value; }
        }

        // Check to see if Wednesday property is set
        internal bool IsSetWednesday()
        {
            return this.wednesday != null;
        }

        /// <summary>
        /// The schedule for Thursday.
        ///  
        /// </summary>
        public Dictionary<string,string> Thursday
        {
            get { return this.thursday; }
            set { this.thursday = value; }
        }

        // Check to see if Thursday property is set
        internal bool IsSetThursday()
        {
            return this.thursday != null;
        }

        /// <summary>
        /// The schedule for Friday.
        ///  
        /// </summary>
        public Dictionary<string,string> Friday
        {
            get { return this.friday; }
            set { this.friday = value; }
        }

        // Check to see if Friday property is set
        internal bool IsSetFriday()
        {
            return this.friday != null;
        }

        /// <summary>
        /// The schedule for Saturday.
        ///  
        /// </summary>
        public Dictionary<string,string> Saturday
        {
            get { return this.saturday; }
            set { this.saturday = value; }
        }

        // Check to see if Saturday property is set
        internal bool IsSetSaturday()
        {
            return this.saturday != null;
        }

        /// <summary>
        /// The schedule for Sunday.
        ///  
        /// </summary>
        public Dictionary<string,string> Sunday
        {
            get { return this.sunday; }
            set { this.sunday = value; }
        }

        // Check to see if Sunday property is set
        internal bool IsSetSunday()
        {
            return this.sunday != null;
        }
    }
}
