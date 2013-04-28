namespace TextManager
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Class Validate Manager
    /// </summary>
    public class ValidateManager
    {
        #region Validate DataType

        /// <summary>
        /// Check if value is integer
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is integer, false otherwise.</returns>
        public static bool IsInteger(string strValue)
        {
           int intValueParse = 0;
           return int.TryParse(strValue, out intValueParse);       
        }

        /// <summary>
        /// Check if value is double
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is double, false otherwise.</returns>
        public static bool IsDouble(string strValue)
        {
            double dbValueParse = 0;
            return double.TryParse(strValue, out dbValueParse);
        }

        /// <summary>
        /// Check if value is bool
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is bool, false otherwise.</returns>
        public static bool IsBool(string strValue)
        {
            bool bolValueParse = false;
            return bool.TryParse(strValue, out bolValueParse);
        }

        /// <summary>
        /// Check if value is DateTime.
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is DateTime, false otherwise.</returns>
        public static bool IsDateTime(string strValue)
        {
            DateTime dtValueParse = new DateTime();
            return DateTime.TryParse(strValue, out dtValueParse);
        }

        /// <summary>
        /// Check if value is a natural number.
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is a natural number, false otherwise.</returns>
        public static bool IsNatural(string strValue)
        {
            short intValueParse = 0;
            if (short.TryParse(strValue, out intValueParse))
            {
                if (intValueParse > 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if value is byte
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is byte, false otherwise.</returns>
        public static bool IsByte(string strValue)
        {
            byte btValueParse = 0;
            return byte.TryParse(strValue, out btValueParse);
        }

        /// <summary>
        /// Check if value is short
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is short, false otherwise.</returns>
        public static bool IsShort(string strValue)
        {          
            short stValueParse = 0;
            return short.TryParse(strValue, out stValueParse);
        }

        /// <summary>
        /// Check if value is float
        /// </summary>
        /// <param name="strValue">string value check</param>
        /// <returns>True if value is float, false otherwise.</returns>
        public static bool IsFloat(string strValue)
        {
            float ftValueParse = 0;
            return float.TryParse(strValue, out ftValueParse);
        }

        #endregion

        #region validate especial   

        public static bool IsValidEmail(string strMailAddress)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strMailAddress, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        public static bool IsVocal(string strLetter)
        {
            string strLetterSetter = strLetter.ToLower().Trim();

            if (strLetterSetter == "a" || strLetterSetter == "e" || strLetterSetter == "i" || strLetterSetter == "o" || strLetterSetter == "u")
            {
                return true;
            }

            return false;
        }
            
        #endregion

    }
}
