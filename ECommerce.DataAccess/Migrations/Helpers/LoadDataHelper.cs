using System.Collections.Generic;
using System.IO;
using ECommerce.Core.Entities;
using System.Text.Json;

namespace ECommerce.DataAccess.Migrations.Helpers
{
    public static class LoadDataHelper
    {
        public static List<T> GetEntityListFromJsonFile<T>(string path)
            where T : class, IEntity, new()
        {
            StreamReader reader = new StreamReader(path);
            string fileText = reader.ReadToEnd();
            return JsonSerializer.Deserialize<List<T>>(fileText);
        }
    }
}