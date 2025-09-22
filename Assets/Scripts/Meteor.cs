using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Meteor : BigMeteor
{
    public CinemachineImpulseSource thisImpulseSource;

    // Start is called before the first frame update
    void Start()
    {
        thisImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hitCount >= 1)
        {
            CameraShake(thisImpulseSource);
            Destroy(this.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().meteorCount++;
        }
    }

}
