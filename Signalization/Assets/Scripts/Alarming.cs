using UnityEngine;
using DG.Tweening;

public class Alarming : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private AudioSource _audio;

    [SerializeField] private Entering _entering;
    [SerializeField] private Color _switchedOnAlarmColor;
    [SerializeField] private Color _switchedOffAlarmColor;
    [SerializeField] private int _durationOfSwitchingColor;
    [SerializeField] private int _durationOfSwitchingVolume;

    public void Alarm()
    {
        _audio = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        if (_entering.IsEntered)
        {
            _spriteRenderer.DOColor(_switchedOnAlarmColor, _durationOfSwitchingColor).SetLoops(-1, LoopType.Yoyo);
            _audio.Play();
            _audio.DOFade(1, _durationOfSwitchingVolume);
        }
        else
        {
            _spriteRenderer.DOColor(_switchedOffAlarmColor, _durationOfSwitchingColor);
            _audio.Play();
            _audio.DOFade(0, _durationOfSwitchingVolume);
        }
    }
}
