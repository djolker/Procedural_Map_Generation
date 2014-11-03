using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class MapScript : MonoBehaviour {
    public List<Section> grid = new List<Section>();
    public List<Section> ends = new List<Section>();

	// Use this for initialization
	void Start () {
        XmlTextReader reader = new XmlTextReader("Assets/MapParts/zoneOpenings.xml");
        while (reader.Read())
        {
            switch(reader.NodeType)
            {
                case XmlNodeType.Element:
                    Debug.Log(reader.Name);
                    
                break;
            }
        }
	}
	
	
}
