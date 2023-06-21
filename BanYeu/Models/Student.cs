using System.ComponentModel.DataAnnotations;

namespace BanYeu.Models;

public class Student

{
    [Key]
    [Display(Name = "Mã SV")]
    public string StudentID { get; set; }

    [Display(Name = "Tên SV")]
    public string StudentName { get; set; }

    [Display(Name = "Địa chỉ")]
    public string Adress { get; set; }

}