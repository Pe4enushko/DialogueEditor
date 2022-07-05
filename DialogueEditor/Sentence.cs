using System.Text.Json.Serialization;
namespace DialogueEditor
{
    public class Sentence
    {
        public Sentence(string speaker, string text)
        {
            Speaker = speaker;
            Text = text;
        }

        [JsonInclude]
        public string Speaker { get; set; } = "";
        [JsonInclude]
        public string Text { get; set; } = "";
    }
}