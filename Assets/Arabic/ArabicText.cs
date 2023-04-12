using TMPro;
using UnityEngine;
using System.Linq;
using ArabicDLL;

public class ArabicText : MonoBehaviour
{
    private TextMeshProUGUI tmpText;

    void Start()
    {
        tmpText = GetComponent<TextMeshProUGUI>();

        if (tmpText != null)
        {
            Refresh();
        }
    }

    /// <summary>
    /// text가 변경되었을 때 호출
    /// </summary>
    public void Refresh()
    {
        string text = ArabicSupport.Processing(tmpText.text);
        if (tmpText.isRightToLeftText)
        {
            tmpText.text = new string(text.Reverse().ToArray());
        }
        else
        {
            tmpText.text = text;
        }
    }

    public void SetText(string text)
    {
        tmpText.text = text;
        Refresh();
    }
}
