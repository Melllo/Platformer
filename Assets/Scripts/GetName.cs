using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    [SerializeField] private InputField InputField1;
    [Header("Keys")]
    [SerializeField] private string saveNameKey = "NAME_VALUE";
    // Start is called before the first frame update
    void Start()
    {
            InputField1.text = PlayerPrefs.GetString(saveNameKey);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString(saveNameKey,InputField1.text);
    }
}
