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
        private NameModel _model;

        public NameController()
        {
            _model = new NameModel();
        }

        public void DisplayFullName(TextBox fNameTextBox, TextBox sNameTextBox)
        {
            _model.FirstName= fNameTextBox.Text;
            _model.SecondName = sNameTextBox.Text;

            ///Display Message
            Display(_model);    
        }

        private void Display(NameModel model)
        {
            MessageBox.Show($"{model.FirstName} {model.SecondName}");
        }

    }
}
