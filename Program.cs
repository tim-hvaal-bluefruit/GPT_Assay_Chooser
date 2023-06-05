using System;
using System.Windows.Forms;

namespace ExampleGUI
{
    // Main entry point
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // When button is clicked, print "Hello World"
            Console.WriteLine("Hello World!");
        }

        private void InitializeComponent()
        {
            // Create a button and set the Text property to "Click Here" 
            // and the Location and Size properties to desired values
            this.button1 = new System.Windows.Forms.Button();
            this.button1.Text = "Submit User Text";
            this.button1.Location = new System.Drawing.Point(113, 113);
            this.button1.Size = new System.Drawing.Size(75, 75);

            // Connect the Click event of the button to the Event Handler
            this.button1.Click += new System.EventHandler(this.Button_Click);

            // Set the size of the form
            this.ClientSize = new System.Drawing.Size(284, 600);

            // Add the button to the form
            this.Controls.Add(this.button1);

            // Set the name of the form
            this.Name = "MainForm";
        }

        private System.Windows.Forms.Button button1;
    }
}