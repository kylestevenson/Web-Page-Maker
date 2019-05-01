using System;
using System.Collections.Generic;
using System.IO;
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

namespace KyleStevensonFinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String currentFP = "";
        int sectionCount = 0;
        List<TextBox> headingsList = new List<TextBox>();
        List<TextBox> subHeadingsList = new List<TextBox>();
        List<TextBox> contentsList = new List<TextBox>();
        List<ComboBox> sectionHeroList = new List<ComboBox>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreatePage_Click(object sender, RoutedEventArgs e)
        {
            string bgColor = backgroundColorSelect.Text; ;
            //get background color: selected value from drop down or user input - User input is used, unless blank
            if(backgroundColorText_user.Text != "")
            {
                //user input has value
                bgColor = backgroundColorText_user.Text;
            }
            //create page and section objects with user input
            WebPage webPage = new WebPage(titleText.Text, subTitleText.Text, titleColor.Text, titleSize.Text, bgColor, fontFamilySelect.Text, fontSizeSelect.Text);
            for (int i=0; i < sectionCount; i++)
            {
                Section section = new Section(headingsList[i].Text, subHeadingsList[i].Text, contentsList[i].Text, sectionHeroList[i].Text);
                webPage.AddSection(section);
            }
            
            //create html page
            webPage.CreatePage();
            //save page to user device
            SaveFile(webPage.Page);
        }
        private void SaveFile(string page)
        {
            //open save dialog window
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            if(currentFP != "")
            {
                saveFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(currentFP);
            }
            //set extension to html
            saveFileDialog.DefaultExt = ".html";
            saveFileDialog.Filter = "HTML|*.html";
            //save file on OK
            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                var fileStream = new FileStream(filePath, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
                streamWriter.Write(page);

                streamWriter.Close();
                fileStream.Close();

                currentFP = filePath;
            }
        }

        private void NewPage_Click(object sender, RoutedEventArgs e)
        {
            //clear all text fields and reset select boxes to index 0
            titleText.Text = "";
            subTitleText.Text = "";
            backgroundColorText_user.Text = "";
            titleColor.SelectedIndex = 0;
            titleSize.SelectedIndex = 0;
            backgroundColorSelect.SelectedIndex = 0;
            fontFamilySelect.SelectedIndex = 0;
            fontSizeSelect.SelectedIndex = 0;
            //clear all section content
            for (int i = 0; i < sectionCount; i++)
            {
                headingsList[i].Text = "";
                contentsList[i].Text = "";
                sectionHeroList[i].SelectedIndex = 0;
            }

        }
        //Exit the program, closes the window
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //About menu message box
        private void About_Click(object sender, RoutedEventArgs e)
        {
            string aboutTitle = "About WebPageMaker";
            string aboutText = "WebPageMaker was developed by Kyle Stevenson as tool to easily create html pages.\n\n"+
                "This tool allows anyone to create a well formatted and mobile responsive html page without having any programming knowledge.  "+
                "It can also be used as a starting point or template for those who wish to add more features, style, or scripting code.\n\n"+
                "After filling out the form, select File > Create Webpage to create and save your new html page.  "+
                "You can then open the html file to view it in your web browser.  If you wish to add your own "+
                "code, simply open the file with your favorite code editor.  The file will be nicely formatted and commented to assist you."+
                "\n\nThis tool uses the Bulma CSS framework, a link to the Bulma documentation is provided within each created webpage.";
            System.Windows.MessageBox.Show(aboutText, aboutTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //Add section button click
        private void AddSection_Click(object sender,RoutedEventArgs e)
        {

            //Section Number label
            Label sectionLabel = new Label
            {
                Content = "Section " + (sectionCount + 1).ToString(),
                VerticalContentAlignment = VerticalAlignment.Center,
                FontSize = 16,
                UseLayoutRounding = false,
                Padding = new Thickness(50, 5, 5, 5),
                FontWeight = FontWeights.Medium
            };
            //Section Banner color - none selected for no banner
            Label sectionColorLabel = new Label
            {
                Content = "Optional Banner Color:",
                HorizontalContentAlignment = HorizontalAlignment.Left,
                VerticalContentAlignment = VerticalAlignment.Center,
                Margin = new Thickness (40,0,0,0)
            };
            ComboBox cbox = new ComboBox
            {
                MaxWidth = 120,
                MaxHeight = 35,
                VerticalContentAlignment = VerticalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Right,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                Width = 100,
                Padding = new Thickness(10),
                Margin = new Thickness(0,10,0,10)
            };
            //Section banner color combobox items:
            ComboBoxItem item0 = new ComboBoxItem
            {
                Content = "None",
                IsSelected = true
            };
            cbox.Items.Add(item0);
            ComboBoxItem item1 = new ComboBoxItem
            {
                Content = "Default",
                Background = new SolidColorBrush(Color.FromRgb(0,209,178))
            };
            cbox.Items.Add(item1);
            ComboBoxItem item2 = new ComboBoxItem
            {
                Content = "Blue",
                Background = new SolidColorBrush(Color.FromRgb(32, 156, 238))
            };
            cbox.Items.Add(item2);
            ComboBoxItem item3 = new ComboBoxItem
            {
                Content = "Green",
                Background = new SolidColorBrush(Color.FromRgb(35, 209, 96))
            };
            cbox.Items.Add(item3);
            ComboBoxItem item4 = new ComboBoxItem
            {
                Content = "Yellow",
                Background = new SolidColorBrush(Color.FromRgb(255, 221, 87))
            };
            cbox.Items.Add(item4);
            ComboBoxItem item5 = new ComboBoxItem
            {
                Content = "Red",
                Background = new SolidColorBrush(Color.FromRgb(255, 56, 96))
            };
            cbox.Items.Add(item5);
            ComboBoxItem item6 = new ComboBoxItem
            {
                Content = "Light",
                Background = new SolidColorBrush(Color.FromRgb(245, 245, 245))
            };
            cbox.Items.Add(item6);
            ComboBoxItem item7 = new ComboBoxItem
            {
                Content = "Dark",
                Background = new SolidColorBrush(Color.FromRgb(54, 54, 54)),
                Foreground = new SolidColorBrush(Color.FromRgb(245, 245, 245))
            };
            cbox.Items.Add(item7);
            //Section Title
            Label headingLabel = new Label
            {
                Content = "Section Heading:",
                HorizontalContentAlignment = HorizontalAlignment.Right,
                Padding = new Thickness(5, 5, 20, 5),
                FontSize = 14
            };
            TextBox headingText = new TextBox
            {
                Margin = new Thickness(0, 0, 50, 20),
                MinHeight = 30,
                VerticalContentAlignment = VerticalAlignment.Center
            };
            //Section SubTitle
            Label subHeadingLabel = new Label
            {
                Content = "Sub Heading:",
                HorizontalContentAlignment = HorizontalAlignment.Right,
                Padding = new Thickness(5, 5, 20, 5),
                FontSize = 14
            };
            TextBox subHeadingText = new TextBox
            {
                Margin = new Thickness(0, 0, 50, 20),
                MinHeight = 30,
                VerticalContentAlignment = VerticalAlignment.Center
            };
            //Section content
            Label contentLabel = new Label
            {
                Content = "Section Heading:",
                HorizontalContentAlignment = HorizontalAlignment.Right,
                Padding = new Thickness(5, 5, 20, 5),
                FontSize = 14
            };
            contentLabel.Content = "Section Content:";
            TextBox contentText = new TextBox
            {
                TextWrapping = TextWrapping.Wrap,
                AcceptsTab = true,
                AcceptsReturn = true,
                MinHeight = 60,
                Margin = new Thickness(0, 0, 50, 0)
            };
            //add new rows
            Grid1.RowDefinitions.Add(new RowDefinition());
            Grid1.RowDefinitions.Add(new RowDefinition());
            Grid1.RowDefinitions.Add(new RowDefinition());
            Grid1.RowDefinitions.Add(new RowDefinition());

            //add new controls to grid
            Grid1.Children.Add(sectionLabel);
            Grid1.Children.Add(sectionColorLabel);
            Grid1.Children.Add(cbox);
            Grid1.Children.Add(headingLabel);
            Grid1.Children.Add(headingText);
            Grid1.Children.Add(subHeadingLabel);
            Grid1.Children.Add(subHeadingText);
            Grid1.Children.Add(contentLabel);
            Grid1.Children.Add(contentText);

            //move addSectionBtn to last row
            Grid.SetColumn(addSectionBtn, 0);
            Grid.SetRow(addSectionBtn, Grid1.RowDefinitions.Count - 1);
            //put new section controls into grid at correct position
            Grid.SetRow(sectionLabel, Grid1.RowDefinitions.Count - 5);
            Grid.SetColumn(sectionLabel, 0);
            Grid.SetRow(sectionColorLabel, Grid1.RowDefinitions.Count - 5);
            Grid.SetColumn(sectionColorLabel, 1);
            Grid.SetRow(cbox, Grid1.RowDefinitions.Count -5);
            Grid.SetColumn(cbox, 1);
            Grid.SetRow(headingLabel, Grid1.RowDefinitions.Count - 4);
            Grid.SetColumn(headingLabel, 0);
            Grid.SetRow(headingText, Grid1.RowDefinitions.Count - 4);
            Grid.SetColumn(headingText, 1);
            Grid.SetColumnSpan(headingText, 2);

            Grid.SetRow(subHeadingLabel, Grid1.RowDefinitions.Count - 3);
            Grid.SetColumn(subHeadingLabel, 0);
            Grid.SetRow(subHeadingText, Grid1.RowDefinitions.Count - 3);
            Grid.SetColumn(subHeadingText, 1);
            Grid.SetColumnSpan(subHeadingText, 2);

            Grid.SetRow(contentLabel, Grid1.RowDefinitions.Count - 2);
            Grid.SetColumn(contentLabel, 0);
            Grid.SetRow(contentText, Grid1.RowDefinitions.Count - 2);
            Grid.SetColumn(contentText, 1);
            Grid.SetColumnSpan(contentText, 2);

            //add inputs to Lists to be used later for section creation
            headingsList.Add(headingText);
            subHeadingsList.Add(subHeadingText);
            contentsList.Add(contentText);
            sectionHeroList.Add(cbox);

            //increase section count - used to modidy section number label (Section 'x')
            sectionCount++;
        }
        //Help message text for user input background color
        private void BgHelpBtn_Click(object sender, RoutedEventArgs e)
        {
            string aboutTitle = "Background-Color Help";
            string aboutText = "Fill out this field if you do not wish to use one of the provided 'popular' colors, otherwise you may leave it blank."+
                "\n\nYou may enter your desired color in any CSS acceptable format.  Example inputs:\n"+
                "\tLightCoral \n"+
                "\t#ffffff \n"+
                "\trgb(51,113,65) \n"+
                "\trgba(137, 44, 136, 0.5)";

            System.Windows.MessageBox.Show(aboutText, aboutTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }   
}
