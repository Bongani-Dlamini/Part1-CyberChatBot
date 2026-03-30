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
                "Antivirus software is a program that scans, detects, and removes viruses and other malware from your computer.",                    // 0
                "Ransomware is a type of malware that locks your files until you pay a 'ransom' to the hacker.",                                     // 1
                "Spyware is software that secretly records what you do on your computer, like stealing your passwords.",                             // 2
                "Keyloggers are tools that record every single key you press on your keyboard to steal login details.",                              // 3
                "A Trojan is a malicious program disguised as something useful (like a free game) to trick you into installing it.",                 // 4
                "Computer viruses are programs that copy themselves and spread to other files to damage your system.",                               // 5
                "Malware is a general term for any 'Malicious Software' designed to harm or exploit your device.",                                  // 6
                "These are fake emails that look like they are from your bank or Netflix, but they want to steal your password.",                    // 7
                "Phishing is a scam where criminals trick you into giving them your private information.",                                           // 8
                "2FA (or MFA) is when you need a second step to log in, like a code sent to your cell phone.",                                      // 9
                "A strong password has at least 12 characters, including numbers, symbols, and capital letters.",                                   // 10
                "Never use the same password for two different accounts! Use a password manager to stay safe.",                                      // 11
                "A firewall acts like a digital wall that monitors network traffic to block unauthorized access.",                                   // 12
                "A Virtual Private Network (VPN) encrypts your internet connection to keep your location and data private.",                        // 13
                "This is when hackers use human psychology to trick you into revealing secrets, like pretending to be tech support.",                // 14
                "This is when someone steals your personal info (ID number, name) to open bank accounts or take loans in your name.",               // 15
                "Encryption turns your data into a secret code so that only people with the right key can read it.",                                // 16
                "A data breach happens when a company's database is hacked and customer information is leaked online.",                             // 17
                "Cyberbullying is using the internet or social media to harass, threaten, or shame another person.",                                // 18
                "The 'S' in HTTPS stands for 'Secure'. It means your connection to that website is private and encrypted.",                         // 19
                "Never log into your bank or private accounts on public Wi-Fi (like at a mall) as hackers can 'sniff' your data.",                  // 20
                "A DDoS attack is when hackers flood a website with so much fake traffic that the site crashes and stops working.",                  // 21
                "Never share your ID number, home address, or phone number with strangers online.",                                                 // 22
                "Cookies are small files websites save on your computer to remember your settings or track your browsing.",                         // 23
                "This is when someone literally looks over your shoulder while you type your PIN or password at an ATM or laptop.",                 // 24
                "A brute force attack is when a hacker uses a computer to guess thousands of password combinations until they get yours.",          // 25
                "Always keep a copy of your important files on an external drive or cloud service in case your computer breaks.",                   // 26
                "Disconnect from the internet, run an antivirus scan, and change all your passwords immediately.",                                  // 27
                "If an offer sounds too good to be true (like winning a lottery you never entered), it is definitely a scam.",                      // 28
                "Updates fix security holes. Always click 'Update' on your phone and laptop to stay protected."                                     // 29
            };
        }

        // Search logic
        public string GetAnswerForUser(string userInput, UIHelper gui)
        {
            string lowerInput = userInput.ToLower();

            // Handles the topics keyword that the user will use in case they do not know what to ask the bot.
            if (lowerInput == "topics")
            {
                gui.ShowAvailableTopics();
                return "Which of those topics would you like to know more about?";
            }

            return "";
        }
    }
}