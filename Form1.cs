namespace todolist;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        RichTextBox tb_entry = new RichTextBox();
        tb_entry.Location = new Point(10,10);
        tb_entry.Size = new Size(700,100);
        tb_entry.WordWrap = true;
        tb_entry.Text = "Welcome to the todo list please enter what you need to do below";

        tb_entry.Font = new Font("Arial", 15, FontStyle.Bold);
        tb_entry.ForeColor = Color.Red;
        this.Controls.Add(tb_entry);
        tb_entry.ReadOnly = true;
        tb_entry.Enabled = false;

    }
    
}
