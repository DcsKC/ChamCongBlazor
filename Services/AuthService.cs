using System.Net.Http.Json;
using ChamCongBlazor.Models;

public class AuthService
{
    private readonly HttpClient _httpClient;
    public Employee? CurrentUser { get; private set; }

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> LoadUserAsync(string employeeCode)
    {
        CurrentUser = await _httpClient.GetFromJsonAsync<Employee>($"api/employees/{employeeCode}");
        return CurrentUser != null;
    }

    public bool IsManager => CurrentUser?.Rules == "Manager"; // Sửa lại ở đây
}
