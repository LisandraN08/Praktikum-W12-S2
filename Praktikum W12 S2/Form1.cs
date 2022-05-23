
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_W12_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtTeam = new DataTable();
        int PosisiSekarang = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select * from dt_player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            sqlQuery = "select * from dt_team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            lblIDLama.Text = dtPemain.Rows[Posisi][0].ToString();
            tBoxPlayerID.Text = dtPemain.Rows[Posisi][1].ToString();
            tBoxPlayerName.Text = dtPemain.Rows[Posisi][2].ToString();
            dTimeBirthdate.Value = Convert.ToDateTime(dtPemain.Rows[Posisi][3]);
            dTimeBirthdate.CustomFormat = "dd-MMM-yyyy";
            dTimeBirthdate.Format = DateTimePickerFormat.Custom;
            cBoxNationality.Text = dtPemain.Rows[Posisi][4].ToString();
            cBoxTeam.Text = dtPemain.Rows[Posisi][5].ToString();
            dUpDownTeamNumber.Text = dtPemain.Rows[Posisi][6].ToString();
            PosisiSekarang = Posisi;
        }

        private void btnBackAll_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btnNextAll_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }

        private void dUpDownTeamNumber_SelectedItemChanged(object sender, EventArgs e)
        {
            Team();
        }
        private void Team()
        {
            DataTable dtTeam = new DataTable();
            sqlQuery = "SELECT * FROM dt_player WHERE team_name='"+cBoxTeam.Text+"' and team_number='"+dUpDownTeamNumber.Text+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            if (dtTeam.Rows.Count > 0)
            {
                lblAvailability.Text = "Not Available";
            }
            else
            {
                lblAvailability.Text = "Available";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            if (lblAvailability.Text == "Available")
            {

                for (int i = 0; i < dtTeam.Rows.Count; i++)
                {
                    if (dtPemain.Rows[PosisiSekarang][0].ToString() == dtTeam.Rows[i][7].ToString())
                    {
                        sqlQuery = "update dt_team set captain_id= (SELECT player_id FROM dt_player WHERE birthdate = (SELECT MIN(birthdate) FROM dt_player WHERE team_name ='" + cBoxTeam.Text + "' )) where  captain_id='" + lblIDLama.Text + "'";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                        i = dtTeam.Rows.Count - 1;
                    }
                    else
                    {
                        i++;
                    }
                }
                sqlQuery = "update dt_player set player_id='" + tBoxPlayerID.Text + "', player_name='" + tBoxPlayerName.Text + "', birthdate= '" + dTimeBirthdate.Value.ToString("yyyyMMdd") + "', nation= '" + cBoxNationality.Text + "', team_name = '" + cBoxTeam.Text + "', team_number= '" + dUpDownTeamNumber.Text + "' where  id_lama='" + lblIDLama.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data pemain baru dengan nama '" + tBoxPlayerName.Text + "' telah ditambahkan");
            }
            else
            {
                MessageBox.Show("Pemain dengan nomer '" + dUpDownTeamNumber.Text + "' sudah ada");
            }
            sqlConnect.Close();
        }
    }
}
