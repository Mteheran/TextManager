using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextManager
{
    public class ConverterManager
    {

        public static int StringToInteger(string strCulture, string strNumberText)
        {
            int intTotalValue = 0;
            strNumberText = strNumberText.ToLower();
            int intNumberFormat = 0;

            #region spanish case

            //case for spanish
            if (strCulture.ToString() == "es")
            {

                //get array numbers space separation 
                string[] strVector = strNumberText.Split(" ".ToCharArray());

                for (int i = 0; i < strVector.Length; i++)
                {
                    switch (strVector[i])
                    {

                        #region 1-9

                        case "uno":
                            intNumberFormat = intNumberFormat + 1;
                            break;
                        case "dos":
                            intNumberFormat = intNumberFormat + 2;
                            break;
                        case "tres":
                            intNumberFormat = intNumberFormat + 3;
                            break;
                        case "cuatro":
                            intNumberFormat = intNumberFormat + 4;
                            break;
                        case "cinco":
                            intNumberFormat = intNumberFormat + 5;
                            break;
                        case "seis":
                            intNumberFormat = intNumberFormat + 6;
                            break;
                        case "siete":
                            intNumberFormat = intNumberFormat + (7);
                            break;
                        case "ocho":
                            intNumberFormat = intNumberFormat + (8);
                            break;
                        case "nueve":
                            intNumberFormat = intNumberFormat + (9);
                            break;
                        case "dies":
                            intNumberFormat = intNumberFormat + (10);
                            break;

                        #endregion

                        #region 11 - 29

                        case "once":
                            intNumberFormat = intNumberFormat + (11); ;
                            break;
                        case "doce":
                            intNumberFormat = intNumberFormat + (12); ;
                            break;
                        case "trece":
                            intNumberFormat = intNumberFormat + (13); ;
                            break;
                        case "catorce":
                            intNumberFormat = intNumberFormat + (14); ;
                            break;
                        case "quince":
                            intNumberFormat = intNumberFormat + (15); ;
                            break;
                        case "dieciséis":
                            intNumberFormat = intNumberFormat + (16); ;
                            break;
                        case "diecisiete":
                            intNumberFormat = intNumberFormat + (17); ;
                            break;
                        case "dieciocho":
                            intNumberFormat = intNumberFormat + (18); ;
                            break;
                        case "diecinueve":
                            intNumberFormat = intNumberFormat + (19); ;
                            break;

                        #endregion

                        #region 20 - 90

                        case "veinte":
                            intNumberFormat = intNumberFormat + (20); ;
                            break;
                        case "treinta":
                            intNumberFormat = intNumberFormat + (30); ;
                            break;
                        case "cuarenta":
                            intNumberFormat = intNumberFormat + (40); ;
                            break;
                        case "cincuenta":
                            intNumberFormat = intNumberFormat + (50); ;
                            break;
                        case "sesenta":
                            intNumberFormat = intNumberFormat + (60); ;
                            break;
                        case "setenta":
                            intNumberFormat = intNumberFormat + (70); ;
                            break;
                        case "ochenta":
                            intNumberFormat = intNumberFormat + (80); ;
                            break;
                        case "noventa":
                            intNumberFormat = intNumberFormat + (90); ;
                            break;

                        #endregion

                        #region 100 - 900

                        case "cien":
                            intNumberFormat = intNumberFormat + (100);
                            break;
                        case "ciento":
                            intNumberFormat = intNumberFormat + 100;
                            break;
                        case "docientos":
                            intNumberFormat = intNumberFormat + (200); ;
                            break;
                        case "trescientos":
                            intNumberFormat = intNumberFormat + (300); ;
                            break;
                        case "cuatrocientos":
                            intNumberFormat = intNumberFormat + (400); ;
                            break;
                        case "quinientos":
                            intNumberFormat = intNumberFormat + (500); ;
                            break;
                        case "seiscientos":
                            intNumberFormat = intNumberFormat + (600); ;
                            break;
                        case "setecientos":
                            intNumberFormat = intNumberFormat + (700); ;
                            break;
                        case "ochocientos":
                            intNumberFormat = intNumberFormat + (800); ;
                            break;
                        case "novecientos":
                            intNumberFormat = intNumberFormat + (900); ;
                            break;




                        #endregion

                        #region 1000

                        case "mil":

                            if (intTotalValue == 0 && intNumberFormat == 0)
                            {
                                intTotalValue += 1000;
                            }
                            else
                            {
                                intNumberFormat = intNumberFormat * 1000;
                                intTotalValue += intNumberFormat;
                                intNumberFormat = 0;
                            }

                            break;

                        case "millones":

                            //indica si no hay un numero especifico se multiplica por un millo que este en el total
                            if (intNumberFormat == 0)
                                intTotalValue = intTotalValue * 1000000;
                            else
                            {
                                //se multiplica por un millon el actual numero en el contador
                                intNumberFormat = intNumberFormat * 1000000;
                                intTotalValue += intNumberFormat;
                                intNumberFormat = 0;

                            }

                            break;

                        case "millon":
                        case "millón":

                            // se suma un millon 
                            intTotalValue += 1000000;

                            break;

                        #endregion

                        default:
                            break;
                    }
                }

                intTotalValue += intNumberFormat;
            }

            #endregion

            #region english case

            //case for spanish
            if (strCulture.ToString() == "en")
            {

                //get array numbers space separation 
                string[] strVector = strNumberText.Split(" ".ToCharArray());

                for (int i = 0; i < strVector.Length; i++)
                {
                    switch (strVector[i])
                    {

                        #region 1-9

                        case "one":
                            intNumberFormat = intNumberFormat + 1;
                            break;
                        case "two":
                            intNumberFormat = intNumberFormat + 2;
                            break;
                        case "three":
                            intNumberFormat = intNumberFormat + 3;
                            break;
                        case "four":
                            intNumberFormat = intNumberFormat + 4;
                            break;
                        case "five":
                            intNumberFormat = intNumberFormat + 5;
                            break;
                        case "six":
                            intNumberFormat = intNumberFormat + 6;
                            break;
                        case "seven":
                            intNumberFormat = intNumberFormat + (7);
                            break;
                        case "eight":
                            intNumberFormat = intNumberFormat + (8);
                            break;
                        case "nine":
                            intNumberFormat = intNumberFormat + (9);
                            break;
                        case "ten":
                            intNumberFormat = intNumberFormat + (10);
                            break;

                        #endregion

                        #region 11 - 29

                        case "eleven":
                            intNumberFormat = intNumberFormat + (11); ;
                            break;
                        case "twelve":
                            intNumberFormat = intNumberFormat + (12); ;
                            break;
                        case "thirteen":
                            intNumberFormat = intNumberFormat + (13); ;
                            break;
                        case "fourteen":
                            intNumberFormat = intNumberFormat + (14); ;
                            break;
                        case "fifteen":
                            intNumberFormat = intNumberFormat + (15); ;
                            break;
                        case "sixteen":
                            intNumberFormat = intNumberFormat + (16); ;
                            break;
                        case "seventeen":
                            intNumberFormat = intNumberFormat + (17); ;
                            break;
                        case "eighteen":
                            intNumberFormat = intNumberFormat + (18); ;
                            break;
                        case "nineteen":
                            intNumberFormat = intNumberFormat + (19); ;
                            break;

                        #endregion

                        #region 20 - 90

                        case "twenty":
                            intNumberFormat = intNumberFormat + (20); ;
                            break;
                        case "thirty":
                            intNumberFormat = intNumberFormat + (30); ;
                            break;
                        case "forty":
                            intNumberFormat = intNumberFormat + (40); ;
                            break;
                        case "fifty":
                            intNumberFormat = intNumberFormat + (50); ;
                            break;
                        case "sixty":
                            intNumberFormat = intNumberFormat + (60); ;
                            break;
                        case "seventy":
                            intNumberFormat = intNumberFormat + (70); ;
                            break;
                        case "eighty":
                            intNumberFormat = intNumberFormat + (80); ;
                            break;
                        case "ninety":
                            intNumberFormat = intNumberFormat + (90); ;
                            break;

                        #endregion
                                                  
                        #region 100- 1000

                        case "hundred":

                            if (intTotalValue == 0 && intNumberFormat == 0)
                            {
                                intTotalValue += 100;
                            }
                            else
                            {
                                intNumberFormat = intNumberFormat * 100;
                                intTotalValue += intNumberFormat;
                                intNumberFormat = 0;
                            }

                            break;

                        case "thousand":

                            if (intTotalValue>=100)
                            {
                                intTotalValue = intTotalValue * 1000;
                            }

                            if (intTotalValue == 0 && intNumberFormat == 0)
                            {
                                intTotalValue += 1000;
                            }
                            else
                            {
                                intNumberFormat = intNumberFormat * 1000;
                                intTotalValue += intNumberFormat;
                                intNumberFormat = 0;
                            }

                            break;

                        case "million":

                            //indica si no hay un numero especifico se multiplica por un millo que este en el total
                            if (intNumberFormat == 0)
                                intTotalValue = intTotalValue * 1000000;
                            else
                            {
                                //se multiplica por un millon el actual numero en el contador
                                intNumberFormat = intNumberFormat * 1000000;
                                intTotalValue += intNumberFormat;
                                intNumberFormat = 0;
                            }

                            break;
                        
                        #endregion

                        default:
                            break;
                    }
                }

                intTotalValue += intNumberFormat;
            }

    

            #endregion


            return intTotalValue;

        }

    }
}
