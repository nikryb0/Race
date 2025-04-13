using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;

        if (transform.position.y < -10)
        {
            transform.position = new Vector3(Random.Range(-5, 5), 11, 0);
        }
    }
}
