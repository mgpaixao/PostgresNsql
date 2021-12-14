using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace PostgresNsql.Models
{
    public class DataModel : IDisposable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int idade { get; set; }

        public JsonDocument Data { get; set; }
        public void Dispose() => Data?.Dispose();
    }
}
