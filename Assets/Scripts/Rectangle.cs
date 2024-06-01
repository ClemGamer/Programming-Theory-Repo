using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    protected override void DisplayText()
    {
        Text.text = "I'm Rectangle~~~";
    }
}
