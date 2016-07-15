using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour
{ 

float speed = 4f;

// Update is called once per frame
void Update()
{

    if (Input.GetKey(KeyCode.LeftArrow))
    {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.UpArrow))
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
        transform.Translate(-Vector2.up * speed * Time.deltaTime);
        }
    }
}
