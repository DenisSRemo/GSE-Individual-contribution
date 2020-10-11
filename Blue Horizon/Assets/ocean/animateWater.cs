using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateWater : MonoBehaviour
{
    public float power = 3;
    public float scale = 1;
    public float timesScale = 1;

    private float XOffset;
    private float YOffset;
    private MeshFilter mf;

    // Start is called before the first frame update
    void Start()
    {
        mf = GetComponent<MeshFilter>();
        WaterAnimate();
    }

    // Update is called once per frame
    void Update()
    {
        WaterAnimate();
        XOffset += Time.deltaTime * timesScale;
        YOffset += Time.deltaTime * timesScale;
    }

    void WaterAnimate()
    {
        Vector3[] verticies = mf.mesh.vertices;

        for (int o = 0; o < verticies.Length; o++)
        {
            verticies[o].y = CalculateHeight(verticies[o].x, verticies[o].z) * power;
        }

        mf.mesh.vertices = verticies;
    }

    float CalculateHeight(float x, float y) {
        float xCord = x * scale + XOffset;
        float yCord = y * scale + YOffset;

        return Mathf.PerlinNoise(xCord, yCord);
    }
}
