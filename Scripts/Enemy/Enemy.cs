using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void Init(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}
