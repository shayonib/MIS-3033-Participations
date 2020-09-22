using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Participation_2_WPF
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
    
        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 1;
        }
        public EntryForm(string name, string address, int zipCode)
        {
            this.Name = name;
            this.Address = address;
            this.ZipCode = zipCode;
            
        }
        public override string ToString()
        {
            return (Name + ", " +Address +", " +ZipCode);
        }
        
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnApplication_Click(object sender, RoutedEventArgs e)
        {
            EntryForm entryForm = new EntryForm();
            entryForm.Name = txtName.Text;
            entryForm.Address = txtAddress.Text;
            entryForm.ZipCode = txtZip.Text;
            lboxApplication.Items.Add(entryForm);
            

        }
    }
}
