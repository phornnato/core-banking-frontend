using coreBankSystemFrontend.Models;

namespace coreBankSystemFrontend.Services
{
    public class AdminApiService
    {
        private readonly HttpClient _httpClient;

        public AdminApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private string apiUrl = "http://localhost:8080/auth/api/admin";

        //get all admin 
        public async Task<List<Admin>> GetAdmins()
        {
            return await _httpClient.GetFromJsonAsync<List<Admin>>(apiUrl);
        }

        public async Task<Admin> GetAdmin(long id)
        {
            return await _httpClient.GetFromJsonAsync<Admin>($"{apiUrl}/{id}");
        }

        public async Task Create(Admin admin)
        {
             await _httpClient.PostAsJsonAsync($"{apiUrl}", admin);    
        }

        public async Task Update(long id, Admin admin)
        {
            await _httpClient.PostAsJsonAsync($"{apiUrl}/edit/{id}", admin);
        }

        public async Task Delete(long id)
        {
            await _httpClient.PostAsync($"{apiUrl}/delete/{id}", null);
        }
    }
}