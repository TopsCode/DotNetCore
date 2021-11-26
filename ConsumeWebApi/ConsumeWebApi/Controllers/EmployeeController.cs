using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumeWebApi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HttpClient client = null;
        private string employeeApiUrl = "";

        public EmployeeController(HttpClient client, IConfiguration config)
        {
            this.client = client;
            employeeApiUrl = config.GetValue<string>("AppSettings:EmployeeApiUrl");
        }
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(employeeApiUrl);
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Employee> data = JsonSerializer.Deserialize<List<Employee>>(stringData, options);

            return View(data);
        }

        public async Task<IActionResult> Details(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Employee data = JsonSerializer.Deserialize<Employee>(stringData, options);

            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(employeeApiUrl, contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Inserted Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Employee obj = JsonSerializer.Deserialize<Employee>(stringData, options);

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                string stringData = JsonSerializer.Serialize(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"{employeeApiUrl}/{obj.emp_id}", contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Employee Updated Successfully!";
                }
                else
                {
                    ViewBag.Message = "Error while calling Web Api!";
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{employeeApiUrl}/{id}");
            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            Employee obj = JsonSerializer.Deserialize<Employee>(stringData, options);

            return View(obj);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{employeeApiUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                ViewBag.Message = "Employee Deleted Successfully!";
            }
            else
            {
                ViewBag.Message = "Error while calling Web Api!";
            }

            return RedirectToAction("Index");
        }
    }
}
