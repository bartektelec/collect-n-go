using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectNGo
{
    class Machine
    {
        private List<Box>boxes;
        public Machine()
        {
            boxes = new List<Box> { };

            for (int i = 0; i < 8; i++)
            {
                boxes.Add(new Box(i));
            }


        }

        public void InputCode(string Code)
        {
            for(int i = 0; i < boxes.Count; i++)
            {
                boxes[i].InputCode(Code);
            }
        }


        public List<int> GetOpenBoxes()
        {
            var opened = new List<int> { };

            for (int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].IsOpen) opened.Add(boxes[i]._Id);
            }

            return opened;
        }

        public void Open(int Id)
        {
            Console.WriteLine(boxes[Id].Open());
           
        }

        public string Store(string Content)
        {
            string accessCode = "";
            for(int i = 0; i < boxes.Count; i++)
            {
                if(boxes[i].IsEmpty())
                {
                    accessCode = boxes[i].Store(Content);
                    break;
                }
            }

            return accessCode;

        }
    }
}
