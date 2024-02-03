/*Edwin Hared Albancando Robles*/
using System;

/* class Entry will store date, prompt and content.*/

class Entry
    {
        public string _date;
        public string _prompt;
        public string _content;
        
/* declared the attributes used to run the functions*/
        public Entry(string date, string prompt, string content)
        {
            _date = date;
            _prompt = prompt;
            _content = content;
        }

        public string GetDate()
        {
            return _date;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetContent()
        {
            return _content;
        }

        public override string ToString()
        {
            return $"Date: {_date} - Prompt: {_prompt} \n{_content}\n";
        }
    }
