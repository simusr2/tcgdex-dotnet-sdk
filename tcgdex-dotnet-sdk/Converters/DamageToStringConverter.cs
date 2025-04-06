using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Net.Tcgdex.Sdk.Converters
{

    /// <summary>
    /// Converter for the damage value of an attack.
    /// </summary>
    public class DamageToStringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    return reader.GetString();
                case JsonTokenType.Number:
                    return reader.GetInt32().ToString();
                default:
                    return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}