using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBetter
{
    public partial class MainForm : Form
    {
        // Replace with your actual OpenAI API key
        private const string OpenAiApiKey = "PLACEHOLDER";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnImproveText_Click(object sender, EventArgs e)
        {
            // Retrieve text from the input TextBox
            string inputText = txtInput.Text;

            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(inputText))
            {
                lblOutput.Text = "Please enter some text.";
                return;
            }

            try
            {
                lblOutput.Text = "Improving text, please wait...";
                // Get the improved text from OpenAI API
                string improvedText = await GetImprovedTextFromOpenAI(inputText);

                // Display the improved text in the label
                lblOutput.Text = $"Improved Text: {improvedText}";
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                lblOutput.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetImprovedTextFromOpenAI(string inputText)
        {
            try
            {
                // Initialize RestClient with the correct OpenAI API endpoint
                var client = new RestClient("https://api.openai.com/v1/completions");

                // Set up the request
                var request = new RestRequest
                {
                    Method = Method.Post
                };

                // Add headers for authorization and content type
                request.AddHeader("Authorization", $"Bearer {OpenAiApiKey}");
                request.AddHeader("Content-Type", "application/json");

                // Create the JSON body for the request
                var body = new
                {
                    model = "gpt-3.5-turbo-instruct",
                    prompt = $"Please rewrite and improve the following text whilst maintaining its structural integrity; Do not add superfluous diction and withhold a similar vocabulary and vernacular:\n\n{inputText}",
                    max_tokens = 100,
                    temperature = 0.7
                };

                // Attach the body to the request
                request.AddJsonBody(body);

                // Execute the request
                var response = await client.ExecuteAsync(request);

                // Check if the response is successful
                if (!response.IsSuccessful)
                {
                    throw new Exception($"Request failed with status: {response.StatusCode}, Error: {response.ErrorMessage}");
                }

                // Parse the JSON response
                var jsonResponse = JObject.Parse(response.Content);
                var improvedText = jsonResponse["choices"]?[0]?["text"]?.ToString().Trim();

                return improvedText ?? "No response from OpenAI";
            }
            catch (Exception ex)
            {
                // Throw a new exception to show a more informative error message
                throw new Exception($"Error while connecting to OpenAI: {ex.Message}");
            }
        }
    }
}