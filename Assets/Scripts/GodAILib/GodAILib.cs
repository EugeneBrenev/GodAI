using UnityEngine;

namespace GodAILib
{
    public class GodAILib 
    {
        public static bool GetAnswer(string question)
        {
            return Random.Range(0, 2) == 0;
        }
    }
}
