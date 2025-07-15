using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoan.models
{
    internal class Record
    {
        private int id;
        private string dateRecord;
        private string startTime;
        private string endTime;
        private long employeeId;
        private int keyId;
        private string status;

        public Record()
        {
        }

        public Record(int id, string dateRecord, string startTime, string endTime, long employeeId, int keyId, string status)
        {
            this.id = id;
            this.dateRecord = dateRecord;
            this.startTime = startTime;
            this.endTime = endTime;
            this.employeeId = employeeId;
            this.keyId = keyId;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string DateRecord { get => dateRecord; set => dateRecord = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public long EmployeeId { get => employeeId; set => employeeId = value; }
        public int KeyId { get => keyId; set => keyId = value; }
        public string Status { get => status; set => status = value; }
    }
}
