using System;
using System.Collections.Generic;

namespace QLDJPFinder.Lambda
{
    public class LambdaResponse
    {
        public LambdaResponse()
        {
            this.IntentResponses = new List<IntentResponse>();
        }

        public List<IntentResponse> IntentResponses { get; set; }
        public string LaunchResponse { get; set; }
        public string SessionEndedResponse { get; set; }
        public string RepromptResponse { get; set; }
        public string NotFoundResponse { get; set; }
        public string StopIntent { get; set; }
        public string CancelIntent { get; set; }

        [Serializable]
        public class IntentResponse
        {
            public string Intent { get; set; }
            public string Response { get; set; }
        }
    }
}
