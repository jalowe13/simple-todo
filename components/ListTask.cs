// Jacob Lowe
namespace todolist;

public partial class ListTask
{
    private Button complete;
    private Button clear;
    private RichTextBox new_task;

    private int y_pos;


    public ListTask(Button button1, Button button2, RichTextBox text, int y)
    {
        y_pos = y;
        complete = button1;
        clear = button2;
        new_task = text;
        complete.Click += new EventHandler(complete_Click);
        clear.Click += new EventHandler(clear_Click);
    }

    // Remove textbox on call
    private void complete_Click(object? sender, EventArgs? e)
    {
        this.complete.Visible = false;
        this.clear.Visible = false;
        this.new_task.Visible = false;
    }

    // Clear textbox on call
    private void clear_Click(object? sender, EventArgs? e)
    {
        new_task.Text = "";
        this.y_pos -= 20;
    }

    // Move tasks back up that have been bumped
    public void bump_locations()
    {
        this.complete.Location = new Point(710, y_pos);
        this.clear.Location = new Point(730, y_pos);
        this.new_task.Location = new Point(10, y_pos);
    }
}
