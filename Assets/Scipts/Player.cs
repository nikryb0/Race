using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Text _text;
    private int hp = 3;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.y < 3)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -3)
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 5)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -5)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * _speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            hp--;
            _text.text = hp.ToString();
        }
    }
}
