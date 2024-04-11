using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tipCalculator : MonoBehaviour
{
    public int amount = 0;
    public float percentage = .2F;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Amount: {amount}";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CalculateTip()
    {
        float tipAmount = (float) amount * percentage;
        int totalAmount = (int) tipAmount + amount;
        
        textMeshPro.text = $"Amount: {amount}\nTotal Amount: {totalAmount}";
    }
}
