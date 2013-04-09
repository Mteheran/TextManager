using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextManager
{
    public class ConverterManager
    {     

        public static int StringToInteger(string strCulture,string strNumberText)
        {
            int intTotalValue = 0;
            string TextValueActualy = strNumberText;
            int intNumberFormat = 0;


            //case for spanish
            if (strCulture.ToString()=="es")
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
                                intNumberFormat = intNumberFormat + (7  );
                                break;
                            case "ocho":
                                intNumberFormat = intNumberFormat + (8  );
                                break;
                            case "nueve":
                                intNumberFormat = intNumberFormat + (9  );
                                break;
                            case "dies":
                                intNumberFormat = intNumberFormat + (10  );
                                break;

                            #endregion

                            #region 11 - 29

                            case "once":
                                intNumberFormat = intNumberFormat + (11  ); ;
                                break;
                            case "doce":
                                intNumberFormat = intNumberFormat + (12  ); ;
                                break;
                            case "trece":
                                intNumberFormat = intNumberFormat + (13  ); ;
                                break;
                            case "catorce":
                                intNumberFormat = intNumberFormat + (14  ); ;
                                break;
                            case "quince":
                                intNumberFormat = intNumberFormat + (15  ); ;
                                break;
                            case "dieciséis":
                                intNumberFormat = intNumberFormat + (16  ); ;
                                break;
                            case "diecisiete":
                                intNumberFormat = intNumberFormat + (17  ); ;
                                break;
                            case "dieciocho":
                                intNumberFormat = intNumberFormat + (18  ); ;
                                break;
                            case "diecinueve":
                                intNumberFormat = intNumberFormat + (19  ); ;
                                break;

                            #endregion

                            #region 20 - 90

                            case "veinte":
                                intNumberFormat = intNumberFormat + (20  ); ;
                                break;
                            case "treinta":
                                intNumberFormat = intNumberFormat + (30  ); ;
                                break;
                            case "cuarenta":
                                intNumberFormat = intNumberFormat + (40  ); ;
                                break;
                            case "cincuenta":
                                intNumberFormat = intNumberFormat + (50  ); ;
                                break;
                            case "sesenta":
                                intNumberFormat = intNumberFormat + (60  ); ;
                                break;
                            case "setenta":
                                intNumberFormat = intNumberFormat + (70  ); ;
                                break;
                            case "ochenta":
                                intNumberFormat = intNumberFormat + (80  ); ;
                                break;
                            case "noventa":
                                intNumberFormat = intNumberFormat + (90  ); ;
                                break;

                            #endregion

                            #region 100 - 900

                            case "cien":
                                intNumberFormat = intNumberFormat + (100  );
                                break;
                            case "ciento":
                                intNumberFormat = intNumberFormat + 100;
                                break;
                            case "docientos":
                                intNumberFormat = intNumberFormat + (200  ); ;
                                break;
                            case "trescientos":
                                intNumberFormat = intNumberFormat + (300  ); ;
                                break;
                            case "cuatrocientos":
                                intNumberFormat = intNumberFormat + (400  ); ;
                                break;
                            case "quinientos":
                                intNumberFormat = intNumberFormat + (500  ); ;
                                break;
                            case "seiscientos":
                                intNumberFormat = intNumberFormat + (600  ); ;
                                break;
                            case "setecientos":
                                intNumberFormat = intNumberFormat + (700  ); ;
                                break;
                            case "ochocientos":
                                intNumberFormat = intNumberFormat + (800  ); ;
                                break;
                            case "novecientos":
                                intNumberFormat = intNumberFormat + (900  ); ;
                                break;




                            #endregion

                            #region 1000

                            case "mil":

                                if (intTotalValue == 0 && intNumberFormat==0)
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
                                    intTotalValue +=  1000000;                                

                                break;

                            #endregion

                            default:
                                break;
                        }
                    }
                    intTotalValue += intNumberFormat;
            }

            return intTotalValue;
        }   
    }
}
