using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public Renderer rendRightLeg;
    public Renderer rendLeftLeg;
    public Renderer rendLeftArm;
    public Renderer rendRightArm;
    public Renderer rendBody;

    

    public Color orange;
    public Color blue;
    public Color yellow;
    public Color pink;
    public GameObject GameManager;
    GameManager gm;
    public Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetComponent<GameManager>();
        rendRightLeg.material.color = orange;
        rendLeftLeg.material.color = orange;
        rendRightArm.material.color = orange;
        rendLeftArm.material.color = orange;
        rendBody.material.color = orange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterColor(int index)
    {
        index = dropdown.value;
        gm.saveColor = index;
        PlayerPrefs.SetInt("Color", gm.saveColor);
        if (index == 0)
        {
            rendRightLeg.material.color = orange;
            rendLeftLeg.material.color = orange;
            rendRightArm.material.color = orange;
            rendLeftArm.material.color = orange;
            rendBody.material.color = orange;
            Debug.Log("Orange");
        }
        if (index == 1)
        {
            rendRightLeg.material.color = blue;
            rendLeftLeg.material.color = blue;
            rendRightArm.material.color = blue;
            rendLeftArm.material.color = blue;
            rendBody.material.color = blue;
            Debug.Log("Blue");
        }
        if (index == 2)
        {
            rendRightLeg.material.color = yellow;
            rendLeftLeg.material.color = yellow;
            rendRightArm.material.color = yellow;
            rendLeftArm.material.color = yellow;
            rendBody.material.color = yellow;
            Debug.Log("Yellow");
        }
        if (index == 3)
        {
            rendRightLeg.material.color = pink;
            rendLeftLeg.material.color = pink;
            rendRightArm.material.color = pink;
            rendLeftArm.material.color = pink;
            rendBody.material.color = pink;
            Debug.Log("Pink");
        }
    }
}
