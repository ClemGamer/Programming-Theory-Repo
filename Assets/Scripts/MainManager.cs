using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] Text displayText;

    [SerializeField] Shape[] shapes;
    [SerializeField] GameObject contentParent;

    // Start is called before the first frame update
    void Start()
    {
        SpawnShapes();
    }

    void SpawnShapes()
    {
        foreach (var shape in shapes)
        {
            var instance = Instantiate(shape, contentParent.transform);
            instance.ShapeName = "Shape " + shape.name;
            instance.Text = displayText;
        }
    }
}
