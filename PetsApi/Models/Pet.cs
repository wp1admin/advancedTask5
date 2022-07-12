using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetsApi.Models
{
    public enum TaskStatus : int
    {


        STARTED = 1,
        IN_PROGRESS = 2,
        COMPLETED = 3,
        FAILED = 4


    }
    public class Task
    {
        public int taskId { get; set; }
        public String description { get; set; }

        public String priority { get; set; }
        public TaskStatus taskStatus { get; set; }
        public int customerId { get; set; }
    }
}
