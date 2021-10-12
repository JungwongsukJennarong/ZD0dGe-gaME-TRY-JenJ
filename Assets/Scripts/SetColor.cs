using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public MeshRenderer m_render;
    public Color render_color;
    // Start is called before the first frame update
    void Start()
    {
        m_render = GetComponent<MeshRenderer>();
        m_render.material.color = render_color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
