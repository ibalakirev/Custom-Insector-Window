using UnityEngine;

public class Modificult : MonoBehaviour
{
    [SerializeField, MyRanger(1, 100)] private float _size;
    [SerializeField, MyRanger(1, 100)] private int _sizeInt;
    [SerializeField, MyRanger(1, 100)] private string _sizeString;
}
