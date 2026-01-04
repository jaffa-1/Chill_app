using System.Collections;
using UnityEngine;

public class TabAnimation : MonoBehaviour
{
    ButtonScript baseScript;
    Vector3 startScale = new Vector3(0.75f, 0.75f, 0.75f);
    Vector3 endScale = Vector3.one;

    private void Start()
    {
        baseScript = GetComponent<ButtonScript>();
        baseScript.OnTabToggled += BaseScript_OnTabToggled;
    }

    private void BaseScript_OnTabToggled(object sender, System.EventArgs e)
    {
        StartCoroutine(AnimateWindow());
    }

    private IEnumerator AnimateWindow()
    {
        transform.localScale = startScale;

        float timer = 0;
        float timerMax = 0.25f;
        while (timer < timerMax)
        {
            timer += Time.deltaTime/timerMax;
            transform.localScale = Vector3.Lerp(startScale, endScale, timer);
            yield return null;
        }

        transform.localScale = endScale;
    }
}
