// Copyright Epic Games, Inc. All Rights Reserved.

#include "UEShowcaseGameMode.h"
#include "UEShowcaseCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUEShowcaseGameMode::AUEShowcaseGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
