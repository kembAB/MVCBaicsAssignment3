using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApp.Models;
namespace MVCWebApp.Models.GuessingGame
{
    /// <summary>
    /// Gets the proper Result value based on values entereed
    /// </summary>
    /// <param name="_myModel"></param>
    /// <returns></returns>
    public class comparePlyerRandomNum
    {
        public string GetResult(ref GuessingProperties _myModel)
        {
            try
            {

                string rsltsubstr = null;

                 int difference = _myModel.randomNumber - _myModel.EnteredNum;
                if (difference != 0)
                {
                    rsltsubstr = Compare(difference);

                    
                    return $" {rsltsubstr}";
                }
                else
                {
                    _myModel.Success = true;
                    return "Congratulations ! your guess is correct";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private string Compare(int diffrence)
        {
            
            string diff = (diffrence > 0 ? "tip:go higer" : "tip:go lower");
            return diff;
        }


    }
}
