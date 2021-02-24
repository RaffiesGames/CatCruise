// Raffie made this!

using UnrealBuildTool;
using System.Collections.Generic;

public class CatCruiseEditorTarget : TargetRules
{
	public CatCruiseEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "CatCruise" } );
	}
}
