using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vu : MonoBehaviour
{
    public Transform objectFollow;
    void Update()
    {
        Vector3 newPosition = new Vector3(objectFollow.position.x, transform.position.y, -1f);
        transform.position = newPosition;
    }
}
