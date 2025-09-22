using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BigMeteor : MonoBehaviour
{
    public int hitCount = 0;

    public float shakeforce = 1f;

    public CinemachineImpulseSource impulseSource;

    // Start is called before the first frame update
    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(0.5f);

        if (hitCount >= 5)
        {
            CameraShake(impulseSource);
            Destroy(this.gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().gameOver = true;
            Destroy(whatIHit.gameObject);
        }
        else if (whatIHit.tag == "Laser")
        {
            hitCount++;
            Destroy(whatIHit.gameObject);
        }
    }

    public void Movement(float speed)
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < -11f)
        {
            Destroy(this.gameObject);
        }
    }

    public void CameraShake(CinemachineImpulseSource source)
    {
        source.GenerateImpulseWithForce(shakeforce);
    }
}
