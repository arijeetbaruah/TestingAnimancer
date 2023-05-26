using Animancer;
using UnityEngine;
using System.Collections.Generic;

public class TriggerAnimationAnimancer : MonoBehaviour
{
	public AnimancerComponent animancerComponent;

	public List<AnimationClip> clipsList;

	public List<AvatarMask> masks;

	private int upper = -1, lower = -1;

	private void Start()
	{
		for (int i = 0; i < masks.Count; i++)
		{
			animancerComponent.Layers[i].SetMask(masks[i]);
			animancerComponent.Layers[i].SetDebugName($"Layer {i}");
		}

		//animancerComponent.Play(clipsList[0]);

		TriggerAnimation1("00");
		TriggerAnimation1("10");
	}

	public void TriggerAnimation1(string keys)
	{
		//var l1 = 
		int check = int.Parse($"{keys[0]}");
		int check1 = int.Parse($"{keys[1]}");
		
		if (check == 0 )
		{
			upper = check1;
		}
		else
		{
			lower = check1;
		}

		if (upper == lower )
		{
			animancerComponent.Layers[0].Play(clipsList[check]);
			animancerComponent.Layers[1].Weight = 0;
		}
		else
		{
			animancerComponent.Layers[1].Weight = 1;
			animancerComponent.Layers[check].Play(clipsList[check1]);
		}
		//animancerComponent.Layers[check].Play(clipsList[check1], 0f, FadeMode.FromStart);
		//l1.Events.
		//l1.Events.OnEnd += () =>
		//{
		//	l1.Events.NormalizedEndTime = 0;
		//};
	}
}
