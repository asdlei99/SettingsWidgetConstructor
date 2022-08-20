﻿// Copyright (c) Yevhenii Selivanov.

using UnrealBuildTool;

public class MySettingsWidgetConstructor : ModuleRules
{
	public MySettingsWidgetConstructor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		CppStandard = CppStandardVersion.Latest;

		PublicDependencyModuleNames.AddRange(new[]
			{
				"Core"
				, "UMG" // Created USettingsWidget
				, "GameplayTags" // Created FSettingTag
				// My modules
                , "MyUtils" // Created USettingsDataTable
			}
		);

		PrivateDependencyModuleNames.AddRange(new[]
			{
				"CoreUObject", "Engine", "Slate", "SlateCore" // Core
			}
		);

		if (Target.bBuildEditor)
		{
			// Include Editor modules that are used in this Runtime module
			PrivateDependencyModuleNames.AddRange(new[]
				{
					"UnrealEd" // FDataTableEditorUtils
					// My plugins
					, "MyEditorUtils" // UEditorUtilsLibrary
				}
			);
		}
	}
}
