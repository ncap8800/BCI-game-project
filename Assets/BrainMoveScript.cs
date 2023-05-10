using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public LogicScript logic;
    public float destroyZone = -12;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < destroyZone)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
            Destroy(gameObject);
        }
        else if(collision.gameObject.layer == 6)
        {
            logic.reduceLife(1);
            Destroy(gameObject);
        }
    }
}
