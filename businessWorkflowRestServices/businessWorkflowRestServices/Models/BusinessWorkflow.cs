using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace businessWorkflowRestServices.Models
{
    public class BusinessWorkflow
    {
        public int Id { get; set; }
        public WorkflowGroup Group { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }

    }
}