namespace ChatGPT_API.Models
{

    public class ChatGPTResponseModel
    {
        public string id { get; set; } = string.Empty;
        public string @object { get; set; } = string.Empty;
        public int created { get; set; }
        public string model { get; set; } = string.Empty;
        public List<Choice>? choices { get; set; } 
        public Usage? usage { get; set; }
    }
    public class Choice
    {
        public string text { get; set; } = string.Empty;
        public int index { get; set; }
        public object logprobs { get; set; } = string.Empty;
        public string finish_reason { get; set; } = string.Empty;
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }

}
