using MauiAppBuscaCepLocal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MauiAppBuscaCepLocal.Services
{
    public class DataServiceCep
    {
        public static async Task<Endereco?> GetEnderecoByCep(string Cep)
        {
            Endereco? end;

            using (HttpClient client = new HttpClient())
            {
                // 10.0.2.2
                HttpResponseMessage response = await client.GetAsync("http://localhost:8000/endereco/by-cep?cep=" + Cep);

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    end = JsonConvert.DeserializeObject<Endereco?>(json);
                }
                else
                {
                    throw new Exception(response.RequestMessage.Content.ToString());
                }
            }

            return end;
        }
    }
}
