using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public static NameHolder Instance;
    public GameObject nameFieldText;
    public string playerName;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SavePlayerName()
    {
        playerName = nameFieldText.GetComponent<Text>().text;
    }
}

