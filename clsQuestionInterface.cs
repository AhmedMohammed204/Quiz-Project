using QuestionsBusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class clsQuestionInterface
    {
        public Image QuestionImage { get; set; }
        public Image ExplainImage { get; set; }
        public clsQuestionInterface(clsQuestion question) {
            this.QuestionImage = _ConvertFromBitToImage(question.Image);
            this.ExplainImage = _ConvertFromBitToImage(question.ExplainImage);
        }
        private Image _ConvertFromBitToImage(byte[] image)
        {
            if(image == null)
            {
                return null;
            }

            System.IO.MemoryStream ms = new System.IO.MemoryStream(image);
            return Image.FromStream(ms);
        }


    }
}
