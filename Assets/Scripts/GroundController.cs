using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public Transform ground1, ground2, ground3;
    public List<Transform> coins;
    public List<Transform> throns;

    private float speed;
    private float xFinal;
    private float xReSpawn;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
        xFinal = -32.0f;
        xReSpawn = 64.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PlataformMover();
    }

    private void PlataformMover()
    { 
        PlataformMover(ground1);
        PlataformMover(ground2);
        PlataformMover(ground3);
    }

    private void PlataformMover(Transform plataform)
    {
        plataform.Translate(new Vector2(- speed * Time.deltaTime, 0.0f));
        if(plataform.position.x <= xFinal)
        {
            plataform.Translate(new Vector2(xReSpawn, 0.0f));
        }
    }
}
