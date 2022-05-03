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
using BiblioConces;

namespace AutoConces
{
    public partial class FrmConces : Form
    {
        public FrmConces()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {//affichage
            pnlAff.Visible = true;
            

            //insertion
            pnlInsert.Visible = false;
            
            //suppression
            pnlSuppr.Visible = false;
           
        }

        private void btnenvoyer_Click(object sender, EventArgs e)
        {
            

            listView1.Items.Clear();
            List<Conces> lesConces = new List<Conces>();
            //connexion*

            String chConnexion = "SERVER=localhost;DATABASE=bdOccasion; UID=root;";
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            //choix de la recherche
            string req = "select * from Concessionnaire";
            if (comboBox1.Text == "Ville")
            {
                req += " where ville = ";

            }
            else if (comboBox1.Text == "Nom")
            {
                req += " where nom = ";
            }
            else if (comboBox1.Text == "Code Postal")
            {
                req += " where codePostal = ";
            }
            else//exception erreur de saisi txtaff 
            {
                req += " where idConces =";
                MessageBox.Show("Vous n'avez rien saisi comme critère de sélection.");
            }
            
            req = req + "'" + txtaff.Text + "'";

            MySqlCommand cmd = new MySqlCommand(req, cnx);
            MySqlDataReader lecteur = cmd.ExecuteReader();
                     
            //affichage dans listview
            while (lecteur.Read())
            {
                ListViewItem liste = new ListViewItem(new string[] {
                                                lecteur[0].ToString(), // id
                                                lecteur[1].ToString(), // nom
                                                lecteur[2].ToString(), // prenom
                                                lecteur[3].ToString(),//adresse
                                                lecteur[4].ToString(),//cp
                                                lecteur[5].ToString()//ville

                },
                                               -1) ;
                //incrémentation de la liste dans le ListView 
                this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { liste });
            }
            
            lecteur.Close();
            cnx.Close();
            
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {//affichage 
            pnlAff.Visible = false;
            
            //insertion
            pnlInsert.Visible = true;
            
            //supression
            pnlSuppr.Visible = false;
            
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {//affichage
            pnlAff.Visible = true;
            
            //insertion
            pnlInsert.Visible = false;           

            //suppr
            pnlSuppr.Visible = false;
           
        }

        private void btninsert_Click(object sender, EventArgs e)
        {//affichage
            listView1.Items.Clear();
            List<Conces> lesConces = new List<Conces>();
            //connexion*

            string chConnexion = "SERVER=localhost;DATABASE=bdOccasion; UID=root;";
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            //recupération du last id + insertion des nouvelles données
            string req1 = "select max(idConces) from Concessionnaire";
            MySqlCommand cmd0 = new MySqlCommand(req1, cnx);
            int lastid = Convert.ToInt32(cmd0.ExecuteScalar());
           
            string req2 = string.Format("insert into concessionnaire values(@id , @nom , @prenom, @adresse, @cp, @ville);");
            //placement des données en parametres + valeur récuperer dans les textBox
            MySqlCommand cmdAjout = new MySqlCommand(req2, cnx);
            cmdAjout.Parameters.Add("@id", MySqlDbType.Int32);
            cmdAjout.Parameters["@id"].Value = lastid + 1;

            cmdAjout.Parameters.Add("@nom", MySqlDbType.VarChar);
            cmdAjout.Parameters["@nom"].Value = txtnom.Text;

            cmdAjout.Parameters.Add("@prenom", MySqlDbType.VarChar);
            cmdAjout.Parameters["@prenom"].Value = txtpren.Text;

            cmdAjout.Parameters.Add("@adresse", MySqlDbType.VarChar);
            cmdAjout.Parameters["@adresse"].Value = txtadresse.Text;

            cmdAjout.Parameters.Add("@cp", MySqlDbType.VarChar);
            cmdAjout.Parameters["@cp"].Value = txtcp.Text;

            cmdAjout.Parameters.Add("@ville", MySqlDbType.VarChar);
            cmdAjout.Parameters["@ville"].Value = txtville.Text ;
            
            
            try//Exeception pour erreur de saisi dans insertion
            {
                cmdAjout.ExecuteNonQuery();
                MessageBox.Show("Votre requète a été envoyé");

            }
            catch
            {
                MessageBox.Show("Vous n'avez pas saisi correctement.");

            }

        }

        private void btsuppr_Click(object sender, EventArgs e)
        {//suppresion
            string chConnexion = "SERVER=localhost;DATABASE=bdOccasion; UID=root;";
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            //requete de suppression selon l'id
            string req2 = "Delete from concessionnaire where idConces = @id;";    

            MySqlCommand cmdSuppr = new MySqlCommand(req2, cnx);
            cmdSuppr.Parameters.Add("@id", MySqlDbType.Int32);
            cmdSuppr.Parameters["@id"].Value = txtId.Text;
            try
            {//verif saisi si vide
                cmdSuppr.ExecuteNonQuery();
                MessageBox.Show("Votre requète a été envoyé");
            }
            catch(Exception ex)
            {

                MessageBox.Show("Vous n'avez pas rentré la bonne valeur.");
            }
           
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {//affichage
            pnlAff.Visible = false;            

            //insertion
            pnlInsert.Visible = false;           

            //suppression
            pnlSuppr.Visible = true;            
        }

        private void btnafct_Click(object sender, EventArgs e)
        {//afficher tout
            listView1.Items.Clear();
            List<Conces> lesConces = new List<Conces>();
            //connexion*

            String chConnexion = "SERVER=localhost;DATABASE=bdOccasion; UID=root;";
            MySqlConnection cnx = new MySqlConnection(chConnexion);
            cnx.Open();
            //choix de la recherche
            string req = "select * from Concessionnaire";


            MySqlCommand cmd = new MySqlCommand(req, cnx);
            MySqlDataReader lecteur = cmd.ExecuteReader();



            //affichage dans listview
            while (lecteur.Read())
            {
                ListViewItem liste = new ListViewItem(new string[] {
                                                lecteur[0].ToString(), // id
                                                lecteur[1].ToString(), // nom
                                                lecteur[2].ToString(), // prenom
                                                lecteur[3].ToString(),//adresse
                                                lecteur[4].ToString(),//cp
                                                lecteur[5].ToString()//ville

                },
                                               -1);
                this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { liste });
            }

            lecteur.Close();
            cnx.Close();

        }
            private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Close();
            }

       
    }
    
}
