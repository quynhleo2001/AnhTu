using System.ComponentModel.DataAnnotations;

namespace BanYeu.Models;

public class Employee
{
    [Key]
    [Display(Name = "Mã NV")]
    public string EmployeeID { get; set; }
    [Display(Name = "Tên NV")]
    public string EmployeeName { get; set; }
    [Display(Name = "Địa chỉ")]
    public string Adress { get; set; }

}