using System;
using System.Collections.Generic;

namespace LongestIncSubseqApi
{
    public class LIS : LISInit
    {
        public string output { get; set; }
        public string input { get; set; }
        public string LISFlow(string inputvalue)
        {
            string[] arrSeq = inputvalue.Split(' ');
            string outSeq = arrSeq[0];
            int maxLength = 1;
            string tempSeq = arrSeq[0];
            if (string.IsNullOrEmpty(inputvalue))
            {
                return output = "Not a Valid Input string";
            }


            for (int i = 0; i < arrSeq.Length - 1; i++)
                {
                    if (int.Parse(arrSeq[i + 1]) > int.Parse(arrSeq[i]))
                    {
                        if (tempSeq.Length == 0)
                        {
                            tempSeq = arrSeq[i];
                        }
                        tempSeq = tempSeq + ' ' + arrSeq[i + 1];
                        maxLength += 1;
                    }
                    else
                    {
                        if (outSeq.Split(' ').Length < tempSeq.Split(' ').Length)
                        {
                            outSeq = tempSeq;
                        }
                        tempSeq = string.Empty;
                        maxLength = 1;

                    }
                }
                if (outSeq.Split(' ').Length < tempSeq.Split(' ').Length)
                {
                    outSeq = tempSeq;
                }
                return output = outSeq;
            }
            
        }
}
    

