using UnityEngine;
using System.Collections;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string NameText;

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
}