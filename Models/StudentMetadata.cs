using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolProjectMVC.Data;
public class StudentMetadadata
{
    [Display(Name ="First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name ="Last Name")]

    public string LastName { get; set; } = null!;
    [Display(Name ="Date of Birth")]

    public DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetadadata))]
public partial class Student{}