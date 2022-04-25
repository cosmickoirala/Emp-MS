using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Class Assigned")]
    public string Code { get; set; }
    [Display(Name = "Address")]
    public string Description { get; set; }
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; }
    public List<Person> People { get; set; }
}