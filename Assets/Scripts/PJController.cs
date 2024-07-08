using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PJController : MonoBehaviour
{
    public TextMeshProUGUI coinBox;

    public Rigidbody2D rb;
    private Vector2 jumpStr;
    private bool podePular;
    private int nCoin;
    // Start is called before the first frame update
    void Start()
    {
        jumpStr = new Vector2(0.0f, 15.0f);
        podePular = true;
        nCoin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump() {
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            rb.AddForce(jumpStr, ForceMode2D.Impulse);
            podePular = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            podePular = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            nCoin = nCoin + 1;
            coinBox.text = nCoin + "";
        }

        if (other.gameObject.tag == "Thorm")
        {
            Time.timeScale = 0.0f;
        }
        
    }
    
}
