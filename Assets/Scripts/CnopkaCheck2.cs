using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CnopkaCheck2 : MonoBehaviour
{
    public static string c;
    public void ButClick2()
    {
        c = SuperCheck.input;
        if (c == "Амазонка"|| c == "амазонка" || c == "Амазонка " || c == "амазонка ")
        {
            SceneManager.LoadScene("Right2");
        }

    }
}
