using System;

namespace CSharpInterview.Examples
{
    class technicalscripter
    {
        private string topic_name;
        private int article_no;

        // parametrized constructor  
        public technicalscripter(string topic_name, int article_no)
        {
            this.topic_name = topic_name;
            this.article_no = article_no;
        }

        // copy constructor  
        public technicalscripter(technicalscripter tech)
        {
            topic_name = tech.topic_name;
            article_no = tech.article_no;
        }

        // getting the topic name and number of articles published  
        public string Data
        {
            get
            {
                return "The name of topic is: " + topic_name +
                " and number of published article is: " + article_no.ToString();
            }
        }
    }

    public static class CopyConstructor
    {
        static public void Execute()
        {
            // creating object t1  and provide value to the object  
            technicalscripter t1 = new technicalscripter(" C# | Copy Constructor", 38);

            // Creating object t2 and copy the data of t1 object into t2 object  
            technicalscripter t2 = new technicalscripter(t1);

            Console.WriteLine(t2.Data);
            Console.ReadKey();

        }
    }
}
