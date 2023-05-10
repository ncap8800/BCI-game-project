using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainsSpawnScript : MonoBehaviour
{
    public GameObject brain;
    public float spawnRate = 2;
    private float timer = 0;
    private float maxHeight = 3;
    private float minHeight = -4;


    // Start is called before the first frame update
    void Start()
    {
        spawnBrain();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBrain();
            timer = 0;
        }
    }

    public void spawnBrain()
    {
        Instantiate(brain, new Vector3(transform.position.x, Random.Range(maxHeight, minHeight), transform.position.z), transform.rotation);
    }

}
