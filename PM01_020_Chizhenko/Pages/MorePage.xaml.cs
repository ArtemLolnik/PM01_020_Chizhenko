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

namespace PM01_020_Chizhenko.Pages
{
    /// <summary>
    /// Логика взаимодействия для MorePage.xaml
    /// </summary>
    public partial class MorePage : Page
    {
        public MorePage()
        {
            InitializeComponent();
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string imagePath = @"Source\Repos\PM01_020_Chizhenko\PM01_020_Chizhenko\Resourses\celebrations\1.jpeg"; // путь к вашему изображению в папке Resources
            string imageFullPath = System.IO.Path.Combine(userProfilePath, imagePath);

            YourImageControl.Source = new BitmapImage(new Uri(imageFullPath));
        }
    }
}
