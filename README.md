# BlazoriseTopHeaderSample

This is Blazorise Layout with Top Header

Theme is modified in App.razor to have BarOptions.HorizontalHeight = "28px"

There is weird behaviour that I see in this sample.

- SideMenu (AppNavMenu.razor) is sliding down when Sidebar is minimalized
- ToggleBar is not visible, even if there is Display attribute modification set to Display.InlineFlex
- Height of horizontal bar is not the same as height of Brand component in vertical bar, so opening and closing dont appears esthetical and theme settings not playing any role
