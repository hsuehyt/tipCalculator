# Tip Calculator

The `tipCalculator` script calculates tips based on an initial amount and a specified percentage. It's designed for use in Unity projects.

## Usage

1. Attach the `tipCalculator` script to a GameObject in your scene.
2. Set the initial amount (before the tip) using the `amount` field.
3. Specify the tip percentage (as a decimal) using the `percentage` field.
4. The script will automatically display the initial amount using a `TextMeshProUGUI` component.

## Script Details

- **`amount`**: The initial amount before the tip is applied.
- **`percentage`**: The tip percentage (explicitly cast to a float to ensure correct data type).
- **`textMeshPro`**: A private reference to the `TextMeshProUGUI` component.
- **`Start()`**: Initializes the text display with the initial amount.
- **`Update()`**: Empty method (no need for frame-by-frame actions).
- **`CalculateTip()`**: Public method to calculate the tip and update the total amount displayed.

Remember to adjust the `amount` and `percentage` fields as needed for your specific use case. Happy tipping! 🎩💰
