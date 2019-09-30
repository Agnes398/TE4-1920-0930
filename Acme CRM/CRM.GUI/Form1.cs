using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.GUI
{
    public partial class Form1 : Form
    {
        ArrayList MyEmployees = new ArrayList();
        ArrayList MyCustomers = new ArrayList();
        public Form1()
        {
            InitializeComponent();

            button1.Text = "Spara kund";
            button2.Text = "Spara anställd";
            button3.Text = "Visa";

            label1.Text = "Kunder";
            label2.Text = "Anställda";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Spara kund
            //Var ska kunden sparas?
            //repository = "sparenhet" (ex: DB, fil, array etc)
            //vi vill göra det enkelt, vi väljer en ArrayList

            MyCustomers.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text, Type = "Customer" });


            //visa för användaren att kunden är sparad

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty; //detta tar ingen plats och är en logisk representation av tom sträng

            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyEmployees.Add(new Employee() { FirstName = textBox1.Text, LastName = textBox2.Text, Type = "Employee" });

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;


            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            //skriv ut alla kunder som ligger i repository
            foreach (Customer c in MyCustomers)
            {
                listBox1.Items.Add(c.FirstName); //vad kommer vi få se utskrivet?
                listBox1.Items.Add(c.LastName);
                listBox1.Items.Add(c.Type);

                //kunna lägga till både kunder och anställda och även kunna se vilken typ av person de är (anställda eller kund)
            }

            foreach (Employee a in MyEmployees)
            {
                listBox2.Items.Add(a.FirstName);
                listBox2.Items.Add(a.LastName);
                listBox2.Items.Add(a.Type);
            }

        }
    }
}
