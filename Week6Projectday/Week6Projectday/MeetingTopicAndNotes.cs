using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    class MeetingTopicAndNotes
    {
        public string MeetingTopic { get; set; }
        public string MeetingNotes { get; set; }
        public string Add { get; set; }
        public List<string> Meeting { get; set; }

        //when you say new, this is what it does
        public MeetingTopicAndNotes()
        {
            Meeting = new List<string>();
        }

        public void EnterMeetingTopicNotes()
        {
            while (true)
            {
                Console.WriteLine("Meeting Topic: ");
                MeetingTopic = Console.ReadLine();

                Console.WriteLine("Meeting Notes: ");
                MeetingNotes = Console.ReadLine();

                Add = MeetingTopic + "|" + MeetingNotes;
                Meeting.Add(Add);

                Console.WriteLine("Do you want to enter another Meeting Topic? Y or N");
                string addMore = Console.ReadLine().ToLower();

                if (addMore == "y")
                {
                    continue;
                }
                if (addMore == "n" || String.IsNullOrWhiteSpace(addMore))
                {
                    break;
                }
            }
        }

    }
}
