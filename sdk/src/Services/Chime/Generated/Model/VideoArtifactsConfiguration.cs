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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The video artifact configuration object.
    /// </summary>
    public partial class VideoArtifactsConfiguration
    {
        private VideoMuxType _muxType;
        private ArtifactsState _state;

        /// <summary>
        /// Gets and sets the property MuxType. 
        /// <para>
        /// The MUX type of the video artifact configuration object.
        /// </para>
        /// </summary>
        public VideoMuxType MuxType
        {
            get { return this._muxType; }
            set { this._muxType = value; }
        }

        // Check to see if MuxType property is set
        internal bool IsSetMuxType()
        {
            return this._muxType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the video artifact is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactsState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}