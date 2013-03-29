using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextManager
{
    public class TextManager
    {
        /// <summary>
        /// Original text asignate in cretion object
        /// </summary>
        public string TextOriginal { get; set; }

        /// <summary>
        /// Conect Text width changes in execution
        /// </summary>
        public string TextEdited { get; set; }


        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="strText">Text using for changes and caculate values</param>
        public TextManager(string strText)
        {
            this.TextOriginal = strText;
            this.TextEdited = strText;
        }

        /// <summary>
        /// Count number words in orginal text
        /// </summary>
        /// <returns></returns>
        public int CountWords()
        {
            //var set numer word and return calculate value
            int intCount = 0;
            
            //get number words
            string[] arrayTextSplit = TextOriginal.Split((" ").ToCharArray());

            foreach (var item in arrayTextSplit)
            {   
                //if text is not null if word
                if (!string.IsNullOrEmpty(item)) { intCount++; }
            }

            return intCount;
        }

        /// <summary>
        /// Count words in text edited 
        /// </summary>
        /// <returns></returns>
        public int CountWordsTextEdited()
        {
            //var set numer word and return calculate value
            int intCount = 0;

            //get number words
            string[] arrayTextSplit = TextOriginal.Split((" ").ToCharArray());

            foreach (var item in arrayTextSplit)
            {
                //if text is not null if word
                if (!string.IsNullOrEmpty(item)) { intCount++; }
            }

            return intCount;
        }

    }
}
