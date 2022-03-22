using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcess
{
    [ExternalTaskTopic("applicantlog")]
    
    public class ApplicantLogger : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine("Logged");
            Console.WriteLine("First Name={0}",externalTask.Variables["firstName"].Value);
            Console.WriteLine("Last Name={0}", externalTask.Variables["lastName"].Value);
            Console.WriteLine("MobileNo={0}", externalTask.Variables["mobileNo"].Value);
            Console.WriteLine("Age={0}", externalTask.Variables["age"].Value);
            Console.WriteLine("House={0}", externalTask.Variables["house"].Value);
            Console.WriteLine("Cibil Score={0}", externalTask.Variables["cibilScore"].Value);
        }
    }
}
