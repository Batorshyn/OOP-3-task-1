using FactoryMethod;

namespace OOP_3_task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NotificationCreator creator = cbType.SelectedIndex switch
            {
                0 => new SuccessDialogCreator(),
                1 => new ErrorDialogCreator(),
                _ => throw new InvalidOperationException("Невідомий тип")
            };

            creator.Display(lblOutput, txtMessage.Text);
        }
    }
}
