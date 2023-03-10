using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class PremiosReglas : AchievementRules
{

	// Start is called before the first frame update

	

	public virtual void OnMMEvent(MMCharacterEvent characterEvent)
	{
		if (characterEvent.TargetCharacter.CharacterType == Character.CharacterTypes.Player)
		{
			switch (characterEvent.EventType)
			{
				case MMCharacterEventTypes.Jump:
					//MMAchievementManager.AddProgress("JumpAround", 1);
					break;
			}
		}
	}

	public virtual void OnMMEvent(CorgiEngineEvent corgiEngineEvent)
	{
		switch (corgiEngineEvent.EventType)
		{
			case CorgiEngineEventTypes.LevelEnd:
				//MMAchievementManager.UnlockAchievement("PrincessInAnotherCastle");
				break;
			case CorgiEngineEventTypes.PlayerDeath:
				//MMAchievementManager.UnlockAchievement("DeathIsOnlyTheBeginning");
				break;
		}
	}

	public virtual void OnMMEvent(PickableItemEvent pickableItemEvent)
	{
		if (pickableItemEvent.PickedItem != null)
		{
			if (pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
			{
				//MMAchievementManager.AddProgress("MoneyMoneyMoney", 1);
			}
			if (pickableItemEvent.PickedItem.GetComponent<Stimpack>() != null)
			{
				//MMAchievementManager.UnlockAchievement("Medic");
			}
		}
	}
}
