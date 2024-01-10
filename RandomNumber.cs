using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumber : MonoBehaviour
{
    private int[] number = new int[2];

    [SerializeField]
    private TextMeshPro[] text_number = new TextMeshPro[2];

    // Start is called before the first frame update
    void Start()
    {
        string view = "";
        for(int i=0; i<number.Length; i++)
        {
            TextMeshPro import_text = text_number[i].GetComponent<TextMeshPro>();
            import_text.text = Random.Range(0, 9).ToString();
            view = view + number[i].ToString() + " ";
        }

        Debug.Log(view);
    }
}