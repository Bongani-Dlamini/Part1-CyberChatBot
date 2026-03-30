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

        }
    }
}
