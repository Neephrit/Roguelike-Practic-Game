using UnityEngine;
using UnityEngine.UI;

public class InfoGame : MonoBehaviour
{
    [SerializeField] private Text _autorText;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _versionText;

    private void Update()
    {
        _autorText.text = "Made by " + Application.companyName;
        _nameText.text = Application.productName;
        _versionText.text = "Version: " + Application.version;
    }
}
