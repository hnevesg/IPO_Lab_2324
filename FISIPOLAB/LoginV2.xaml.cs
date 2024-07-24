using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace FISIPOLAB_
{
	/// <summary>
	/// Lógica de interacción para LoginV2.xaml
	/// </summary>
	public partial class LoginV2 : Window
	{
		private BitmapImage imgCheck = new BitmapImage(new Uri("/img/login/tic.png", UriKind.Relative));
		private BitmapImage imgCross = new BitmapImage(new Uri("/img/login/cross.png", UriKind.Relative));


		public LoginV2()
		{
			InitializeComponent();
			txtUsuario2.Focus();
		}

		private void btnLogin2_Click(object sender, RoutedEventArgs e)
		{
			if (ComprobarUsuario())
			{
				if (ComprobarPassword())
				{
					Window main = new MainWindow(txtUsuario2.Text, passContrasena2.Password);
					Hide();
					main.Show();
					Close();
				}
				else{
					MessageBox.Show("Contraseña incorrecta", "Contraseña", MessageBoxButton.OK, MessageBoxImage.Information);
					passContrasena2.Clear();
					passContrasena2.Focus();
				}
			}
			else
			{
				txtUsuario2.BorderBrush = Brushes.Red;
				txtUsuario2.Background = Brushes.LightCoral;
				imgCheck_usuario.Visibility = Visibility.Visible;
				imgCheck_usuario.Source = imgCross;
				MessageBox.Show("Usuario incorrecto", "Usuario", MessageBoxButton.OK, MessageBoxImage.Information);
				txtUsuario2.Focus();
			}
		}

		private bool ComprobarUsuario()
		{
			bool valido = false;
			txtUsuario2.BorderThickness = new Thickness(2);
			XmlDocument doc = new XmlDocument();
			var fichero = Application.GetResourceStream(new Uri("Usuarios.xml", UriKind.Relative));
			doc.Load(fichero.Stream);

			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{

				if (txtUsuario2.Text.Equals(node.Attributes["NombreUsuario"].Value))
				{
					// marcar borde en verde
					txtUsuario2.BorderBrush = Brushes.Green;
					txtUsuario2.Background = Brushes.LightGreen;
					imgCheck_usuario.Visibility = Visibility.Visible;
					imgCheck_usuario.Source = imgCheck;
					valido = true;
					break;
				}
			}

				if (valido == false)
				{
					
						// marcar borde en rojo
						txtUsuario2.BorderBrush = Brushes.Red;
						txtUsuario2.Background = Brushes.LightCoral;
						imgCheck_usuario.Visibility = Visibility.Visible;
						imgCheck_usuario.Source = imgCross;
				}
			return valido;
		}

		private bool ComprobarPassword()
		{
			bool valido = false;
			passContrasena2.BorderThickness = new Thickness(2);
			XmlDocument doc = new XmlDocument();
			var fichero = Application.GetResourceStream(new Uri("Usuarios.xml", UriKind.Relative));
			doc.Load(fichero.Stream);

			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{

				if (passContrasena2.Password.Equals(node.Attributes[8].Value))
				{
					// marcar borde en verde
					if (txtUsuario2.Text.Equals(node.Attributes["NombreUsuario"].Value))
					{
						passContrasena2.BorderBrush = Brushes.Green;
						passContrasena2.Background = Brushes.LightGreen;
						imgCheck_contraseña2.Visibility = Visibility.Visible;
						imgCheck_contraseña2.Source = imgCheck;
						valido = true;
						break;
					}
				}
			}

			if (valido == false)
			{
				passContrasena2.BorderBrush = Brushes.Red;
				passContrasena2.Background = Brushes.LightCoral;
				imgCheck_contraseña2.Visibility = Visibility.Visible;
				imgCheck_contraseña2.Source = imgCross;
			}

			return valido;
		}

		private void txtUsuario2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter || e.Key == Key.Tab)
			{
				passContrasena2.Focus();
			}
		}

		private void passContrasena2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter || e.Key == Key.Tab)
			{
				ComprobarUsuario();
				ComprobarPassword();
			}
		}

        private void lblRecordarContrasena2_MouseEnter(object sender, MouseEventArgs e)
        {
			lblRecordarContrasena2.FontWeight = FontWeights.UltraBold;
        }

        private void lblRecordarContrasena2_MouseLeave(object sender, MouseEventArgs e)
        {
            lblRecordarContrasena2.FontWeight = FontWeights.Bold;
        }
    }
}
