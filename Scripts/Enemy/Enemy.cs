using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void init(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}
