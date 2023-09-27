using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _healthCount;

    private Image _healthImage;

    private void Awake() => _healthImage = GetComponent<Image>();

    private void Start() => UpdateUI();

    public void DecreaseHeaslth(float deltaHealth)
    {
        if (_healthCount <= 0)
        {
            return;
        }

        _healthCount -= deltaHealth;
    }

    private void UpdateUI() => _healthImage.fillAmount = _healthCount / 100f;
}
