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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeModel operation.
    /// Provides a JSON containing the overall information about a specific ML model, including
    /// model name and ARN, dataset, training and evaluation information, status, and so on.
    /// </summary>
    public partial class DescribeModelRequest : AmazonLookoutEquipmentRequest
    {
        private string _modelName;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the ML model to be described. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

    }
}