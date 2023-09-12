using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DellastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DellastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            labelProgram.Text = DelProgram(StudentInfoClass.Program).ToString();
            labellast.Text = DellastName(StudentInfoClass.LastName).ToString();
            labelFirst.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            labelMiddle.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            labelAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            labelContact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            labelAddress.Text = DelAddress(StudentInfoClass.Address).ToString();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }
    }
}
