using UnityEngine;
using System.Collections;

public class Earthquake : MonoBehaviour {
	private static Transform tr;
	private static float elapsed, Duration, Power, percentComplete;
	private static bool i_Mode;
	private static Vector3 originalPosition;

	private void Start()
	{
		percentComplete = 1;
		tr = GetComponent<Transform>();
	}
	private void Update()
	{
		if (elapsed < Duration)
		{
			elapsed += Time.deltaTime;
			percentComplete = elapsed / Duration;
			percentComplete = Mathf.Clamp01(percentComplete);
			Vector3 rnd = Random.insideUnitSphere * Power * (1f - percentComplete);
			if (i_Mode)tr.localPosition = originalPosition + rnd;
		}
	}
	public static void Shake(float duration, float power)
	{
		if(percentComplete == 1) originalPosition = tr.localPosition;
		i_Mode = true;
		elapsed = 0;
		Duration = duration;
		Power = power;
	}
}
