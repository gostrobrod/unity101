using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected float t = 0;
    protected GameObject item;

    public virtual GameObject createShape() {
        return null;
    }
    // Start is called before the first frame update
    void Start() {
        item = createShape();
    }

    // Update is called once per frame
    void Update() {
        t += Time.deltaTime;
        item.transform.position = new Vector3(transform.position.x, 10 * Mathf.Sin(t), transform.position.z);
    }
}
