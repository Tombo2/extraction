// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PluginIntegration : ModuleRules
{
	public PluginIntegration(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(new string[] {"InventoryPlugin"});
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        //       CppStandard = CppStandardVersion.Cpp17;
        CppStandard = CppStandardVersion.Default;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule","UMG", "Niagara", "InventoryPlugin", "MultiplayerChatPlugin", "DialogAndQuestPlugin"});
    }
}
