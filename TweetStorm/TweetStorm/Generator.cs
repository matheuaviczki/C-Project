using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TweetStorm
{
    class Generator
    {
      
        private int getTextLength { get; set; }
        private static double getSpanningNumber { get; set; }
        private double differenceFloat { get; set; }
        public string getText { get; set; }

        public Generator()
        {
            getText = GetText.GetFileText();
        }


        /// <summary>
        /// Função para retornar quantos Tweetstorm serão enviados
        /// </summary>
        /// <returns></returns>
        public int DivideText() 
        {

            getTextLength = GetText.GetFileText().Length;
            getSpanningNumber = (getTextLength/ GetText.MAXLENGTH);
            differenceFloat = getSpanningNumber - (int)getSpanningNumber;
            getSpanningNumber = differenceFloat != 0 ? getSpanningNumber += 1:getSpanningNumber+=0;

            return (int)getSpanningNumber;
         
        }

        /// <summary>
        /// Função para gerar os TweetStorm
        /// </summary>
        /// <returns></returns>
        public string[] Generate()
        {
            char[] TweetStorm = new char[getTextLength];
            string[] sendTweetStorm = new string[DivideText()];

            int countLimite = 0;
            int i = 0;
            int j = 0;

            foreach(char item in getText)
            {
                TweetStorm[i] = item;
                i++;
            }
            

            for(i = 0; i < DivideText(); i++)
            {
                sendTweetStorm[i] = Convert.ToString(i+1) + "\\";
            }

            for(i = 0 ; i < getTextLength; i++)
            {
                if (countLimite < 140)
                {
                    sendTweetStorm[j] += Convert.ToString(TweetStorm[i]);
                    countLimite++;
                }
                else
                {
                    j++;
                    countLimite = 0;
                }
                    
                
            }

            return sendTweetStorm;
        }
    }
}
