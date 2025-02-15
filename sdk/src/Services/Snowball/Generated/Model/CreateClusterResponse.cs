/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the CreateCluster operation.
    /// </summary>
    public partial class CreateClusterResponse : AmazonWebServiceResponse
    {
        private string _clusterId;
        private List<JobListEntry> _jobListEntries = new List<JobListEntry>();

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The automatically generated ID for a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=39, Max=39)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property JobListEntries. 
        /// <para>
        /// List of jobs created for this cluster. For syntax, see <a href="https://docs.aws.amazon.com/snowball/latest/api-reference/API_ListJobs.html#API_ListJobs_ResponseSyntax">ListJobsResult$JobListEntries</a>
        /// in this guide.
        /// </para>
        /// </summary>
        public List<JobListEntry> JobListEntries
        {
            get { return this._jobListEntries; }
            set { this._jobListEntries = value; }
        }

        // Check to see if JobListEntries property is set
        internal bool IsSetJobListEntries()
        {
            return this._jobListEntries != null && this._jobListEntries.Count > 0; 
        }

    }
}