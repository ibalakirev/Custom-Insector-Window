using UnityEngine;

public class MyRanger : PropertyAttribute
{
    public float _min;
    public float _max;

    public MyRanger(float min, float max)
    {
        _min = min;
        _max = max; 
    }
}
