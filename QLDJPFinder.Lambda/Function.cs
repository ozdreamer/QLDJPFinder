using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using QLDJPFinder.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace QLDJPFinder.Lambda
{
    public class Function
    {
        private LambdaResponse lambdaResponse;

        private JPFinderAPI finder;

        public Function()
        {
            this.finder = new JPFinderAPI();

            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("QLDJPFinder.Lambda.Scripts.SkillResponses.json"))
            {
                using (var reader = new StreamReader(stream))
                {
                    this.lambdaResponse = JsonConvert.DeserializeObject<LambdaResponse>(reader.ReadToEnd());
                }
            }
        }

        public SkillResponse FunctionHandler(SkillRequest request, ILambdaContext context)
        {
            switch (request.Request)
            {
                case LaunchRequest launchRequest:
                    return CreateResponse(this.lambdaResponse.LaunchResponse);

                case IntentRequest intentRequest:
                    return GetIntentResponse(intentRequest);

                case SessionEndedRequest sessionEndedRequest:
                    return CreateResponse(this.lambdaResponse.SessionEndedResponse, true);

                default:
                    return CreateResponse(this.lambdaResponse.RepromptResponse);
            }
        }

        private SkillResponse GetIntentResponse(IntentRequest request)
        {
            if (request.Intent.Name == "SearchIntent")
            {
                var slots = request.Intent.Slots;

                string area = string.Empty;
                if (slots.ContainsKey("Area"))
                {
                    area = slots["Area"].Value;
                }

                var locations = this.finder.GetJPList(area, 5).Result;
                if (!locations.Any())
                {
                    return this.CreateResponse(this.lambdaResponse.NotFoundResponse);
                }

                int postCode;
                var pluralText = locations.Count > 1 ? "s" : string.Empty;
                var locationText = int.TryParse(area, out postCode) ? string.Empty : $" in {area}";
                var responseText = $"Found {locations.Count} location{pluralText}{locationText}.";
                responseText += locations.Aggregate(string.Empty, (r, e) => { r += $"{Environment.NewLine}{e.Title}."; return r; });

                return this.CreateResponse(responseText);
            }
            else if (request.Intent.Name == this.lambdaResponse.CancelIntent || request.Intent.Name == this.lambdaResponse.StopIntent)
            {
                return this.CreateResponse(this.lambdaResponse.SessionEndedResponse);
            }

            return CreateResponse(this.lambdaResponse.RepromptResponse);
        }

        private SkillResponse CreateResponse(string outputSpeech, bool shouldEndSession = false, bool shouldReprompt = true)
        {
            var response = new ResponseBody
            {
                OutputSpeech = new PlainTextOutputSpeech { Text = outputSpeech },
                ShouldEndSession = shouldEndSession
            };

            if (shouldReprompt)
            {
                response.Reprompt = new Reprompt
                {
                    OutputSpeech = new PlainTextOutputSpeech { Text = this.lambdaResponse.RepromptResponse }
                };
            }

            return new SkillResponse
            {
                Response = response,
                Version = "1.0"
            };
        }
    }
}