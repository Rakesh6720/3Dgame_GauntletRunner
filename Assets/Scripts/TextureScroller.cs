﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour {

    public float speed = .5f;

    Renderer renderer;
    float offset;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        //increase the offset based on time
        offset += Time.deltaTime * speed;
        //keep offset between 0 and 1
        if (offset > 1)
            offset -= 1;
        //apply the offset to the material
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
