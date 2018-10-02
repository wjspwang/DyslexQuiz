using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAndSetText : MonoBehaviour {

    public InputField username;
    public Text output;


    public void GetAndSet()
    {
        output.text = "Hi " + username.text + "!";
    }
}
