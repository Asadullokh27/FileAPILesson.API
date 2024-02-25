using FileAPILesson.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Domain.Entities.DTOs
{
    public class PersonDTO
    {

        public string FullName { get; set; }
        public int age { get; set; }
        public Status status { get; set; }

    }
}
