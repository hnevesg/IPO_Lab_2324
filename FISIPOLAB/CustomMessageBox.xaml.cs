using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace FISIPOLAB_
{
	/// <summary>
	/// Lógica de interacción para CustomMessageBox.xaml
	/// </summary>
	public partial class CustomMessageBox : Window
	{
		private BitmapImage imgQuestion = new BitmapImage(new Uri("/img/messagebox-question.png", UriKind.Relative));

		public CustomMessageBox(string message, string title)
		{
			InitializeComponent();
			MessageTextBlock.Text = message;
			Title = title;
			ImgQuestion.Source = imgQuestion;
		}

		private void NoButton_Click(object sender, RoutedEventArgs e)
		{
			// Handle "No" button click
			DialogResult = false;
			Close();
		}

		private void YesButton_Click(object sender, RoutedEventArgs e)
		{
			// Handle "Yes" button click
			DialogResult = true;
			Close();
		}
	}
}
