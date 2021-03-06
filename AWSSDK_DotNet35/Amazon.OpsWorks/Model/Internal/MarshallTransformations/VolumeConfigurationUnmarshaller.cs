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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// VolumeConfigurationUnmarshaller
      /// </summary>
      internal class VolumeConfigurationUnmarshaller : IUnmarshaller<VolumeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<VolumeConfiguration, JsonUnmarshallerContext>
      {
        VolumeConfiguration IUnmarshaller<VolumeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VolumeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            VolumeConfiguration volumeConfiguration = new VolumeConfiguration();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("MountPoint", targetDepth))
              {
                volumeConfiguration.MountPoint = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RaidLevel", targetDepth))
              {
                volumeConfiguration.RaidLevel = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NumberOfDisks", targetDepth))
              {
                volumeConfiguration.NumberOfDisks = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Size", targetDepth))
              {
                volumeConfiguration.Size = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeType", targetDepth))
              {
                volumeConfiguration.VolumeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Iops", targetDepth))
              {
                volumeConfiguration.Iops = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return volumeConfiguration;
        }

        private static VolumeConfigurationUnmarshaller instance;
        public static VolumeConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VolumeConfigurationUnmarshaller();
            return instance;
        }
    }
}
  
