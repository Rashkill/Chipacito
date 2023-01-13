using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : ObjectMovement
{
    public float initialDelay = 0f;
    void Start()
    {
        MoveY(-6f, Random.Range(2f, 6f), initialDelay);
        MoveX(Random.Range(-1, 1), Random.Range(2f, 4f), initialDelay);
    }
    public override void OnComplete()
    {
        transform.position = new Vector3(Random.Range(-1, 2), 6f, transform.position.z);

        float delay = Random.Range(1f, 6f);
        MoveY(-6f, Random.Range(2f, 6f), delay);
        MoveX(Random.Range(-1, 1), Random.Range(1f, 3f), delay + Random.Range(1f, 3f));
    }
}
