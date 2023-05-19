using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var part = GetComponent<ParticleSystem>();
        part.Play();
        Destroy(gameObject, part.main.duration);
    }
}
