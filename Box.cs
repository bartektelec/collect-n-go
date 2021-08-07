using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectNGo
{
    class Box
    {
        private string Content;
        private string Code;
        public int _Id { get; private set; }
        public bool IsOpen { get; private set; }

        public Box(int Id)
        { 
            _Id = Id;
            Content = "";
            Code = GenerateCode();
            IsOpen = false;
        }

        private string GenerateCode()
        {
            Random rand = new Random();
            return rand.Next(10000, 99999).ToString();
        }

        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(Content);
        }


        public string Open()
        {
            if(IsOpen)
            {
                string secret = Content;
                Content = "";
                IsOpen = false;
                return "Box stores: " + secret;
            }
            else
            {
                return "Box is not unlocked";
            }
        }

        public string Store(string NewContent)
        {
            Code = GenerateCode();
            Content = NewContent;
            IsOpen = false;

            return Code;
        }

        public void InputCode(string InputCode)
        {
            if(InputCode == Code)
            {
                IsOpen = true;
            }


        }
        
    }
}
