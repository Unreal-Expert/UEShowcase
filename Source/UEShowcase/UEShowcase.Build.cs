// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UEShowcase : ModuleRules
{
	public UEShowcase(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
