using System;

namespace eCampus.COMMON
{
    public class OperationResult
    {
        public bool Success { get; set; }
        private IList<string> Messages { get; set; }
        public OperationResult()
        {
            Messages = new List<string>(); // create object instance
        }

        public void AddMessage(string message){
            Messages.Add(message); // add message to internal repo
        }
    }
}
