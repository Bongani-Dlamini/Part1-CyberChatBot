using System;
using System.Collections.Generic;
using System.Text;

namespace Part1_CyberChatBot
{
    internal class CyberQuestions
    {
        // Used parallel to store the questions and the answers
        public string[] Questions;
        public string[] Answers;

        public void LoadQuestions()
        {
            // The 30 Cybersecurity Questions/Answers that the user will be able to ask the bot.
            Questions = new string[]
            {
                "antivirus",
                "ransomware",
                "spyware",
                "keyloggers",
                "trojan horse",
                "viruses",
                "malware",
                "phishing emails",
                "phishing",
                "two-factor auth",
                "strong passwords",
                "passwords",
                "firewalls",
                "vpn",
                "social engineering",
                "identity theft",
                "encryption",
                "data breaches",
                "cyberbullying",
                "https",
                "public wi-fi",
                "ddos attacks",
                "personal information",
                "cookies",
                "shoulder surfing",
                "brute force",
                "data backups",
                "what to do if hacked",
                "online scams",
                "software updates"
            };

            Answers = new string[]
            {
                "Antivirus software is a program that scans, detects, and removes viruses and other malware from your computer.",
                "Ransomware is a type of malware that locks your files until you pay a 'ransom' to the hacker.",
                "Spyware is software that secretly records what you do on your computer, like stealing your passwords.",
                "Keyloggers are tools that record every single key you press on your keyboard to steal login details.",
                "A Trojan is a malicious program disguised as something useful (like a free game) to trick you into installing it.",
                "Computer viruses are programs that copy themselves and spread to other files to damage your system.",
                "Malware is a general term for any 'Malicious Software' designed to harm or exploit your device.",
                "These are fake emails that look like they are from your bank or Netflix, but they want to steal your password.",
                "Phishing is a scam where criminals trick you into giving them your private information.",
                "2FA (or MFA) is when you need a second step to log in, like a code sent to your cell phone.",
                "A strong password has at least 12 characters, including numbers, symbols, and capital letters.",
                "Never use the same password for two different accounts! Use a password manager to stay safe.",
                "A firewall acts like a digital wall that monitors network traffic to block unauthorized access.",
                "A Virtual Private Network (VPN) encrypts your internet connection to keep your location and data private.",
                "This is when hackers use human psychology to trick you into revealing secrets, like pretending to be tech support.",
                "This is when someone steals your personal info (ID number, name) to open bank accounts or take loans in your name.",
                "Encryption turns your data into a secret code so that only people with the right key can read it.",
                "A data breach happens when a company's database is hacked and customer information is leaked online.",
                "Cyberbullying is using the internet or social media to harass, threaten, or shame another person.",
                "The 'S' in HTTPS stands for 'Secure'. It means your connection to that website is private and encrypted.",
                "Never log into your bank or private accounts on public Wi-Fi (like at a mall) as hackers can 'sniff' your data.",
                "A DDoS attack is when hackers flood a website with so much fake traffic that the site crashes and stops working.",
                "Never share your ID number, home address, or phone number with strangers online.",
                "Cookies are small files websites save on your computer to remember your settings or track your browsing.",
                "This is when someone literally looks over your shoulder while you type your PIN or password at an ATM or laptop.",
                "A brute force attack is when a hacker uses a computer to guess thousands of password combinations until they get yours.",
                "Always keep a copy of your important files on an external drive or cloud service in case your computer breaks.",
                "Disconnect from the internet, run an antivirus scan, and change all your passwords immediately.",
                "If an offer sounds too good to be true (like winning a lottery you never entered), it is definitely a scam.",
                "Updates fix security holes. Always click 'Update' on your phone and laptop to stay protected."
            };
        }

        // Search logic
        public string GetAnswerForUser(string userInput, UIHelper gui)
        {
            string lowerInput = userInput.ToLower();

            // Handles the topics keyword that the user will use in case they do not know what to ask the bot.
            // also i moved this bit of code from the UIHelper class, because the showavailabletopics method was giving me errors, so i removed it and moved the code here.
            if (lowerInput == "topics")
            {
                // Displays all available topics
                gui.TypewriterEffect("Here are the topics you can ask me about:", ConsoleColor.Cyan);
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < Questions.Length; i++)
                {
                    Console.WriteLine($"  • {Questions[i]}");
                }
                Console.ResetColor();
                return "Which of those topics would you like to know more about?";
            }

            // This checks the conversation responses that the user can ask the bot.
            Responses responses = new Responses();
            responses.LoadResponses();
            string conversationReply = responses.GetConversationResponse(lowerInput);
            if (conversationReply != null)
            {
                return conversationReply;
            }

            // This is the main search logic for the bot.
            for (int i = 0; i < Questions.Length; i++)
            {
                if (lowerInput.Contains(Questions[i]))
                {
                    return Answers[i];
                }
            }

            // responds with this message if the user input does not match the relevance of the questions.
            return "I didn't quite understand that. Tip: Type 'topics' to see what I know, or type 'exit' to quit.";
        }
    }
}