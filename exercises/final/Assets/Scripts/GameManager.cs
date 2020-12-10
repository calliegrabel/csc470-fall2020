using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    
    public string playerName;
    public string saveName;
    public Text inputText;
    public Text loadedName;


    public int saveColor;

    public static GameManager instance;

    public GameObject player;
    public GameObject playerObstacleCourse;

   

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);

        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerName = PlayerPrefs.GetString("name", "none");
        loadedName.text = playerName;
    }
    public void EnterName(string playername)
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        Debug.Log(playername);
         
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("ObstacleCourse");

       
    }
    
}