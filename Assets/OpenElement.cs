using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.IO;


[System.Serializable]
public class ElementData {
    public string name;
    public int number;
    public string phase;
    public float atomic_mass;
    public string symbol;
    public string block;
    public string appearance;
    public string category;
    public float density;
    public float boil;
    public float melt;
}

[System.Serializable]
public class ElementList {
    public List<ElementData> elements;
}

public class OpenElement : MonoBehaviour, IPointerDownHandler {
    public int index;
    ElementList elementList;

    public GameObject elementname;
    public GameObject symbol;
    public GameObject phase;
    public GameObject atomicNumber;
    public GameObject atomicMass;
    public GameObject block;
    public GameObject appearance;
    public GameObject category;
    public GameObject density;
    public GameObject boilingPoint;
    public GameObject meltingPoint;

    TextMeshProUGUI text_Symbol;
    TextMeshProUGUI text_Name;
    TextMeshProUGUI text_phase;
    TextMeshProUGUI text_AtomicNumber;
    TextMeshProUGUI text_AtomicMass;
    TextMeshProUGUI text_Block;
    TextMeshProUGUI text_Appearance;
    TextMeshProUGUI text_Category;
    TextMeshProUGUI text_Density;
    TextMeshProUGUI text_BoilingPoint;
    TextMeshProUGUI text_MeltingPoint;

    // Start is called before the first frame update
    void Start() {
        string jsonData = File.ReadAllText("Assets\\PeriodicTableJSON.json");
        elementList = JsonUtility.FromJson<ElementList>(jsonData);
        text_Symbol = symbol.GetComponent<TextMeshProUGUI>();
        text_Name = elementname.GetComponent<TextMeshProUGUI>();
        text_phase = phase.GetComponent<TextMeshProUGUI>();
        text_AtomicNumber = atomicNumber.GetComponent<TextMeshProUGUI>();
        text_AtomicMass = atomicMass.GetComponent<TextMeshProUGUI>();
        text_Block = block.GetComponent<TextMeshProUGUI>();
        text_Appearance = appearance.GetComponent<TextMeshProUGUI>();
        text_Category = category.GetComponent<TextMeshProUGUI>();
        text_Density = density.GetComponent<TextMeshProUGUI>();
        text_BoilingPoint = boilingPoint.GetComponent<TextMeshProUGUI>();
        text_MeltingPoint = meltingPoint.GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("New Index:"+ index);
        ElementData element = elementList.elements[index];
        Debug.Log("Element:"+ element.name);
        text_Symbol.text = element.symbol;
        text_Name.text = element.name;
        text_phase.text = element.phase;
        text_AtomicNumber.text = ""+element.number;
        text_AtomicMass.text = ""+element.atomic_mass;
        text_Block.text = element.block;
        text_Appearance.text = element.appearance;
        text_Category.text = element.category;
        text_Density.text = ""+element.density;
        text_BoilingPoint.text = ""+element.boil;
        text_MeltingPoint.text = ""+element.melt;
    }


    // Update is called once per frame
    void Update() {
        
    }
}
