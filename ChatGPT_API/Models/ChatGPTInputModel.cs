namespace ChatGPT_API.Models
{
    public class ChatGPTInputModel
    {
            public string model { get; set; } = string.Empty;
            public string prompt { get; set; } = string.Empty;
            public int max_tokens { get; set; }
            public decimal temperature { get; set; }

        public ChatGPTInputModel(string prompt)
        {
            this.prompt = $"Correct this english phrase: {prompt}";
            temperature = 0.2m;
            max_tokens = 1000;
            model = "text-davinci-003";
        }
    }
}
