using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Collaps : MonoBehaviour
{
    [SerializeField]GameObject target;
    float speed = 2f;
    void Update()
    {
        Vector3 directionToTarget = (target.transform.position - transform.position).normalized;
        transform.Translate(speed * Time.deltaTime * directionToTarget);
        if (Math.Abs(this.transform.position.x) - Math.Abs(target.transform.position.x) < 0.3f)
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
            target.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
