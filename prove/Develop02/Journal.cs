/*Edwin Hared Albancando Robles*/
using System;

class Journal
    {
        /* entries will be stored in a list*/
        public List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }
        /*add entry*/
        public void AddEntry(string prompt)
        {
            Console.Write(prompt + " ");
            string content = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(date, prompt, content));
        }
        /*Display entry */
        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        /*save entrie to File*/

        public void SaveToFile()
        {
            Console.Write("Enter Filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Content");

                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetContent().Replace(",", ",,")}");
                }
            }

            Console.WriteLine("Your entries were saved");
        }

        /*load entry from existing saved file*/
        public void LoadFromFile()
        {
            Console.Write("Enter filename: ");
            string filename = Console.ReadLine();
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string headerLine = reader.ReadLine(); // Read and discard the header line

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    string date = fields[0];
                    string prompt = fields[1].Replace(",,", ",");
                    string content = fields[2].Replace(",,", ",");

                    entries.Add(new Entry(date, prompt, content));
                }
            }

            Console.WriteLine("File loaded");
        }
    }