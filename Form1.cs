// Jacob Lowe
namespace todolist;


public partial class Form1 : Form
{
    int task_y = 150;       // Current y
    int task_max_y = 400;   // Maximum y for creating tasks
    public Form1()
    {
        InitializeComponent();


        // Header Textbox
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


        // Create Task Button
        Button create_task = new Button();
        create_task.Location = new Point(10,task_y-20);
        create_task.Text = "Add";
        create_task.Click += new EventHandler(create_task_Click);
        this.Controls.Add(create_task);

    }
    // Check if it is apropriate to create a new task line
    public bool check_task_max()
    {
        if(task_y < task_max_y)
        {
            task_y += 20;
            return true;
        }
        return false;
    }
    // Click action for creating a new task
    private void create_task_Click(object? sender, EventArgs? e)
    {
        // Get the button that was clicked.
        if (sender != null)
        {
            Button button = (Button)sender;

            // Display a message box.
            if (check_task_max())
            {
                // Taskbox
                RichTextBox new_task = new RichTextBox();
                new_task.Location = new Point(10,task_y);
                new_task.Size = new Size(700,20);
                this.Controls.Add(new_task);
                // Complete and clear buttons
                Button complete = new Button();
                Button clear = new Button();
                complete.Location = new Point(710,task_y);
                clear.Location = new Point(730,task_y);
                complete.Size = new Size(20,20);
                clear.Size = new Size(20,20);
                complete.Text = "O";
                clear.Text = "X";

                complete.Click += new EventHandler(complete_Click);
                clear.Click += new EventHandler(clear_Click);
                this.Controls.Add(complete);
                this.Controls.Add(clear);
            }
        }
    }

    // Remove textbox on call
    private void complete_Click(object? sender, EventArgs? e)
    {
        MessageBox.Show("You clicked the complete button.");
    }

    // Clear textbox on call
    private void clear_Click(object? sender, EventArgs? e)
    {
        MessageBox.Show("You clicked the clear button.");
    }


    
}
