using MauiAppBuscaCepLocal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBuscaCepLocal.Services
{
    public class DataServiceCep
    {
        public static async Task<Endereco?> GetEnderecoAsyncByCep (string Cep)
        {
            Endereco? end;

            using (HttpClient client = new HttpClient ()) 
            {
                // 10.0.2.2
                HttpResponseMessage response = await client.GetAsync("http://10.0.2.2:8000/endereco/by-cep?cep=" + cep);
                
                if (response.IsSuccessStatusCode) 
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
                
            }
        }
}
