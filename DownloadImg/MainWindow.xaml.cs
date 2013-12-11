using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DownloadImg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {

        public int counter = 0; 
        
        public MainWindow()
        {
            InitializeComponent();
        }
    

public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
{
    System.Drawing.Image image = null;
 
    try
    {
        System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
        webRequest.AllowWriteStreamBuffering = true;
        webRequest.Timeout = 30000;
 
        System.Net.WebResponse webResponse = webRequest.GetResponse();
 
        System.IO.Stream stream = webResponse.GetResponseStream();
 
        image = System.Drawing.Image.FromStream(stream);
 
        webResponse.Close();
    }
    catch (Exception ex)
    {
        return null;
    }
 
    return image;

}

private void Button_Click(object sender, RoutedEventArgs e)
{

    string baseURL = "http://www.gb01.de/bilder/";
    WebClient client = new WebClient();
    string content = client.DownloadString(baseURL);
   
    
    //foreach (var img in listFileInfo)
    //{
    //    System.Drawing.Image image = DownloadImageFromUrl(img.FullName);
    //    counter++;
    //    string rootPath = @"C:\temp";

        
    //    string fileName = System.IO.Path.Combine(rootPath, "AKtest" + counter.ToString() + " .jpg");
    //    image.Save(fileName);
    //}

   


    // System.Drawing.Image image = DownloadImageFromUrl(txtUrl.Text.Trim());
   // counter++;
   //string rootPath = @"C:\temp";
  
   //string fileName = System.IO.Path.Combine(rootPath, "Mia Bitch & Mini Hotcore" + counter.ToString() +" .jpg");
   //image.Save(fileName);



    //DirectoryInfo di = new DirectoryInfo(txtUrl.Text.Trim());
    //List<FileInfo> listFileInfo = new List<FileInfo>();

    //if (di.Exists == true)
    //{
    //    FileInfo[] rgFiles = di.GetFiles("*.jpg");
    //    listFileInfo = new List<FileInfo>(rgFiles);
    //}

    //foreach (var img in listFileInfo)
    //{
    //    System.Drawing.Image image = DownloadImageFromUrl(img.FullName);
    //    counter++;
    //    string rootPath = @"C:\temp";


    //    string fileName = System.IO.Path.Combine(rootPath, "AKtest" + counter.ToString() + " .jpg");
    //    image.Save(fileName);
    //}


}








}
}
