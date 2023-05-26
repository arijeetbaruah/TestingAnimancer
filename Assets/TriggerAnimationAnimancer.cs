using Animancer;
using UnityEngine;
using System.Collections.Generic;

public class TriggerAnimationAnimancer : MonoBehaviour
{
	public AnimancerComponent animancerComponent;

	public List<AnimationClip> clipsList;

	public List<AvatarMask> masks;
	
	private List<List<AnimancerState>> animancerStates;

	private void Start()
	{
		animancerStates = new List<List<AnimancerState>> ();
		for (int i = 0; i < masks.Count; i++)
		{
			animancerComponent.Layers[i].SetMask(masks[i]);
			animancerComponent.Layers[i].SetDebugName($"Layer {i}");

			List <AnimancerState> currentStates = new List<AnimancerState> ();

			for (int j = 0; j < clipsList.Count; j++)
			{
				currentStates.Add(animancerComponent.Layers[i].GetOrCreateState(clipsList[j]));
			}

			animancerStates.Add(currentStates);
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
		animancerComponent.Layers[check].Play(animancerStates[check][check1]);
		//animancerComponent.Layers[check].Play(clipsList[check1], 0f, FadeMode.FromStart);
		//l1.Events.
		//l1.Events.OnEnd += () =>
		//{
		//	l1.Events.NormalizedEndTime = 0;
		//};
	}
}
