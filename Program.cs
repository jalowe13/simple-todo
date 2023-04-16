namespace todolist;

using Humanizer;


static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Versioning
        int major_version = 0;
        int minor_version = 0;
        int patch_version = 0;

        String version = major_version.ToString() + "." + minor_version.ToString();
        if (patch_version != 0)
        {
            version += "." + patch_version.ToString();   
        }
        
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.


        // Create a new form.
        Form1 app = new Form1();

        // Set the form's Text property.
        app.Text = "Jacob's Todo List v." + version;

        // Show the form.
        app.Show();

        // Start the message loop.
        Application.Run(app);
        
    }
}