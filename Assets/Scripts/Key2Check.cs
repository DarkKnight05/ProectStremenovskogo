using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using System;
using System.Linq;
using System.Text;
using UnityEngine.SceneManagement;

public class Key2Check : MonoBehaviour
{
    
    public static string b;
    public void Keyya2()
    {
        b = SuperCheck.input;
        if (b == "12345")
        {
            SceneManager.LoadScene("Camera2");
        }
            
    }
}
