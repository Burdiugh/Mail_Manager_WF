using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Manager_WF
{
    [Serializable]
    public class Letter
    {
        public List<string> files = new List<string>();
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"From: {From}\n " +
                $"To: {To}\n " +
                $" Subject: {Subject}\n\n ";
        }
    }
}
