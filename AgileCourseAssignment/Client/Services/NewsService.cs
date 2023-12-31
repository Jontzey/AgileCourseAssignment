﻿using AgileCourseAssignment.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace AgileCourseAssignment.Client.Services
{
    public class NewsService:INewsService
    {
        private readonly HttpClient httpClient;
        public List<News> AllNews { get; set; } = new();

       
        public NewsService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<List<News>> GetNews()
        {
            var response = await httpClient.GetAsync("/api/news");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<News>>();
            }

            return null;
        }
    }
}
