Welcome to the "Set Cursor Sensitivity" Unity Asset.

Summary:
"Set Cursor Sensitivity" is an Unity Plugin that gives you the ability to control the actual sensitivity of your Hardware (OS) Cursor in your screen via Scripting.
You can set a different sensitivity for inside or outside the unity window, you can even create areas with different cursor sensitivity (cursor speed).
The package comes with an Example Scene to help you start and understand its use.
Can be combined with Unity's current API to achieve great effects !
Supports: Unity 3x,4x,5x,2017x

What you actually get:
 ~Source Code
 
 ~Forum/Email support
  (As far as its possible and related to the plugin)
 
 ~New Scripting API.
  -SystemCursor.ResetSensitivity();
  -SystemCursor.ResetSensitivity(int Speed);
  -SystemCursor.SetSensitivity(int Speed);
  -SystemCursor.SetGlobalSensitivity(int Speed);
  -SystemCursor.GetGlobalSensitivity();
  -SystemCursor.SetLocalSensitivity(int Speed);
  -SystemCursor.GetLocalSensitivity();
  -SystemCursor.SetCustomSensitivity(int Speed);
  -SystemCursor.GetCurrentCustomSensitivity();
  -SystemCursor.GetCurrentSensitivity();

  
 Notes: 
 Works outside of the unity window too, and Global sensitivity will not automatically reset after you close the window.
 Works on both Unity Pro and free, but this is a windows only plugin.

How to install the plugin:
 The first thing you may want to do is use it , but you will have read the Installation_Guide.txt

API Documentation:
--------------------------------------------------------------
  -SystemCursor.ResetSensitivity();
Resets cursor sensitivity to 8. Values range from 1 to 20
--------------------------------------------------------------
  -SystemCursor.ResetSensitivity(int Speed);
Resets cursor sensitivity to "Speed", values restrictions still apply.
--------------------------------------------------------------
  -SystemCursor.SetSensitivity(int Speed);
Sets Global Local and Custom sensitivity speeds to "Speed", in other words overrides every other value to set a new speed everywhere. (Even outside the unity window)
--------------------------------------------------------------
  -SystemCursor.SetGlobalSensitivity(int Speed);
Sets Global sensitivity to "Speed", the cursors new sensitivity will take effect ONLY outside the unity window. Inside the window and inside custom areas speed will remain as it was.
--------------------------------------------------------------
  -SystemCursor.GetGlobalSensitivity();
Returns current Global mouse Sensitivity as an integer.
--------------------------------------------------------------
  -SystemCursor.SetLocalSensitivity(int Speed);
Will set the Cursor sensitivity to "Speed" but this effect will only take place inside the unity window. Outside the window (and inside custom zones) the old speed will be preserved.
--------------------------------------------------------------
  -SystemCursor.GetLocalSensitivity();
Returns current Local mouse sensitivity as an integer.
--------------------------------------------------------------
  -SystemCursor.SetCustomSensitivity(int Speed);
Now this is tricky, this function is used to create custom areas, zones or speed effects. What you must do is call this function with "Speed" as you desired new sensitivity and after that
whenever you call this "SystemCursor.InsideCustomArea = true" the speed will take effect (only inside unity window) but remember when you want to "SystemCursor.InsideCustomArea = false".
--------------------------------------------------------------
  -SystemCursor.GetCurrentCustomSensitivity();
Returns current Custom mouse sensitivity as an integer.
--------------------------------------------------------------
  -SystemCursor.GetCurrentSensitivity();
Returns current mouse sensitivity as an integer.
--------------------------------------------------------------
--------------------------------------------------------------

Contact Info :
Email : DarknessBlade.Original@gmail.com
Youtube : https://www.youtube.com/DarknessBladeOrigin
Forum Thread: https://forum.unity.com/threads/set-cursor-sensitivity-system-cursor.528044/