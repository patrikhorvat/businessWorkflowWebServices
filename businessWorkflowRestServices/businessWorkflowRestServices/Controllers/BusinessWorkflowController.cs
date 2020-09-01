using businessWorkflowRestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace businessWorkflowRestServices.Controllers
{
    [RoutePrefix("api/business-workflow")]
    public class BusinessWorkflowController : ApiController
    {
        // GET: api/BusinessWorkflow
        public IEnumerable<BusinessWorkflow> Get()
        {
            var workflowList = new List<BusinessWorkflow>();
            for (int i = 0; i > 5; i++) 
            {
                BusinessWorkflow businessWorkflow = new BusinessWorkflow()
                {
                    Id = i,
                    Description = $@"Sample description - {i}",
                    Title = $@"Sample name - {i}",
                    Group = new WorkflowGroup() 
                    {
                        Id = i+10,
                        Name = $@"Group name - {i+10}"
                    },
                    Label = $@"Group Label - {i+10}"
                };
                workflowList.Add(businessWorkflow);
            }
            return workflowList;
        }

        // GET: api/BusinessWorkflow/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var bf = new BusinessWorkflow()
            {
                Id = 11,
                Description = $@"Sample description",
                Title = $@"Sample name",
                Group = new WorkflowGroup()
                {
                    Id = 10,
                    Name = $@"Group name"
                },
                Label = $@"Group Label"
            };

            return Ok(bf);
        }

        // POST: api/BusinessWorkflow
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BusinessWorkflow/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BusinessWorkflow/5
        public void Delete(int id)
        {
        }
    }
}
