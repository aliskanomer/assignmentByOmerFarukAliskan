/*
DESIGNED,CREATED AND DEVELOPED BY ÖMER FARUK ALIŞKAN
    AS AN ASSIGNMENT GIVEN BY MOREUM A.Ş.

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace moreumAssignmentByOmerFarukAliskan
{
    public partial class assignmentByOmerFarukAliskan : Form
    {
        //Global Data&Method Declaration
        string template = File.ReadAllText("Template.txt");
        string[] csvLineData;
        string csvFilePath;
        Boolean csvFileStatus = false;
        List<users> userList = new List<users>();

        public assignmentByOmerFarukAliskan()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            getCsvFile();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Creating directory
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // *1
                string resultsFilePath = System.IO.Path.Combine(desktopPath, "Result");

                if (System.IO.Directory.Exists(resultsFilePath))
                {
                    //add files to the existing directory
                    createUsers();
                    createFiles(resultsFilePath);
                }
                else
                {
                    //create file and add new files
                    System.IO.Directory.CreateDirectory(resultsFilePath);
                    createUsers();
                    createFiles(resultsFilePath);
                }
            }
            catch (Exception Err)
            {
                headerTxt.Text = "Ups!";
                msgTxt.Text = "It seems there is something wrong with your CSV file.It should contain four columns and each data should be seperated with semicolon. Please make sure of that and try again!";
                Console.WriteLine(Err);
            }
        }
       
        public void createUsers()
        {
            if(csvLineData.Length == 0)
            {
                headerTxt.Text = "Hey.";
                msgTxt.Text = "We detected that your CSV file has no data in it. So all we can do is show you this screen. Maybe you should try a different file or fix the existing one.Either way,click the Upload CSV button again to start a new process.";
            }
            else
            {
                for (int i = 0; i < csvLineData.Length; i++)
                {
                    users user = new users(csvLineData[i]);
                    userList.Add(user);
                }
            }

        }
       
        public void createFiles(string folderPath)
        {
            int count = 0;

            for (int i = 0; i < csvLineData.Length; i++)
            {
                try
                {
                    //Create template text for every user
                    string text = template;
                    text = text.Replace("{AD}", userList[i].getName());
                    text = text.Replace("{SOYAD}", userList[i].getSurname());
                    text = text.Replace("{FATURANO}", userList[i].getID());
                    text = text.Replace("{TUTAR}", userList[i].getBill());
                    text = text.Replace("{TARIH}", DateTime.Today.ToString("dd/MM/yyyy"));

                    //Create&Write txt file for every user
                    string filePath = System.IO.Path.Combine(folderPath, $"{userList[i].getID()}.txt");
                    System.IO.File.WriteAllText(filePath, text);
                    count++;

                    //UI Messages
                    headerTxt.Text = "Done!";
                    msgTxt.Text = $"Created {count} files.You can access your files in 'Results' folder at your Desktop.\n\nThanks for choosing Moreum A.Ş.";
                }
                catch (Exception Err)
                {
                    //UI Messages
                    headerTxt.Text = "Ups!";
                    msgTxt.Text = "Something went wrong!Please check the following:\n\tIf there is an 'Results' folder in your Desktop,delete it and all of it's content and reboot the app!\n\tYour CSV file must have columns and each data should be seperated with semicolon.Please make sure you have the right format in your CSV file and reboot the app.";
                    msgTxt.TextAlign = ContentAlignment.TopLeft;
                    Console.WriteLine(Err);
                }
            }
        }
        
        public void getCsvFile()
        {
            try
            {
                //CSV File Uploading from harddisk
                OpenFileDialog csvFile = new OpenFileDialog
                {
                    Filter = "CSV Dosyası |*.csv",
                    CheckFileExists = true,
                    Multiselect = false
                };
                //Error Handling: Uploading CSV Issues
                if (csvFile.ShowDialog() == DialogResult.OK)
                {
                    //Extracting CSV File Data as Array of str
                    csvFilePath = csvFile.FileName;

                    csvLineData = System.IO.File.ReadAllLines(csvFilePath);
                    csvFileStatus = true;
                    runBtn.Enabled = true;
                    //UI Succcess Messages
                    headerTxt.Text = "Ready!";
                    msgTxt.Text = "File uploaded succesfully. Press run to start!";
                }
            }
            catch (Exception Err)
            {
                //UI Error Messages
                headerTxt.Text = "Ups!";
                msgTxt.Text = "Something went wrong while uploading the file.\nPlease try again!";
                Console.WriteLine(Err);
            }
        }
    }
}

//KAYNAKLAR
// *1 : Kullanıcının masaüstü adresine erişmek için kullandığım kaynak: https://stackoverflow.com/questions/634142/how-to-get-a-path-to-the-desktop-for-current-user-in-c/634145
