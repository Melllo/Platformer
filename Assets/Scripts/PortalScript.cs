using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (PlayerPrefs.GetInt("CRYSTALS_AMOUNT") == 3) {
                PlayerPrefs.SetInt("CRYSTALS_AMOUNT", 0);
                SceneManager.LoadScene(0);
                
            }
        }
    }
}
