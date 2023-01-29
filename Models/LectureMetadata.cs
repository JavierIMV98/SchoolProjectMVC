using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolProjectMVC.Data;
public class LectureMetadadata
{
    [Display(Name ="First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name ="Last Name")]

    public string LastName { get; set; } = null!;
}

[ModelMetadataType(typeof(LectureMetadadata))]
public partial class Lecture{}