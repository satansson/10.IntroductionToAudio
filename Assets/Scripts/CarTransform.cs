using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTransform : MonoBehaviour
{
    [SerializeField] float minXChange;
    [SerializeField] float maxXChange;
    [SerializeField] float xBorder;

    Vector3 changePosition;
    bool forward = true;

    void Start()
    {
        changePosition = new Vector3(Random.Range(minXChange, maxXChange), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (forward)
        {
            if (transform.position.x > -xBorder)
            {
                transform.position -= changePosition;
            }
            else
            {
                forward = false;
                RandomizeSpeed();
                RandomizeColor();
            }
        }
        else
        {
            if (transform.position.x < xBorder)
            {
                transform.position += changePosition;
            }
            else
            {
                forward = true;
                RandomizeSpeed();
                RandomizeColor();
            }
        }
    }

    void RandomizeSpeed()
    {
        changePosition = new Vector3(Random.Range(minXChange, maxXChange), 0, 0);
    }

    void RandomizeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
