using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    private Score score; 

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Projectile"))
        {
            score.IncreaseScore(1, 1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Game Over!");
        }

    }
}
