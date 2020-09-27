using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldView : MonoBehaviour
{
    public InputField input;
    // Start is called before the first frame update
    public string ReturnInputText()
    {
        return input.text;
    }

    public void ResetInputText()
    {
        input.text = "";
    }
}
