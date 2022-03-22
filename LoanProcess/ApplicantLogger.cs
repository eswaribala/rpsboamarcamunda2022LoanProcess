using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcess
{
    [ExternalTaskTopic("logger")]
    
    public class ApplicantLogger : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine("Logged");
            Console.WriteLine("First Name={0}",externalTask.Variables["firstName"].Value);
        }
    }
}
