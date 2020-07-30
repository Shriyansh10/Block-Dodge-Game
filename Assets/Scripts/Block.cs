using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private float gravityscale = 50f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityscale;

    }
    private void Update()
    {
        if (transform.position.y < -2f)
        {

            Score.scorevalue += 0.25f;
            Destroy(gameObject);

        }
    }
}
