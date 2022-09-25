using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Newtonsoft.Json;

//https://jsonplaceholder.typicode.com/ - API fake
namespace Controllers
{
    [ApiController]
    [Route("api")]
    public class ConsumerController : ControllerBase
    {

        //Instancia o objeto HttpClient
        HttpClient client = new HttpClient{ BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")};
        //  client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");


        //consumindo a API fake - https://jsonplaceholder.typicode.com/users 
        [HttpGet]
        [Route("listar")] //http://localhost:5000/api/listar
        public async Task<IActionResult> Consume()
        {

           var response = await client.GetAsync("users"); //users é o endpoint

            // se a resposta for 200
            if (response.IsSuccessStatusCode){
                 
             var result = await response.Content.ReadAsStringAsync(); // ler o conteudo da resposta

            // List<User> usuarios = JsonConvert.DeserializeObject<List<User>>(result); // deserializar o conteudo da resposta

                return Ok(JsonConvert.DeserializeObject<List<User>>(result));// retorna o conteudo da resposta
            }
            else
            {

                return BadRequest(); // se não for 200
            }
        }


        //trasforma o conteudo da resposta em um objeto
        [HttpGet]
        [Route("buscar/{id}")] //https://localhost:5001/api/buscar/1
         public async Task<IActionResult> converterJson([FromRoute]int id){

            var response = await client.GetAsync("users"); //users é o endpoint

            var result = await response.Content.ReadAsStringAsync(); // ler o conteudo da resposta

                     //dotnet add package Newtonsoft.Json --version 13.0.1
             var users = JsonConvert.DeserializeObject<List<User>>(result);   //converte o json para objeto List<User>

              

              //  var user = users.Find(x => x.Id == id); // filtra o objeto pelo id

               if (users != null) // se o objeto não for nulo
                {

                 // User usuario = users.FirstOrDefault(x => x.Id == id); // procura o usuario com id 1

                    //foreach (var user in users) // percorre o objeto
                    // {
                    //    Console.WriteLine(user.Name); // imprime o nome do usuario
                   // }

                    return Ok(users.FirstOrDefault(x => x.Id == id)); // retorna o objeto

                } else
                {
                    return BadRequest(); // se o objeto for nulo
                }
         }



    }
}