namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {

        DelegateNumber DelegateNumber;
        DelegateText DelegateText;

        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = textBoxFirst.Text.ToString();
            StudentInfoClass.LastName = textBoxLast.Text.ToString();
            StudentInfoClass.MiddleName = textBoxMiddle.Text.ToString();
            StudentInfoClass.Address = textBoxAddress.Text.ToString();
            StudentInfoClass.Program = comboBoxProgram.Text.ToString();
            StudentInfoClass.Age = long.Parse(textBoxAge.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(textBoxStrudentNo.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(textBoxContact.Text.ToString());

            FrmConfirm FormConfirm = new FrmConfirm();
            FormConfirm.ShowDialog();
        }

    }
}