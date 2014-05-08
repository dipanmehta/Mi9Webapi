using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mi9Project.Models;
using Mi9Project.Models.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Mi9WebApi.Controllers
{
    public class PayloadController : ApiController
    {
        private IPayloadRepository payloadRepository;
        public PayloadController()
        {
            payloadRepository = new Mi9PayloadRepository();
        }
        [HttpPost]
        public HttpResponseMessage Post(JObject jobject)
        {
            try
            {
                if (jobject != null)
                {
                    Payload actualPayload = jobject.ToObject<Payload>();
                    if (actualPayload != null && actualPayload.payload != null)
                    {
                        List<Show> shows = payloadRepository.processPayload(actualPayload);
                        return this.Request.CreateResponse(HttpStatusCode.OK, new { response = shows.Select(s => new { image = s.image.showImage, slug = s.slug, title = s.title }) });
                    }
                }
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, new { error = "Could not decode request: JSON parsing failed" });
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, new { error = "Could not decode request: JSON parsing failed" });
            }
        }

        public String Get()
        {
            return "";
        }
    }
}