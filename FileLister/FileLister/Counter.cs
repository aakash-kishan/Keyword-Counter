using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace FileLister
{
    public abstract class Counter
    {
        public abstract void Display();
    }

    public class FileDisplay : Counter
    {
        private string path;

        public string Paths
        {
            get { return path; }
            set { path = value; }
        }

        public override void Display()
        {
            Console.WriteLine("Enter the keyword: ");
            string kword = Console.ReadLine();
            string[] files = Directory.GetFiles(path, "*.txt");
            
            
            
            foreach (string file in files)
            {
                bool keywordFound = SearchKeywordInFile(file, kword);
                

                if (keywordFound)
                {
                    string fileName = Path.GetFileName(path);
                    Console.WriteLine($"File '{fileName}' contains the keyword '{kword}'");

                    
                }

                
            }
           
            
            

        }

        private bool SearchKeywordInFile(string filePath, string searchKeyword)
        {
            string content = File.ReadAllText(filePath);

            int v = ContainsCaseInsensitive(content, searchKeyword);
            
            if (v>0)
            {
                Console.WriteLine($"The no. of counts: {v}");
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private int ContainsCaseInsensitive(string content, string searchKeyword)
        {
            int count = 0;
            for (int i = 0; i <= content.Length - searchKeyword.Length; i++)
            {
                bool match = true;
                

                

                for (int j = 0; j < searchKeyword.Length; j++)
                {
                    if ((content[i + j]) != (searchKeyword[j]))
                    {
                        match = false;
                        break;
                    }
                }
                
                if (match)
                {

                    count++;
                    
                    
                }
                

            }

            return count;
        }
        

        
    }
}
