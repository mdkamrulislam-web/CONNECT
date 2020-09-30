using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class SubmitData : MonoBehaviour
{
    public InputFieldView input;
    public void AddEntry()
    {
        
        Data.AddEntry(input.ReturnInputText());
        input.ResetInputText();
        
    }
}
