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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeFleetAdvisorLsaAnalysis operation.
    /// </summary>
    public partial class DescribeFleetAdvisorLsaAnalysisResponse : AmazonWebServiceResponse
    {
        private List<FleetAdvisorLsaAnalysisResponse> _analysis = new List<FleetAdvisorLsaAnalysisResponse>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// A list of <code>FleetAdvisorLsaAnalysisResponse</code> objects.
        /// </para>
        /// </summary>
        public List<FleetAdvisorLsaAnalysisResponse> Analysis
        {
            get { return this._analysis; }
            set { this._analysis = value; }
        }

        // Check to see if Analysis property is set
        internal bool IsSetAnalysis()
        {
            return this._analysis != null && this._analysis.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is returned, there are more results available. The value
        /// of <code>NextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}