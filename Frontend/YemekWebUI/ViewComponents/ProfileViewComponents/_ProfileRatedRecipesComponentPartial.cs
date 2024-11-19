﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YemekUygulamasıDto.RecipeDtos;

namespace YemekWebUI.ViewComponents.ProfileViewComponents
{
    public class _ProfileRatedRecipesComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ProfileRatedRecipesComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            //bunları yazıyorum ama sanırım gerek olmuyor ya bir ara dene.
            ViewBag.userId = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7092/api/Rate/byuser?id=" + id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var JsonData=await responseMessage.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<List<ResultRatedRecipeDto>>(JsonData);
                return View(value);
            }
            return View();

        }
    }
}