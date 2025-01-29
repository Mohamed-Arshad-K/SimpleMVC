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
        public void DisplayFullName(string fNameTextBox, string sNameTextBox)
        {
            ///Data from Controller Sent to Model
            NameModel _model= new NameModel();
            _model.FirstName= fNameTextBox;
            _model.SecondName = sNameTextBox;

            ///Data from Model Sent to View 
            Display(_model);    
        }

        private void Display(NameModel model)
        {
            MessageBox.Show($"{model.FirstName} {model.SecondName}");
        }

        public void Close(Window window)
        {
            window.Close(); 
        }

    }
}
