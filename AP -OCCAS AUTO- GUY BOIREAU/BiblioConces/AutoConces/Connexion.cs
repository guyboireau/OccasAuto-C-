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
using System.Text.RegularExpressions;

namespace AutoConces
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        public static string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = RemoveSpecialCharacters(textBox1.Text);
            string mdp = RemoveSpecialCharacters(textBox2.Text);

            if (login != String.Empty && mdp != String.Empty)
            {              
                   

                //string regex = "^.*$";
                /*string mdp = Regex.Matches(textBox2.Text.ToString(),regex ).ToString();
                string login = Regex.Matches(textBox1.Text.ToString(), regex).ToString();*/

                String chConnexion = "SERVER=localhost;DATABASE=bdoccasion2; UID=root;";
                MySqlConnection cnx = new MySqlConnection(chConnexion);
                cnx.Open();
                //choix de la recherche
                string req = "select pseudo,mdp from Users where pseudo ='" + login + "'";
                MySqlCommand cmd = new MySqlCommand(req, cnx);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                while (lecteur.Read())
                {
                    if (lecteur[0] == null || lecteur[1] == null)
                    {
                        lecteur.Close();
                        MessageBox.Show("Impossible de vous connecter");
                    }
                    else if (lecteur[0].ToString().Equals(login) && lecteur[1].ToString().Equals(mdp))
                    {
                        Close();
                    }
                    else if (!lecteur[1].ToString().Equals(mdp))
                    {
                        MessageBox.Show("Impossible de vous connecter, réessayer");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = RemoveSpecialCharacters(textBox3.Text);
            string mail = RemoveSpecialCharacters(textBox4.Text);
            string mdp = RemoveSpecialCharacters(textBox5.Text);
            if (mdp != String.Empty && mail != String.Empty && login != String.Empty)
            {
                String chConnexion = "SERVER=localhost;DATABASE=bdoccasion2; UID=root;";
                MySqlConnection cnx = new MySqlConnection(chConnexion);
                cnx.Open();
                //choix de la recherche
                string req = "insert into users (pseudo, mdp, mail) values (@login,@mail,@mdp)";
                MySqlCommand cmdAjout = new MySqlCommand(req, cnx);
                cmdAjout.Parameters.Add("@login", MySqlDbType.VarChar);
                cmdAjout.Parameters["@login"].Value = login;

                cmdAjout.Parameters.Add("@mail", MySqlDbType.VarChar);
                cmdAjout.Parameters["@mail"].Value = mail;

                cmdAjout.Parameters.Add("@mdp", MySqlDbType.VarChar);
                cmdAjout.Parameters["@mdp"].Value = mdp;

                try//Exeception pour erreur de saisi dans insertion
                {
                    cmdAjout.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Vous n'avez pas saisi correctement.");
                }

                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string mail = RemoveSpecialCharacters(textBox6.Text);*/
            string mail = textBox6.Text;

            if (mail != String.Empty)
            {


                //string regex = "^.*$";
                /*string mdp = Regex.Matches(textBox2.Text.ToString(),regex ).ToString();
                string login = Regex.Matches(textBox1.Text.ToString(), regex).ToString();*/

                String chConnexion = "SERVER=localhost;DATABASE=bdoccasion2; UID=root;";
                MySqlConnection cnx = new MySqlConnection(chConnexion);
                cnx.Open();
                //choix de la recherche
                string req = "select pseudo,mdp,mail from Users where mail ='" + mail + "'";
                MySqlCommand cmd = new MySqlCommand(req, cnx);
                MySqlDataReader lecteur = cmd.ExecuteReader();
                while (lecteur.Read())
                {
                    if (lecteur[0] == null || lecteur[1] == null)
                    {
                        lecteur.Close();
                        MessageBox.Show("Impossible de vous connecter");
                    }               
                    else if (lecteur[2].ToString().Equals(mail))
                    {
                        label7.Text = "Login : "+ lecteur[0].ToString();
                        label8.Text = "Mdp : " + lecteur[1].ToString();
                    }
                    else if (!lecteur[2].ToString().Equals(mail))
                    {
                        MessageBox.Show("Impossible de vous connecter, réessayer");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas rempli tous les champs");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }
    }
}