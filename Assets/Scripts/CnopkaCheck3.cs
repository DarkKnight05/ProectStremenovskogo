using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CnopkaCheck3 : MonoBehaviour
{
    public static string i;
    public void ButClick3()
    {
        i = SuperCheck.input;
        if (i == "Турция" || i == "турция" || i == "Турция " || i == "турция ")
        {
            SceneManager.LoadScene("Right3");
        }

    }
}
