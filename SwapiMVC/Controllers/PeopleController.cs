using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class PeopleController : Controller
    {
        private readonly HttpClient _httpClient;
        public PeopleController(IHttpClientFactory httpClientFactory)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
