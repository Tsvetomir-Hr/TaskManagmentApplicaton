﻿namespace TaskManagement.DTOs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TaskDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatedOn { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
