using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcess
{

    [ExternalTaskTopic("loanadvice")]
    public class LoanAdviceTask : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine(externalTask.Variables["decision"].Value);
        }
    }
}
