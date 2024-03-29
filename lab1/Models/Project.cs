﻿using System.ComponentModel.DataAnnotations;

namespace Comp2139_labs.Models
{
    public class Project
    {

        public int ProjectId { get; set; }


        [Required]
        public required string Name { get; set; }


        public string? Description { get; set; }


        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }


        public string? Status { get; set; }

    }

	}

