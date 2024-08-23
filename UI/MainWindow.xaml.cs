using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using FolderBrowserDialog = System.Windows.Forms.FolderBrowserDialog;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using UI.Properties;
using MessageBox = System.Windows.MessageBox;
using BLL;
using ComboBox = System.Windows.Forms.ComboBox;
using Path = System.IO.Path;


namespace UI
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //if (Debugger.IsAttached)
            //{
            //    Settings.Default.Reset();


            RenderPath();

            RenderLocation();

            Tip();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Description of the dialog box (Over treeview)
            fbd.Description = "Seleccione Carpeta";
            //Show/Hide "New Folder" button
            fbd.ShowNewFolderButton = false;
            //The root folder to display
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult result = fbd.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            //if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                String path = fbd.SelectedPath;

                //cmbPath.Items.Add(path);
                txtPath.Text = path;

                Persistence().Month = txtPath.Text;

                Persistence().Save();

                Tip();


            }

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

            //The whole path of the folder
            String monthPath = txtPath.Text;
            //The folder itself
            var folderPath = new DirectoryInfo(monthPath).Name;

            if (!Enum.IsDefined(typeof(Month), folderPath))
            {
                MessageBox.Show("Carpeta de destino incorrecta!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                #region DailyForm.DateTime
                String currentDate = DateTime.Now.ToString("ddd-dd-MMM_yyyy");

                DailyForm dailyForm = new DailyForm();

                dailyForm.DateTime = currentDate;
                #endregion

                #region Current Time
                //Day of Week for the current language
                //String dayOfWeek = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
                DayOfWeek day = DateTime.Now.DayOfWeek;

                #endregion

                #region File Creation
                String newLocation = Path.GetFullPath(monthPath + @"\" + Persistence().Location + "_" + dailyForm.DateTime + ".xlsx");

                //MessageBox.Show(newLocation);

                if (File.Exists(newLocation))
                {
                    MessageBox.Show("Planilla diaria ya existe!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    //File.WriteAllBytes(newLocation, Resource.Week);
                    File.Copy(@"..\..\..\DAL\Daily Forms\Template.xlsx", newLocation);

                    MessageBox.Show("Planilla diaria " + Persistence().Location + "_" + dailyForm.DateTime + ".xlsx" + " creada con éxito!", "Éxito", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                #endregion
            }

        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"..\..\..\DAL\Daily Forms\Template.xlsx");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private Settings Persistence()
        {
            return Settings.Default;
        }

        private void RenderPath()
        {
            if (Persistence().Month != null)
            {
                txtPath.Text = Persistence().Month;
            }
        }

        private void RenderLocation()
        {
            if (Persistence().Location != null)
            {
                if (Persistence().Location == "MCC")
                {
                    cmbLocation.SelectedIndex = 0;

                }
                else if (Persistence().Location == "PÑ")
                {
                    cmbLocation.SelectedIndex = 1;
                }
                else if (Persistence().Location == "ELL")
                {
                    cmbLocation.SelectedIndex = 2;
                }
            }
        }

        private void Tip()
        {
            txtPath.ToolTip = txtPath.Text;
        }

        private void cmbLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String location = ((ComboBoxItem)cmbLocation.SelectedItem).Content as String;
            //String location = cmbLocation.SelectedItem.ToString();

            Persistence().Location = location;
            Persistence().Save();
        }
    }
}
