using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{
    private TMP_InputField inputfield; 
    
    // Start is called before the first frame update
    void Start()
    {
        inputfield =  GetComponent<TMP_InputField>();
        inputfield.onSelect.AddListener(x=>openKeyboard());

        
    }


    public void openKeyboard()
    {
        NonNativeKeyboard.Instance.InputField = inputfield;
        NonNativeKeyboard.Instance.PresentKeyboard(inputfield.text);
        SetCaretColorAlpha(1);
        NonNativeKeyboard.Instance.OnClosed += Instance_OnClosed;
    }

    private void Instance_OnClosed(object sender, System.EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    public void SetCaretColorAlpha(float value)
    {
        inputfield.customCaretColor = true;
        Color caretColor = inputfield.caretColor;
        caretColor.a = value;
        inputfield.caretColor = caretColor;
    }
}
