using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveAgency
{
    class Request
    {
        public int id { get; set; }
        public int serviceId { get; set; }
        public string additionalInfo { get; set; }
        public int senderId { get; set; }
        public RequestStatus status { get; set; }
        public DateTime date { get; set; }

        public enum RequestStatus
        {
            inQueue,
            inProces,
            isDone,
            isBad
        }
    }
}
