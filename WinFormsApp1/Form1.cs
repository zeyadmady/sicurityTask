using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnValidate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            errorProvider1.Clear();
            lblResult.Text = "";

            if (!Regex.IsMatch(txtName.Text.Trim(), @"^[A-Za-z\u0600-\u06FF\s]{3,}$"))
            {
                errorProvider1.SetError(txtName, "Invalid Name.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[\w\.-]+@[\w\.-]+\.\w+$"))
            {
                errorProvider1.SetError(txtEmail, "Invalid Email.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^(\+?\d{1,3})?\s?\d{10}$"))
            {
                errorProvider1.SetError(txtPhone, "Invalid Phone Number.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$"))
            {
                errorProvider1.SetError(txtPassword, "Invalid Password.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Invalid Address.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtPostalCode.Text, @"^\d{5,6}$"))
            {
                errorProvider1.SetError(txtPostalCode, "Invalid Postal Code.");
                isValid = false;
            }

            if (isValid)
                lblResult.Text = "All data has been successfully verified.✅";
            else
                lblResult.Text = "There are invalid entered data.❌";
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnParseCV_Click(object sender, EventArgs e)
        {
            string cvText = rtxtCVInput.Text;
            rtxtCVOutput.Clear();

            var nameMatch = Regex.Match(cvText, @"(?i)(?:Name[:\-]?\s*)([A-Z][a-z]+(?:\s[A-Z][a-z]+)+)");
            string fullName = nameMatch.Success ? nameMatch.Groups[1].Value : "Name not found ❌";

            var emailMatch = Regex.Match(cvText, @"[\w\.-]+@[\w\.-]+\.\w+");
            string email = emailMatch.Success ? emailMatch.Value : "Email not found ❌";

            var phoneMatch = Regex.Match(cvText, @"\+?\d[\d\s\-\(\)]{7,}\d");
            string phone = phoneMatch.Success ? phoneMatch.Value : "Phone number not found ❌";

            var skillMatches = Regex.Matches(cvText, @"C#|Java|Python|SQL|JavaScript|Flutter|Dart", RegexOptions.IgnoreCase);
            string skills = skillMatches.Count > 0 ? string.Join(", ", skillMatches) : "Skills not found ❌";

            var expMatch = Regex.Match(cvText, @"(\d+)\s+(?:years?|سنوات)", RegexOptions.IgnoreCase);
            string experience = expMatch.Success ? expMatch.Groups[1].Value + " Years" : "Years of experience not found ❌";

            rtxtCVOutput.Text =
                $"👤 Name : {fullName}\n" +
                $"📧 Email: {email}\n" +
                $"📞 Phone No. : {phone}\n" +
                $"💼 Skills : {skills}\n" +
                $"⏳ Years of Experience : {experience}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;   // أو labelFullName.Text
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string skills = txtSkills.Text;
            string experience = txtExperience.Text;

            // نص البيانات لحفظها كـ .txt
            string textData = $"Full Name: {fullName}\nEmail: {email}\nPhone: {phone}\nSkills: {skills}\nExperience: {experience}";

            // بيانات CSV
            string csvHeader = "Full Name,Email,Phone,Skills,Experience";
            string csvData = $"{fullName},{email},{phone},{skills},{experience}";

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text File (*.txt)|*.txt|CSV File (*.csv)|*.csv";
            saveDialog.Title = "Save Extracted CV Data";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                if (path.EndsWith(".txt"))
                {
                    File.WriteAllText(path, textData);
                    MessageBox.Show("Saved as .txt file.");
                }
                else if (path.EndsWith(".csv"))
                {
                    File.WriteAllText(path, csvHeader + Environment.NewLine + csvData);
                    MessageBox.Show("Saved as .csv file.");
                }
            }
        }
    }
}
