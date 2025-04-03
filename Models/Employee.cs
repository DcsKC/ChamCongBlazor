namespace ChamCongBlazor.Models { 
public class Employee
{
    public int Id { get; set; }
    public string EmployeeCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Rules { get; set; } = "Employee";

    // Liên kết với bảng chấm công và lịch làm việc
    public ICollection<ChamCong> ChamCongs { get; set; } = new List<ChamCong>();
}
}