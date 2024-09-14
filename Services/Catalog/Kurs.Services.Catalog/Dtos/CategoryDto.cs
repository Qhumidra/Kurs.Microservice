using Kurs.Services.Catalog.Model;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Kurs.Services.Catalog.Dtos
{
    public class CategoryDto
    {
        public string Name { get; set; }
    }
}
