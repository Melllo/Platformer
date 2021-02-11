using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputNameController : MonoBehaviour
{
    [SerializeField] private string playerName;
    [SerializeField] private InputField InputField1;

    [Header("Keys")]
    [SerializeField] private string saveNameKey = "NAME_VALUE";
    

    public void SaveName() {
        if (InputField1.text != "") {
            playerName = InputField1.text;
            PlayerPrefs.SetString(saveNameKey, playerName);
        }
    }

    
    
}
