using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SimpleMVC.Model;

namespace SimpleMVC.Controller
{
    public class NameController
    {
        private NameModel _model = null;

        public NameController()
        {
            _model= new NameModel();
        }

        public void SetFullName(string fNameTextBox, string sNameTextBox)
        {
            ///Data from Controller Sent to Model
            _model.FirstName= fNameTextBox;
            _model.SecondName = sNameTextBox;
        }

        public void Display()
        {
            MessageBox.Show($"{_model.FirstName} {_model.SecondName}");
        }

        public void Close(Window window)
        {
            window.Close(); 
        }

    }
}
