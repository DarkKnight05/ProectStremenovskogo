using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key3Check : MonoBehaviour
{
    public static string d;
    public void Keyya3()
    {
        d = SuperCheck.input;
        if (d == "54321")
        {
            SceneManager.LoadScene("Camera3");
        }

    }
}
