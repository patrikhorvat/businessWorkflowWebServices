using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace businessWorkflowRestServices.Models
{
    public class WorkflowLink
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public BusinessWorkflow BusinessWorkflow { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}