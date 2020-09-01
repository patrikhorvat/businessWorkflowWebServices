using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace businessWorkflowRestServices.Models
{
    public class WorkflowTask
    {
        public int Id { get; set; }
        public BusinessWorkflow BusinessWorkflow { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}