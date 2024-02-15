using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string NameText;
    public int Score;

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
}