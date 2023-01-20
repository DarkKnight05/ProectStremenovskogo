using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using System;
using System.Linq;
using System.Text;
using UnityEngine.SceneManagement;

public class CnopkaCheck : MonoBehaviour
{
    
    public static string a;
    public void ButClick()
    {
        a = SuperCheck.input;
        if (a == "89")
        {
            SceneManager.LoadScene("Right1");
        }
            
    }
}
