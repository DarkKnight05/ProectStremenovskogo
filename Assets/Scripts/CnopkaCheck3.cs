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
        if (i == "������" || i == "������" || i == "������ " || i == "������ ")
        {
            SceneManager.LoadScene("Right3");
        }

    }
}
