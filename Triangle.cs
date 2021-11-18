using System;
using System.Collections.Generic;
using System.Text;

class Triangle
{
    private float width;
    private float height;

    public Triangle(float i, float j)
    {
        this.width = i;
        this.height = j;
    }
    public float GetSurface()
    {
        return width * height / 2;
    }
}
