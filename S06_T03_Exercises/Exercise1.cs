using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace S06_T03_Exercises
{
    class Exercise1
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your post,
        // Facebook displays different information.
        //      - If no one likes your post, it doesn't display anything.
        //      - If only one person likes your post, it displays: [Friend's Name] likes your post.
        //      - If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //      - If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        // Write a program and continuously ask the user to enter different names,
        // until the user presses Enter (without supplying a name). Depending on the
        // number of names provided, display a message based on the above pattern.

        public Exercise1()
        {
            var likeList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name:");

                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    likeList.Add(input);
                    continue;
                }

                break;

            }

            if (likeList.Count == 1)
            {
                Console.WriteLine("[{0}] likes your post.", likeList[0]);
            }
            else if (likeList.Count == 2)
            {
                Console.WriteLine("[{0}] and [{1}] like your post.", likeList[0], likeList[1]);
            }
            else if (likeList.Count > 2)
            {
                Console.WriteLine("[{0}], [{1}] and {2} others like your post.", likeList[0], likeList[1], likeList.Count - 2);
            }

        }
    }
}
