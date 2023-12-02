using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2;
    private readonly int heightOffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate) {
            timer += Time.deltaTime;
        } else {
            SpwanPipe();
            timer = 0;
        }

    }
    private void SpwanPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
