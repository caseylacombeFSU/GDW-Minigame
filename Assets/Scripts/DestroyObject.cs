using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Score score; 
    

    private float topBound = 60.0f;
    private float lowerBound = -60.0f;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound && gameObject.tag.Equals("Dodge"))
        {
            score.IncreaseScore(1, 0);
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Game Over!");
        }


    }
}
