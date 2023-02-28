using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class num : MonoBehaviour
{
    Text myText;
    string myString = "";
    public string password;
    public bool flag = false;

    void Start()
    {
        myText = GetComponent<Text>();
    }

    void Update()
    {
        myText.text = myString;
        if (myString == password)
        {
            flag = true;
        }
        if (myString.Length == 8)
        {
            if (myString != password)
            {
                myString = "";
            }
        }
    }

    public void MyNumber(string number)
    {
        if (myString.Length < 8)
        {
            myString += number;
        }
    }
}
