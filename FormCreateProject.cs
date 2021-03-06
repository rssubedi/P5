using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormCreateProject : Form
    {
        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void PreferenceCreateProject_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FakeProjectRepository projectRepository = new FakeProjectRepository();
            Project project = new Project();
            project.Name = textBoxProjectName.Text.Trim();
            int assignedProjectId;
            string result = projectRepository.Add(project, out assignedProjectId);
            if (result == FakeProjectRepository.NO_ERROR)
            {
                MessageBox.Show("Project added successfully.");
            }
            else
            {
                MessageBox.Show("Project not created. " + result, "Attention.");
            }
            this.Close();
        }
    }
}