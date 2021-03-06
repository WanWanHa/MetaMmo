// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MetaMMO : ModuleRules
{
	public MetaMMO(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "UMG", "Slate", "SlateCore", "KBEnginePlugins" });

    }
}
