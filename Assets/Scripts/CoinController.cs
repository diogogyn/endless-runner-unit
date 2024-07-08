using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
   
    void Update()
    {
        if(transform.position.x > 32.0f)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
