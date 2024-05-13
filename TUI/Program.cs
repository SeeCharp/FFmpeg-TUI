using Terminal.Gui;

namespace TUI;

class Program {
    private static void Main() {
        Application.Init();
        var top = Application.Top;

        // Creates the top-level window to contain the UI
        var win = new Window("FFmpeg TUI") {
            X = 0,
            Y = 1, // Leave one row for the top-level menu
            Width = Dim.Fill(),
            Height = Dim.Fill() - 1
        };
        top.Add(win);

        // Add a menu
        var menu = new MenuBar(new MenuBarItem[] {
            new MenuBarItem("_File", new MenuItem[] {
                new MenuItem("_Quit", "", () => { Application.RequestStop(); })
            }),
        });
        top.Add(menu);

        // Add some controls
        win.Add(
            new Label(3, 2, "Enter command options:"),
            new TextField(25, 2, 40, ""),
            new Button(3, 4, "Run"),
            new ListView(new Rect(3, 6, 100, 4), new List<string> { "Output will be shown here..." })
        );

        Application.Run();
    }
}