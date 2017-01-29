using System;
using UnityEngine;

namespace Astrogator {

	using static DebugTools;
	using static ViewTools;

	/// <summary>
	/// A GUI object allowing the user to edit the settings.
	/// </summary>
	public class SettingsView : DialogGUIVerticalLayout {

		/// <summary>
		/// Construct a GUI object that allows the user to edit the settings.
		/// </summary>
		public SettingsView()
			: base(
				mainWindowMinWidth, 10,
				mainWindowSpacing, mainWindowPadding,
				TextAnchor.UpperLeft
			)
		{
			try {

				AddChild(LabelWithStyleAndSize(
					"Settings:",
					midHdrStyle,
					mainWindowMinWidth, 10
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.GeneratePlaneChangeBurns,
					"Generate plane change burns",
					(bool b) => { Settings.Instance.GeneratePlaneChangeBurns = b; }
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.DeleteExistingManeuvers,
					"Delete existing maneuvers",
					(bool b) => { Settings.Instance.DeleteExistingManeuvers = b; }
				));

				AddChild(LabelWithStyleAndSize(
					"Maneuver creation:",
					midHdrStyle,
					mainWindowMinWidth, 10
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.AutoTargetDestination,
					"Automatically target destination",
					(bool b) => { Settings.Instance.AutoTargetDestination = b; }
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.AutoFocusDestination,
					"Automatically focus destination",
					(bool b) => { Settings.Instance.AutoFocusDestination = b; }
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.AutoEditEjectionNode,
					"Automatically edit ejection node",
					(bool b) => { Settings.Instance.AutoEditEjectionNode = b; }
				));

				AddChild(new DialogGUIToggle(
					() => Settings.Instance.AutoEditPlaneChangeNode,
					"Automatically edit plane change node",
					(bool b) => { Settings.Instance.AutoEditPlaneChangeNode = b; }
				));

			} catch (Exception ex) {
				DbgFmt("Problem constructing settings view: {0}\n{1}",
					ex.Message, ex.StackTrace);
			}
		}

	}

}
