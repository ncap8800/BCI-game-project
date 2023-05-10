using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScript : MonoBehaviour
{
    public float movePlayer = 5;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < 2 && logic.playerIsAlive)
        {
            transform.position += (Vector3.up * movePlayer) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && transform.position.y > -4 && logic.playerIsAlive)
        {
            transform.position += (Vector3.down * movePlayer) * Time.deltaTime;
        }
        if (!logic.playerIsAlive || logic.gameWinScreen.activeInHierarchy)
            Destroy(gameObject);


    }
}
