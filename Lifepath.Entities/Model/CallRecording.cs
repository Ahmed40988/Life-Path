using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifepath.Entities.Model
{
    public class CallRecording
    {
        [Key] 
        public int RecordingID { get; set; }
        public string DoctorID { get; set; }
        public string PatientID { get; set; }
        public int SessionID { get; set; }
        public string RecordingPath { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public string RecordingType { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }

}
