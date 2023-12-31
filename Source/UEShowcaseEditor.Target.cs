// © 2023 Every Good Work, Inc. All rights reserved. This project is developed using Unreal Engine. No part of this project may be reproduced, distributed, or transmitted in any form or by any means without the prior written permission of Every Good Work, Inc.

using UnrealBuildTool;
using System.Collections.Generic;

public class UEShowcaseEditorTarget : TargetRules
{
	public UEShowcaseEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "UEShowcase" } );
	}
}
