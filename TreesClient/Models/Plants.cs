using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TreesClient.Models
{
  public class Plant
  {
    public int PlantId { get; set; }
    public string Strain { get; set; }
    public string Type { get; set; }
    public string Farm { get; set; }
    public string Description { get; set; }

    public static List<Plant> GetPlants()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Plant> plantList = JsonConvert.DeserializeObject<List<Plant>>(jsonResponse.ToString());

      return plantList;
    }
  }
}