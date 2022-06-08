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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatabaseResponse Object
    /// </summary>  
    public class DatabaseResponseUnmarshaller : IUnmarshaller<DatabaseResponse, XmlUnmarshallerContext>, IUnmarshaller<DatabaseResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatabaseResponse IUnmarshaller<DatabaseResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DatabaseResponse Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DatabaseResponse unmarshalledObject = new DatabaseResponse();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Collectors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CollectorShortInfoResponse, CollectorShortInfoResponseUnmarshaller>(CollectorShortInfoResponseUnmarshaller.Instance);
                    unmarshalledObject.Collectors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatabaseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatabaseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfSchemas", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfSchemas = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Server", targetDepth))
                {
                    var unmarshaller = ServerShortInfoResponseUnmarshaller.Instance;
                    unmarshalledObject.Server = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SoftwareDetails", targetDepth))
                {
                    var unmarshaller = DatabaseInstanceSoftwareDetailsResponseUnmarshaller.Instance;
                    unmarshalledObject.SoftwareDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DatabaseResponseUnmarshaller _instance = new DatabaseResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatabaseResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}