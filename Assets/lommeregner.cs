using UnityEngine;
using TMPro;

public class lommeregner : MonoBehaviour
{
    public TextMeshProUGUI DisplayText;

    private string currentInput = "";

    private double result = 0;

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "=")
        {
            Calculaterresults();
        }
        else if (buttonValue == "C")
        {

            ClearInput();

        }
        else
        {
            currentInput += buttonValue;
            UpdateDisplay();
        }

    }

    public void Calculaterresults()
    {
        try
        {
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));

            currentInput = result.ToString();
            UpdateDisplay();
        }

        catch (System.Exception)
        {
            currentInput = "Error";
            UpdateDisplay();
        }





    }

    private void ClearInput()
    {
        currentInput = "";
        result = 0.0;
        UpdateDisplay();


    }

    private void UpdateDisplay()
    {

        DisplayText.text = currentInput;

      }
}
