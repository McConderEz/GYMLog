using GYMLog.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GYMLog.BL.Controller
{
    /// <summary>
    /// Реализация класса DictionaryFoodDoubleJsonConverter для сериализации активности "Принять пищу"
    /// </summary>
    public class DictionaryFoodDoubleJsonConverter :JsonConverter<Dictionary<Food, double>>
    {

        public override Dictionary<Food, double>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException($"JsonTokenType was of type {reader.TokenType}, only objects are supported");
            }

            var dictionary = new Dictionary<Food,double>();

            while(reader.Read())
            {
                if(reader.TokenType == JsonTokenType.EndObject)
                {
                    return dictionary;
                }

                if(reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException("JsonTokenType was not PropertyName");
                }

                var propertyName = reader.GetString();



                if (string.IsNullOrWhiteSpace(propertyName))
                {
                    throw new JsonException("Failed to get property name");
                }

                reader.Read();

                var food = JsonSerializer.Deserialize<Food>(reader.GetString(), options);

                var value = reader.GetDouble();

                dictionary.Add(food, value);
            }

            return dictionary;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<Food, double> value, JsonSerializerOptions options)
        {
            if(value is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();

            foreach(var pair in value)
            {
                writer.WritePropertyName(pair.Key.Name);
                writer.WriteNumberValue(pair.Value);
            }

            writer.WriteEndObject();
        }

       

        public override bool CanConvert(Type typeToConvert)
        {      
            return typeToConvert == typeof(Dictionary<Food, double>);
        }

        

    }
}
