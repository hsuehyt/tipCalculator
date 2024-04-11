using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// This class is responsible for calculating tips based on an amount and a percentage.
public class tipCalculator : MonoBehaviour
{
    public int amount = 0; // The initial amount before the tip is applied.

    // The tip percentage is explicitly cast to a float to ensure the correct data type is used.
    // This is necessary because 0.2 is a double literal by default.
    public float percentage = (float)0.2;

    // A private variable to hold the reference to the TextMeshProUGUI component.
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update.
    // It is used for initialization.
    void Start()
    {
        // Get the TextMeshProUGUI component attached to the GameObject this script is attached to.
        textMeshPro = GetComponent<TextMeshProUGUI>();

        // Initialize the text display to show the initial amount.
        textMeshPro.text = $"Amount: {amount}";
    }

    // Update is called once per frame.
    // In this script, it is left empty as there is no need to perform actions every frame.
    void Update()
    {
        // Typically, you'd handle input or perform actions that need to be checked or updated every frame here.
    }

    // This public method calculates the tip based on the amount and the percentage.
    public void CalculateTip()
    {
        // Calculate the tip amount by multiplying the amount by the percentage.
        // The result is a float because percentage is a float.
        float tipAmount = (float)amount * percentage;

        // Calculate the total amount by adding the tipAmount to the original amount.
        // The result is cast to an int to match the data type of amount.
        int totalAmount = (int)(tipAmount + amount);

        // Update the textMeshPro text to display both the initial amount and the total amount including the tip.
        // The \n is used to display the total amount on a new line.
        textMeshPro.text = $"Amount: {amount}\nTotal Amount: {totalAmount}";
    }
}
