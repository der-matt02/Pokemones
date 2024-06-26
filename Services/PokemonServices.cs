﻿using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Pokemones.Services
{
    internal class PokemonServices
    {
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);

            // Debug.WriteLine("SIII");
            // Debug.WriteLine(json);
            return lista_pokemons.results;
        }
    }
}
