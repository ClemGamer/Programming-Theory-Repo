using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    protected string shapeName;

    public Text Text;
    
    public string ShapeName
    {
        get => shapeName;
        set
        {
            var maxLength = 50;
            if (value.Length > maxLength)
            {
                Debug.Log("The ShapeName's length of the shape can not greater than " + maxLength);
            }
            else
            {
                shapeName = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(DisplayText);
    }

    protected virtual void DisplayText()
    {
        Text.text = "I'm SSSSSSSSape!!";
    }
}
