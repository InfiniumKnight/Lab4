using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : BigMeteor
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hitCount >= 1)
        {
            Destroy(this.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().meteorCount++;
        }
    }

}
