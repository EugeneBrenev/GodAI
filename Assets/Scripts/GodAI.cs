using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GodAI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _questionField;

    public void OnClickGetAnswer()
    {
        Debug.LogError(GodAILib.GodAILib.GetAnswer(_questionField.text) ? "Да" : "Нет");
    }
}
