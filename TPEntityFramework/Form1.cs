using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEntityFramework
{
    public partial class Form1 : Form
    {
        mescontactsEntities context;
        public Form1()
        {
            InitializeComponent();
            context = new mescontactsEntities();
        }

        private void btnSql1_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.SqlQuery("SELECT * FROM contacts");
            foreach(contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom);
            }
        }

        private void btnSql2_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.ToList();
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom: " + c.nom);
            }
        }

        private void btnSql3_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.ToList();
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }

        private void btnSql4_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.Where(c => c.groupe.nom.Equals("Amis"));
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }

        private void btnSql5_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var mesgroupes = new List<string> { "Travail", "Amis" };
            var contacts = context.contacts.Where(c => mesgroupes.Contains(c.groupe.nom)).ToList();
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }

        private void btnSql6_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.SqlQuery("SELECT * FROM contacts JOIN groupes ON contacts.groupe_id=groupes.id");
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }

        private void btnSql7_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.SqlQuery("SELECT * FROM contacts JOIN groupes ON contacts.groupe_id = groupes.id" +
                " WHERE groupes.nom='Amis'");
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }

        private void btnSql8_Click(object sender, EventArgs e)
        {
            //mescontactsEntities context = new mescontactsEntities();
            var contacts = context.contacts.SqlQuery("SELECT * FROM contacts JOIN groupes ON contacts.groupe_id = groupes.id " +
                "WHERE groupes.nom IN('Amis','Travail')");
            foreach (contact c in contacts)
            {
                MessageBox.Show("Nom : " + c.nom + "\nGroupe : " + c.groupe.nom);
            }
        }
    }
}
