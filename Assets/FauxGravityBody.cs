using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    Rigidbody _rigidbody;
    public FauxGravityAttractor attractor;
    private Transform myTransform;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        _rigidbody.useGravity = false;
        myTransform = transform;
    }

    void Update()
    {
        attractor.Attract(myTransform, _rigidbody);
    }
}
