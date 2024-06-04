using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MUD
{

    public partial class MUDView : Window
    {
        private ViewModel viewModel;
        public MUDView()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
        }
    }
}
