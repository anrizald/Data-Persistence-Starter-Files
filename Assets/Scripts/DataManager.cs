using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using TMPro;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string NameText;
    [SerializeField]
    public TMP_InputField textField;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string NameText;
    }

    public void onValueChanged()
    {
        string foo = textField.text;
        NameText = foo;


    }
}