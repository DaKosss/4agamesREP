using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class numpad : MonoBehaviour
{
    Text myText;
    string myString = "";
    public string password;
    public bool flag = false;
    public int Leveltrue;
    public int Levelfalse;
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
            Application.LoadLevel(Leveltrue);
        }
        if (myString.Length == 4)
        {
            if (myString != password)
            {
                myString = "";
                Application.LoadLevel(Levelfalse);
            }
        }
    }

    public void MyNumber(string number)
    {
        if (myString.Length < 4)
        {
            myString += number;
        }
    }
}