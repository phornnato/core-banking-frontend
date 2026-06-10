using coreBankSystemFrontend.Models;
using System.Text;
public class RoleApiService
{
    private readonly HttpClient _httpClient;

    public RoleApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private string apiUrl = "http://localhost:8080/api/roles";

    public async Task<List<RoleViewModel>> GetRoles()
    {
        return await _httpClient.GetFromJsonAsync<List<RoleViewModel>>(apiUrl);
    }

    public async Task<RoleViewModel> GetRole(long id)
    {
        return await _httpClient.GetFromJsonAsync<RoleViewModel>($"{apiUrl}/{id}");
    }

    public async Task Create(RoleViewModel role)
    {
        await _httpClient.PostAsJsonAsync($"{apiUrl}", role);
    }

    public async Task Update(long id, RoleViewModel role)
    {
        await _httpClient.PostAsJsonAsync($"{apiUrl}/edit/{id}", role);
    }

    public async Task Delete(long id)
    {
        await _httpClient.PostAsync($"{apiUrl}/delete/{id}", null);
    }

}