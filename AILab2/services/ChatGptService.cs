using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AILab2.services
{
    internal class ChatGptService
    {
        private static string TOKEN = "";

        // Open AI konfiguration
        private static string OPEN_API_URI = "https://api.openai.com/v1/chat/completions";

        // SmartLearning konfiguration
        private static string SMART_LEARNING_URI = $"https://smartopenaiproxy.azurewebsites.net/api/OpenAIProxy?key={TOKEN}";

        // Vælg konfiguration
        private static string URI = SMART_LEARNING_URI;

        public ChatGptService()
        {
            if (TOKEN == "")
            {
                throw new Exception("Du skal sætte en token i ChatGptService.cs for at bruge programmet.");
            }
        }

        public async Task<string[]> PromptArray(String prompt)
        {
            prompt += ". Returner svaret som et JSON-array i dette format: [\"svar1\", \"svar2\", \"svar3\"]";

            for (int retries = 0; retries < 3; retries++)
            {
                try
                {
                    string response = await promptGpt4Async(prompt);
                    string[] result = JsonConvert.DeserializeObject<String[]>(response);
                    if (result != null)
                    {
                        return result;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                };
            }
            return new string[] { };

        }


        public static Task<string> promptGpt4Async(string prompt)
        {
            var messages = new Message[]
            {
                    new Message()
                    {
                        role = "user",
                        content = prompt
                    }
            };

            return promptGpt4Async(messages);

        }

        private static async Task<string> promptGpt4Async(Message[] messages)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TOKEN);
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(URI);

            var json = JsonConvert.SerializeObject(new ChatRequest()
            {
                model = "gpt-3.5-turbo",
                messages = messages,
            });

            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            client.Timeout = TimeSpan.FromSeconds(120);
            var response = await client.SendAsync(request);
            var responseText = await response.Content.ReadAsStringAsync();

            ChatResponse chatResponse = JsonConvert.DeserializeObject<ChatResponse>(responseText);

            string text = chatResponse.choices[0].message.content;
            return text;
        }

    }

    internal class ChatRequest
    {
        public string model { get; set; }
        public Message[] messages { get; set; }
    }

    internal class Message
    {
        public string role { get; set; }
        public string content { get; set; }
    }

    internal class ChatResponse
    {
        public string id { get; set; }
        public string _object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public Usage usage { get; set; }
        public Choice[] choices { get; set; }
    }

    internal class Usage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
    }

    internal class Choice
    {
        public Message message { get; set; }
        public string finish_reason { get; set; }
        public int index { get; set; }
    }


}
