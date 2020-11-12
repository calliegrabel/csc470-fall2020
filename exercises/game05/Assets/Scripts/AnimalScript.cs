using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalScript : MonoBehaviour
{
    float speed = 2;

    public CharacterController cc;

 
    public string animalName;
    public string soundName;
    public string edibleName;

    public GameManager gm;

    public bool selected = false;
    public bool hover = false;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
        GameObject gmObj = GameObject.Find("GameObjectManager");
        gm = gmObj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        cc.Move(transform.forward * speed * Time.deltaTime);
    }
    private void OnMouseEnter()
    {
        hover = true;
        speed = 0;
    }
    private void OnMouseExit()
    {
        hover = false;
        speed = 2;
        gm.TurnOffPanel();
        
    }
   
    private void OnMouseDown()
    {
        selected = !selected;
        if (selected)
        {
            gm.positionAboveNamePanel(this);
        }
    }
}

