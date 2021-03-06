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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// WorkflowExecutionUnmarshaller
      /// </summary>
      internal class WorkflowExecutionUnmarshaller : IUnmarshaller<WorkflowExecution, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecution, JsonUnmarshallerContext>
      {
        WorkflowExecution IUnmarshaller<WorkflowExecution, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecution Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecution workflowExecution = new WorkflowExecution();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                workflowExecution.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("runId", targetDepth))
              {
                workflowExecution.RunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecution;
        }

        private static WorkflowExecutionUnmarshaller instance;
        public static WorkflowExecutionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionUnmarshaller();
            return instance;
        }
    }
}
  
