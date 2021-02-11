using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = PlayerPrefs.GetString("NAME_VALUE");
    }
}
