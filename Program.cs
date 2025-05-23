using System;
using System.Collections.Generic;
using System.Media;

class Program
    {
        static void Main(string[] args)
        {
            // Set the console title
            Console.Title = "Cybersecurity Awareness Bot";

            // Play a voice greeting (currently commented out)
            AudioPlayer.PlayVoiceGreeting("greeting.wav");

            // Display ASCII logo and welcome message
            ConsoleUI.ShowAsciiArt();
            ConsoleUI.ShowWelcomeMessage();

            // Initialize chatbot and sentiment analyzer
            var chatEngine = new ChatEngine();
            var sentimentAnalyzer = new SentimentAnalyzer();

            // Main chatbot loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();

                // Read and clean user input
                string userInput = Console.ReadLine()?.Trim().ToLower();

                // Skip empty input
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please enter a valid input.");
                    continue;
                }

                // Exit condition
                if (userInput == "exit" || userInput == "quit")
                {
                    Console.WriteLine("Goodbye! Stay cyber-safe.");
                    break;
                }

                // Analyze user sentiment
                sentimentAnalyzer.Analyze(userInput);

                // Get chatbot response and display it
                string response = chatEngine.GetResponse(userInput);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CyberBot: " + response);
                Console.ResetColor();
            }
        }
    }

    class ChatEngine
    {
        // Memory for user preferences
        private string userName = null;
        private string favoriteTopic = null;
        private string lastTopic = null;

        // Main FAQ dictionary for known questions
        private Dictionary<string, string> cyberSecurityFAQs = new(StringComparer.OrdinalIgnoreCase)
        {
            { "what is malware", "Malware is software specifically designed to disrupt, damage, or gain unauthorized access to a computer system." },
            { "how to protect my password", "Use a strong, unique password with letters, numbers, symbols, and enable two-factor authentication." },
            { "what is a firewall", "A firewall acts as a barrier between your internal network and external threats, filtering traffic." },
            { "what is ransomware", "Ransomware is a type of malware that locks or encrypts your data and demands a ransom for its release." },
            { "how to stay safe online", "Avoid clicking unknown links, use antivirus software, and keep systems updated." },
            { "what is two-factor authentication", "2FA adds an extra layer of security by requiring a second form of verification beyond a password." },
            { "what is social engineering", "Social engineering is manipulating people into giving up confidential information." },
            { "how are you", "I'm just code, but I'm running well! How can I assist you today?" },
            { "who created you", "I was created by a developer to promote cybersecurity awareness!" },
            { "what is cybersecurity", "Cybersecurity is the practice of protecting systems, networks, and data from digital attacks." }
        };

        // Additional information on topics for follow-up responses
        private Dictionary<string, string> moreDetails = new(StringComparer.OrdinalIgnoreCase)
        {
            { "malware", "Malware includes viruses, worms, trojans, spyware, and more. It's often hidden in email attachments or software downloads." },
            { "password", "A strong password is long, random, and includes a mix of characters. Consider using a password manager." },
            { "firewall", "Firewalls can be hardware or software-based and help control incoming and outgoing network traffic." },
            { "ransomware", "Ransomware attackers often demand cryptocurrency payments and may threaten to leak data if unpaid." },
            { "phishing", "Phishing attacks often impersonate trusted institutions to steal data or install malware." },
            { "2fa", "Two-factor authentication may include biometrics, SMS codes, or authenticator apps." },
            { "social engineering", "Attackers exploit trust—posing as coworkers or authority figures to gather confidential info." },
            { "cybersecurity", "Cybersecurity also involves risk assessments, monitoring, penetration testing, and awareness training." }
        };

        // List of tips shown randomly for phishing-related queries
        private List<string> phishingTips = new()
        {
            "Don't click on suspicious links in emails or messages.",
            "Always verify the sender's email address before responding.",
            "Be cautious of urgent or threatening language in emails.",
            "Check URLs carefully — fake sites often look similar to real ones.",
            "Never share personal information through unsecured emails.",
            "Use two-factor authentication to reduce phishing risk.",
            "If unsure, contact the sender through a trusted method."
        };

        private Random rnd = new(); // Random number generator for selecting phishing tips

        public string GetResponse(string input)
        {
            // Save user's name
            if (input.StartsWith("my name is"))
            {
                userName = input.Replace("my name is", "").Trim();
                return $"Nice to meet you, {userName}!";
            }

            // Save user's favorite topic
            if (input.StartsWith("my favorite topic is"))
            {
                favoriteTopic = input.Replace("my favorite topic is", "").Trim();
                return $"Got it! I’ll remember that your favorite topic is {favoriteTopic}.";
            }

            // Recall user's favorite topic
            if (input.Contains("what is my favorite topic"))
            {
                return favoriteTopic != null ? $"Your favorite topic is {favoriteTopic}." : "You haven’t told me your favorite topic yet.";
            }

            // Provide phishing tips
            if (input.Contains("phishing"))
            {
                lastTopic = "phishing";
                int index = rnd.Next(phishingTips.Count);
                return $"Phishing Tip: {phishingTips[index]}";
            }

            // Search known FAQs for answers
            foreach (var question in cyberSecurityFAQs.Keys)
            {
                if (input.Contains(question))
                {
                    lastTopic = ExtractKeywordFromQuestion(question);
                    return cyberSecurityFAQs[question];
                }
            }

            // Provide additional info if a topic was recently discussed
            if (input.Contains("more information") || input.Contains("tell me more"))
            {
                if (!string.IsNullOrEmpty(lastTopic) && moreDetails.ContainsKey(lastTopic))
                {
                    return $"Here’s more info about {lastTopic}: {moreDetails[lastTopic]}";
                }
                else
                {
                    return "Please ask a specific question so I can provide more details.";
                }
            }

            // Handle greetings
            if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
                return $"Hello{(userName != null ? $", {userName}" : "")}! 👋 I'm here to help you stay cyber-safe.";

            // Provide help instructions
            if (input.Contains("help"))
                return "You can ask about phishing, malware, firewalls, password protection, social engineering, and more.";

            // Friendly bot reply
            if (input.Contains("how are you") || input.Contains("what's up"))
                return "I'm functioning at full capacity! What cybersecurity question do you have today?";

            // Default response for unknown input
            return "Hmm... I don't have an answer for that yet. Try asking about cybersecurity topics like phishing or passwords.";
        }

        // Helper method to extract topic keyword from the question string
        private string ExtractKeywordFromQuestion(string question)
        {
            if (question.Contains("malware")) return "malware";
            if (question.Contains("firewall")) return "firewall";
            if (question.Contains("ransomware")) return "ransomware";
            if (question.Contains("password")) return "password";
            if (question.Contains("two-factor")) return "2fa";
            if (question.Contains("social engineering")) return "social engineering";
            if (question.Contains("cybersecurity")) return "cybersecurity";
            return "general";
        }
    }

    class SentimentAnalyzer
    {
        // Lists of positive and negative words to analyze user sentiment
        private List<string> positiveWords = new() { "good", "great", "awesome", "happy", "love", "fantastic", "cool" };
        private List<string> negativeWords = new() { "bad", "terrible", "hate", "angry", "sad", "worried", "upset" };

        public void Analyze(string input)
        {
            int score = 0;

            // Count occurrences of positive words
            foreach (var word in positiveWords)
            {
                if (input.Contains(word)) score++;
            }

            // Count occurrences of negative words
            foreach (var word in negativeWords)
            {
                if (input.Contains(word)) score--;
            }

            // Display sentiment message based on score
            if (score > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You sound positive! 😊");
                Console.ResetColor();
            }
            else if (score < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You seem a bit down. I'm here to help. 💡");
                Console.ResetColor();
            }
        }
    }

    class ConsoleUI
    {
        // Show initial welcome instructions to the user
        public static void ShowWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHello! I'm CyberBot, your Cybersecurity Awareness Assistant.");
            Console.WriteLine("You can introduce yourself with 'My name is ...' or tell me your favorite topic!");
            Console.WriteLine("Ask me anything about cybersecurity or just say hi. Type 'exit' to quit.\n");
            Console.ResetColor();
        }

        // Display an ASCII banner/logo
        public static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
                                                                  
       ██████╗██╗  ██╗ █████╗ ████████╗    █████╗ ██╗    ██╗███████╗     
      ██╔════╝██║  ██║██╔══██╗╚══██╔══╝   ██╔══██╗██║    ██║██╔════╝     
      ██║     ███████║███████║   ██║█████╗███████║██║ █╗ ██║███████╗     
      ██║     ██╔══██║██╔══██║   ██║╚════╝██╔══██║██║███╗██║╚════██║     
      ╚██████╗██║  ██║██║  ██║   ██║      ██║  ██║╚███╔███╔╝███████║     
       ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝      ╚═╝  ╚═╝ ╚══╝╚══╝ ╚══════╝     

                  Welcome to the Chat Bot Awareness System!
");
            Console.ResetColor();
        }
    }

    class AudioPlayer
    {
        // Attempt to play a greeting audio file
        public static void PlayVoiceGreeting(string filePath)
        {
            try
            {
                // Uncomment to enable audio playback
                // SoundPlayer player = new SoundPlayer(filePath);
                // player.Load();
                // player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Voice greeting failed: " + ex.Message);
            }
        }
    }

