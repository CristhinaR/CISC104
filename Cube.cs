using System;
using UnityEngine;

public class Cube
{
    private float length;
    private float height;
    private float width;
    //private float volume;
    //private float edgelength;


    public Cube()
    {
        // Default values for my instantiated rectangle.
        length = 1f;
        height = 1f;
        width = 1f;
        //volume = 0f;
        //edgelength = 0f;
    }

    public Cube(float newlength, float newHeight, float newWidth)
    {
        // Should consider testing for positive numbers before accepting the parameters

        length = newlength;
        height = newHeight;
        width = newWidth;
    }

    public float GetVolume()
    {
        return length * width * height;
    }

    public float GetEdgeLength()
    {
        return  (length*width*height) / (height * width);
    }

    public float GetLength()
    {
        return length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }
}