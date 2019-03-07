using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection(GetString());
        private SqlDataAdapter partyDataAdapter;
        private SqlDataAdapter characterSheetDataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataSet partyDataSet = new DataSet();
        private DataSet characterDataSet = new DataSet();

        private static string GetString()
        {
            return "Server=DESKTOP-O1GIALU\\SQLEXPRESS;" +
                "Database=DnDPartyManager;" +
                "Trusted_Connection=True";
        }

        public Form1()
        {
            InitializeComponent();
            dataGridViewParty.SelectionChanged += new EventHandler(LoadSelectedCharacters);
            LoadPartyTable();
        }
        
        private void LoadPartyTable()
        {
            partyDataAdapter = new SqlDataAdapter("SELECT * FROM Party", connection);
            partyDataAdapter.Fill(partyDataSet, "Party");
            dataGridViewParty.DataSource = partyDataSet.Tables["Party"];
        }

        private void LoadSelectedCharacters(object sender, EventArgs e)
        {
            int partyId = Convert.ToInt32(dataGridViewParty.CurrentRow.Cells[0].Value);
            SqlCommand command = new SqlCommand("SELECT * FROM CharacterSheet WHERE raceID=@partyId")
            {
                Connection = new SqlConnection(GetString())
            };

            command.Parameters.AddWithValue("@partyId", partyId);

            characterSheetDataAdapter = new SqlDataAdapter(command);
            characterDataSet = new DataSet();
            characterSheetDataAdapter.Fill(characterDataSet, "CharacterSheet");
            dataGridViewCharacterSheet.DataSource = characterDataSet.Tables["CharacterSheet"];
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            characterSheetDataAdapter = new SqlDataAdapter("SELECT * FROM CharacterSheet", GetString());
            characterDataSet = new DataSet();
            characterSheetDataAdapter.Fill(characterDataSet, "CharacterSheet");
            dataGridViewCharacterSheet.DataSource = characterDataSet.Tables["CharacterSheet"];
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                commandBuilder = new SqlCommandBuilder(characterSheetDataAdapter);
                characterSheetDataAdapter.Update(characterDataSet, "CharacterSheet");
                MessageBox.Show("Updated Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show("Something went wrong :(");
            }
        }
    }
}
