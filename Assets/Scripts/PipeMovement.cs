using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x -.1f, transform.position.y, transform.position.z);
    }
}
