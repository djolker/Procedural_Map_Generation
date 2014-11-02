using UnityEngine;
using System.Collections;
using System.Xml;

public class Section {
    public bool[] openings = new bool[4];
    public GameObject zone;

    Section(GameObject z, bool[] ends)
    {
        openings = ends;
        zone = z;
    }
}
