using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override GameObject createShape() {
        return GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}
