using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinningTextScript : MonoBehaviour
{
    public Text WinningText;
    // Start is called before the first frame update
    void Start()
    {
        WinningText.text = "Congratulations " + GameManager.instance.playerName + "! You have completed Fall Girls!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
