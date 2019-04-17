using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection(GetString());
        private SqlDataAdapter parentDataAdapter;
        private SqlDataAdapter childDataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataSet parentDataSet = new DataSet();
        private DataSet childDataSet = new DataSet();

        private static string GetString()
        {
             
            return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString();

        }

        public Form1()
        {
            InitializeComponent();
            dataGridViewParent.SelectionChanged += new EventHandler(LoadSelectedCharacters);
            LoadParentTable();
        }
        
        private void LoadParentTable()
        {
            parentDataAdapter = new SqlDataAdapter(ConfigurationManager.AppSettings.Get("SelectParent"), connection);
            parentDataAdapter.Fill(parentDataSet, ConfigurationManager.AppSettings.Get("ParentTableName"));
            dataGridViewParent.DataSource = parentDataSet.Tables[ConfigurationManager.AppSettings.Get("ParentTableName")];
        }

        private void LoadSelectedCharacters(object sender, EventArgs e)
        {
            int parentId = Convert.ToInt32(dataGridViewParent.CurrentRow.Cells[0].Value);
            SqlCommand command = new SqlCommand(ConfigurationManager.AppSettings.Get("SelectChild"))
            {
                Connection = new SqlConnection(GetString())
            };

            command.Parameters.AddWithValue(ConfigurationManager.AppSettings.Get("ParentColumn"), parentId);

            childDataAdapter = new SqlDataAdapter(command);
            childDataSet = new DataSet();
            childDataAdapter.Fill(childDataSet, ConfigurationManager.AppSettings.Get("ChildTableName"));
            dataGridViewChild.DataSource = childDataSet.Tables[ConfigurationManager.AppSettings.Get("ChildTableName")];
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            childDataAdapter = new SqlDataAdapter(ConfigurationManager.AppSettings.Get("SelectAllChild"), GetString());
            childDataSet = new DataSet();
            childDataAdapter.Fill(childDataSet, ConfigurationManager.AppSettings.Get("ChildTableName"));
            dataGridViewChild.DataSource = childDataSet.Tables[ConfigurationManager.AppSettings.Get("ChildTableName")];
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                commandBuilder = new SqlCommandBuilder(childDataAdapter);
                childDataAdapter.Update(childDataSet, ConfigurationManager.AppSettings.Get("ChildTableName"));
                MessageBox.Show("Updated Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show("Something went wrong :(" + ex.ToString());
            }
        }
    }
}
