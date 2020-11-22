using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptObstacleCourse : MonoBehaviour
{
    public Color orange;
    public Color blue;
    public Color yellow;
    public Color pink;

    public Renderer rendRightLeg;
    public Renderer rendLeftLeg;
    public Renderer rendLeftArm;
    public Renderer rendRightArm;
    public Renderer rendBody;

    
    // Start is called before the first frame update
    void Start()
    {
        
        if(GameManager.instance.saveColor == 0)
        {
            rendRightLeg.material.color = orange;
            rendLeftLeg.material.color = orange;
            rendRightArm.material.color = orange;
            rendLeftArm.material.color = orange;
            rendBody.material.color = orange;
        }
        if(GameManager.instance.saveColor == 1)
        {
            rendRightLeg.material.color = blue;
            rendLeftLeg.material.color = blue;
            rendRightArm.material.color = blue;
            rendLeftArm.material.color = blue;
            rendBody.material.color = blue;
        }
        if(GameManager.instance.saveColor == 2)
        {
            rendRightLeg.material.color = yellow;
            rendLeftLeg.material.color = yellow;
            rendRightArm.material.color = yellow;
            rendLeftArm.material.color = yellow;
            rendBody.material.color = yellow;
        }
        if(GameManager.instance.saveColor == 3)
        {
            rendRightLeg.material.color = pink;
            rendLeftLeg.material.color = pink;
            rendRightArm.material.color = pink;
            rendLeftArm.material.color = pink;
            rendBody.material.color = pink;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
