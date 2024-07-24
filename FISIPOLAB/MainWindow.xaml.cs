using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
using System.Xml;
using System.Xml.Linq;

namespace FISIPOLAB_
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Button lastClickedButton;
		private MainConfiguration configuracion_actual = new MainConfiguration();

        public MainWindow(string user, string passw)
		{
			InitializeComponent();
			WireUpButtonClickEvents();
			Usuario usuario_actual = CargarContenidoUsuarioXML(user);
			string fullname = usuario_actual.Nombre + " " + usuario_actual.Apellidos;

            // Etiquetas de la Main Window
            lblBienvenida.Content += $"¡Bienvenido, {fullname}!";
			lblNombreUsuario.Content += usuario_actual.Nombre;
			lblApellidosUsuario.Content += usuario_actual.Apellidos;
			lblDNIUsuario.Content += usuario_actual.DNI;
			lblFechaNacimientoUsuario.Content += usuario_actual.FechaNacimiento;
			lblDireccionUsuario.Content += usuario_actual.Direccion;
			lblEmailUsuario.Content += usuario_actual.Email;
			lblFechaUltimoAcceso.Content += "\n" + usuario_actual.UltimoAcceso;

			setGrids(Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
			CargarContenidoPacientesXML();
			CargarContenidoProfesionalesXML();
		}

		private void WireUpButtonClickEvents()
		{
			foreach (UIElement element in stackPanelMainSelection.Children)
			{
				if (element is Button button)
				{
					button.Click += Button_Click;
				}
			}
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Binding b = new Binding();
            if (lastClickedButton != null)
			{
				b = new Binding("ColorBotonNoPresionado");
				lastClickedButton.SetBinding(Button.BackgroundProperty, b);
                lastClickedButton.BorderThickness = new Thickness(0, 0, 0, 0);
			}

			Button clickedButton = (Button)sender;
            b = new Binding("ColorBotonPresionado");
            clickedButton.SetBinding(Button.BackgroundProperty, b);
            clickedButton.BorderThickness = new Thickness(2, 2, 2, 2);
			lastClickedButton = clickedButton;
		}

		private Usuario CargarContenidoUsuarioXML(string user)
		{
			List<Usuario> listadoUsuarios = new List<Usuario>();
			XmlDocument doc = new XmlDocument();
			var fichero = Application.GetResourceStream(new Uri("Usuarios.xml", UriKind.Relative));
			Usuario nuevoUsuario = new Usuario("", "", "", "", "", "", "", "", "", "");
			doc.Load(fichero.Stream);


			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{

				if (node.Attributes["NombreUsuario"].Value.Equals(user))
				{

					nuevoUsuario.Nombre = node.Attributes["Nombre"].Value;
					nuevoUsuario.Apellidos = node.Attributes["Apellidos"].Value;
					nuevoUsuario.DNI = node.Attributes["DNI"].Value;
					nuevoUsuario.FechaNacimiento = node.Attributes["FechaNacimiento"].Value;
					nuevoUsuario.Direccion = node.Attributes["Direccion"].Value;
					nuevoUsuario.Telefono = node.Attributes["Telefono"].Value;
					nuevoUsuario.Email = node.Attributes["Email"].Value;
					nuevoUsuario.NombreUsuario = node.Attributes["NombreUsuario"].Value;
					nuevoUsuario.UltimoAcceso = node.Attributes["FechaUltimoAcceso"].Value;
					listadoUsuarios.Add(nuevoUsuario);
					break;
				}
			}
			return nuevoUsuario;
		}

		private void CargarContenidoPacientesXML()
		{
			XmlDocument doc = new XmlDocument();
			//var fichero = Application.GetResourceStream(new Uri("Pacientes.xml", UriKind.Relative));
			doc.Load("../../Pacientes.xml");


			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{
				var nuevoPaciente = new Paciente("", "", "", "", "", "", "", "", false, false);

				nuevoPaciente.Nombre = node.Attributes["Nombre"].Value;
				nuevoPaciente.Apellidos = node.Attributes["Apellidos"].Value;
				nuevoPaciente.DNI = node.Attributes["DNI"].Value;
				nuevoPaciente.FechaNacimiento = node.Attributes["FechaNacimiento"].Value;
				nuevoPaciente.Email = node.Attributes["Email"].Value;
				nuevoPaciente.Direccion = node.Attributes["Direccion"].Value;
				nuevoPaciente.Telefono = node.Attributes["Telefono"].Value;
				nuevoPaciente.Sexo = node.Attributes["Sexo"].Value;
				nuevoPaciente.Fumador = Convert.ToBoolean(node.Attributes["Fumador"].Value);
				nuevoPaciente.Cirugia = Convert.ToBoolean(node.Attributes["Cirugia"].Value);

				dgInfoPacientes.Items.Add(nuevoPaciente);
			}
		}

		private void CargarContenidoProfesionalesXML()
		{
			XmlDocument doc = new XmlDocument();
			//var fichero = Application.GetResourceStream(new Uri("Profesionales.xml", UriKind.Relative));
			doc.Load("../../Profesionales.xml");


			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{
				if (node.Attributes["Tipo"].Value == "Sanitario")
				{
					var nuevoProfesional = new Prof_Sanitario("", "", "", "", "", "", "", "", TipoProfesional.Sanitario, ""); ;

					nuevoProfesional.Nombre = node.Attributes["Nombre"].Value;
					nuevoProfesional.Apellidos = node.Attributes["Apellidos"].Value;
					nuevoProfesional.DNI = node.Attributes["DNI"].Value;
					nuevoProfesional.FechaNacimiento = node.Attributes["FechaNacimiento"].Value;
					nuevoProfesional.Email = node.Attributes["Email"].Value;
					nuevoProfesional.Direccion = node.Attributes["Direccion"].Value;
					nuevoProfesional.Sexo = node.Attributes["Sexo"].Value;
					nuevoProfesional.Telefono = node.Attributes["Telefono"].Value;
					nuevoProfesional.Tipo = (TipoProfesional)Enum.Parse(typeof(TipoProfesional), node.Attributes["Tipo"].Value);
					nuevoProfesional.historial = node.Attributes["Historial"].Value;

					dgInfoProfesionales.Items.Add(nuevoProfesional);
				}
				else
				{
					var nuevoProfesional = new Prof_Limpieza("", "", "", "", "", "", "", "", TipoProfesional.Sanitario, "");

					nuevoProfesional.Nombre = node.Attributes["Nombre"].Value;
					nuevoProfesional.Apellidos = node.Attributes["Apellidos"].Value;
					nuevoProfesional.DNI = node.Attributes["DNI"].Value;
					nuevoProfesional.FechaNacimiento = node.Attributes["FechaNacimiento"].Value;
					nuevoProfesional.Email = node.Attributes["Email"].Value;
					nuevoProfesional.Direccion = node.Attributes["Direccion"].Value;
					nuevoProfesional.Telefono = node.Attributes["Telefono"].Value;
					nuevoProfesional.Sexo = node.Attributes["Sexo"].Value;
					nuevoProfesional.Tipo = (TipoProfesional)Enum.Parse(typeof(TipoProfesional), node.Attributes["Tipo"].Value);
					nuevoProfesional.horario = node.Attributes["Horario"].Value;

					dgInfoProfesionales.Items.Add(nuevoProfesional);
				}
			}
		}

		private Informe_Paciente EncontrarInforme(string fecha, string paciente, string dolencia, string pruebas)
		{
			XmlDocument doc = new XmlDocument();
			var fichero = Application.GetResourceStream(new Uri("Informes.xml", UriKind.Relative));
			doc.Load(fichero.Stream);

			foreach (XmlNode node in doc.DocumentElement.ChildNodes)
			{
                if (node.Attributes["fecha"].Value.Equals(fecha) && node.Attributes["paciente_informe"].Value.Equals(paciente) && node.Attributes["dolencia"].Value.Equals(dolencia) && node.Attributes["pruebas"].Value.Equals(pruebas))
				{
                    var nuevoInforme = new Informe_Paciente("", "", "", "","","");
                    nuevoInforme.fecha_informe = node.Attributes["fecha"].Value;
                    nuevoInforme.paciente_informe = node.Attributes["paciente_informe"].Value;
                    nuevoInforme.dolencia = node.Attributes["dolencia"].Value;
					nuevoInforme.tratamiento = node.Attributes["tratamiento"].Value;
                    nuevoInforme.pruebas = node.Attributes["pruebas"].Value;
					nuevoInforme.conclusiones = node.Attributes["conclusiones"].Value;
                    return nuevoInforme;
                }
            }
			return null;
		}
		private void BtnClickPlanif(object sender, RoutedEventArgs e)
		{
			lblBienvenida.Visibility = Visibility.Hidden;
			lblNavegar.Visibility = Visibility.Hidden;
		}

		private void BtnClickPacientes(object sender, RoutedEventArgs e)
		{
			lblBienvenida.Visibility = Visibility.Visible;
			lblNavegar.Visibility = Visibility.Visible;
		}

		private void btnCalendario_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnNuevaCita_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void BtnNuevaCitaMenu_Click(object sender, RoutedEventArgs e)
		{
			btnNuevaCita_Click(sender, e);
		}

		private void btnListaPac_Click(object sender, RoutedEventArgs e)
		{
			dgInfoPacientes.Items.Clear();
			CargarContenidoPacientesXML();
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnNuevoPac_Click(object sender, RoutedEventArgs e)
		{
			txtNombre.Focus();
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnListaProf_Click(object sender, RoutedEventArgs e)
		{
			dgInfoProfesionales.Items.Clear();
			CargarContenidoProfesionalesXML();
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnNuevoProf_Click(object sender, RoutedEventArgs e)
		{
			txtNombrePr.Focus();
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnAjustes_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden, Visibility.Hidden);
		}

		private void btnAyuda_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible, Visibility.Hidden);
		}

		private void btnCreditos_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Visible);
		}

		private void setGrids(Visibility grid1, Visibility grid2, Visibility grid3, Visibility grid4, Visibility grid5, Visibility grid6, Visibility grid7, Visibility grid8, Visibility grid9, Visibility grid10)
		{
			gridMainMenu.Visibility = grid1;
			gridPlanificacionCalendario.Visibility = grid2;
			gridPlanificacionNuevaCita.Visibility = grid3;
			gridPacientesLista.Visibility = grid4;
			gridPacientesAgregar.Visibility = grid5;
			gridProfesionalesLista.Visibility = grid6;
			gridProfesionalesAgregar.Visibility = grid7;
			gridMasAjustes.Visibility = grid8;
			gridMasAyuda.Visibility = grid9;
			gridMasCreditos.Visibility = grid10;
		}

		private void Home_Click(object sender, RoutedEventArgs e)
		{
			setGrids(Visibility.Visible, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden, Visibility.Hidden);
		}

		private void btncerrar_sesion_Click(object sender, RoutedEventArgs e)
		{
			CustomMessageBox messageBox = new CustomMessageBox("¿Está seguro de que \ndesea cerrar sesión?", "Cerrar Sesión");
			messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			bool? result = messageBox.ShowDialog();
			if (result == true)
			{
				Window login = new LoginV2();
				login.Show();
				Close();
			}
		}

		private void btnsalir_Click(object sender, RoutedEventArgs e)
		{
			CustomMessageBox messageBox = new CustomMessageBox("¿Está seguro de que desea salir?", "Salir de FISIPOLAB");
			messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			bool? result = messageBox.ShowDialog();
			if (result == true)
			{
				Application.Current.Shutdown();
			}
		}

		private void dgInfoPacientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			TabItem ti = TabControlPac.SelectedItem as TabItem;
			if (dgInfoPacientes.SelectedItem != null && ti.Header.Equals("Datos Personales"))
			{
				Paciente pac = dgInfoPacientes.SelectedItem as Paciente;

                MainConfiguration nuevaConfig = new MainConfiguration(configuracion_actual.urlFondo, configuracion_actual.ColorPanel, configuracion_actual.ColorBotonNoPresionado, configuracion_actual.ColorBotonPresionado, configuracion_actual.ColorLetra, configuracion_actual.TamanioLetra);
				nuevaConfig.PacienteSeleccionado= pac;
                gridMain.DataContext = nuevaConfig;

				checkCirugiaPreviaInd.IsChecked = pac.Cirugia;
				checkFumadorInd.IsChecked = pac.Fumador;
			}else if (dgInfoPacientes.SelectedItem != null && ti.Header.Equals("Historial de citas"))
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("../../Citas.xml");

				Paciente pac = dgInfoPacientes.SelectedItem as Paciente; 
				dgrHistorialPac.Items.Clear();
				int counter = 0;

				foreach (XmlNode cita in xmlDoc.DocumentElement.ChildNodes)
				{

					if (cita.Attributes["paciente"].Value.Equals(pac.Email))
					{
						Profesional p = IsValidProfSanitario(cita.Attributes["sanitario"].Value);

						var row = new
						{
							fecha = cita.Attributes["fecha_cita"].Value,
							hora = cita.Attributes["hora_cita"].Value,
							sanitario = p.Nombre + " " + p.Apellidos,
							estado = cita.Attributes["estado"].Value
						};
						dgrHistorialPac.Visibility = Visibility.Visible;
						LeyendaPacs.Visibility = Visibility.Visible;
						dgrHistorialPac.Items.Add(row);
						counter++;
					}
				}
				if (counter == 0)
				{
					dgrHistorialPac.Visibility = Visibility.Hidden;
					LeyendaPacs.Visibility= Visibility.Hidden;
				}
            }
            else if (dgInfoPacientes.SelectedItem != null && ti.Header.Equals("Informes Médicos"))
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("../../Informes.xml");
				Paciente paciente = dgInfoPacientes.SelectedItem as Paciente;
				dgInformesPaciente.ItemsSource = new List<Informe_Paciente>();
				List<Informe_Paciente> informes = new List<Informe_Paciente>();

				int counter = 0;

				foreach (XmlNode informe in xmlDoc.DocumentElement.ChildNodes)
				{
                    if (informe.Attributes["paciente_informe"].Value.Equals(paciente.Nombre+" "+paciente.Apellidos))
					{
                        var row = new
						{
                            fecha_informe = informe.Attributes["fecha"].Value,
                            dolencia = informe.Attributes["dolencia"].Value,
                            tratamiento = informe.Attributes["tratamiento"].Value,
                            pruebas = informe.Attributes["pruebas"].Value,
                        };
						dgInformesPaciente.Visibility = Visibility.Visible;
						lblSinInformes.Visibility = Visibility.Hidden;
						informes.Add(EncontrarInforme(informe.Attributes["fecha"].Value, informe.Attributes["paciente_informe"].Value, informe.Attributes["dolencia"].Value, informe.Attributes["pruebas"].Value));
						counter++;
                    }

                }
				if (counter == 0)
				{
					dgInformesPaciente.Visibility = Visibility.Hidden;
					lblSinInformes.Visibility = Visibility.Visible;
				}
                dgInformesPaciente.ItemsSource = informes;
            }

        }

		private void restoreBorders()
		{
			txtbFecha.BorderBrush = Brushes.Black;
			txtbHora.BorderBrush = Brushes.Black;
			txtbPaciente.BorderBrush = Brushes.Black;
			txtbSanitario.BorderBrush = Brushes.Black;
			txtbDuracion.BorderBrush = Brushes.Black;
			txtbFecha.Background = Brushes.White;
			txtbHora.Background = Brushes.White;
			txtbPaciente.Background = Brushes.White;
			txtbSanitario.Background = Brushes.White;
			txtbDuracion.Background = Brushes.White;
		}

		private void btnCrearCita_Click(object sender, RoutedEventArgs e)
		{
			string fecha = txtbFecha.Text;
			string hora = txtbHora.Text;
			string paciente = txtbPaciente.Text;
			string sanitario = txtbSanitario.Text;
			string duracionText = txtbDuracion.Text;
			restoreBorders();

			if (IsValidDate(fecha) != null && IsValidTime(hora) != null && IsValidPac(paciente) != null && IsValidProfSanitario(sanitario) != null && IsValidDuration(duracionText) != null)
			{
				DateTime f = CombineDateAndTime(fecha, hora).Value;
				Paciente pa = IsValidPac(paciente);
				Prof_Sanitario pr = IsValidProfSanitario(sanitario);
				int duracion = int.Parse(duracionText);
				TimeSpan h = new TimeSpan(f.Hour, f.Minute, 0);
				Cita cita = new Cita(f, pa, h, pr, duracion, EstadoCita.Pendiente);

				if (añadirCita(cita))
				{
					string appointmentDetails = $"{lblFecha.Content} {cita.fecha_cita.ToString("dd/MM/yyyy")}\n" + $"{lblHora.Content} {cita.hora_cita}\n" + $"{lblPaciente.Content} {cita.paciente.Nombre + " " + cita.paciente.Apellidos}\n" + $"{lblSanitario.Content} {cita.sanitario.Nombre + " " + cita.sanitario.Apellidos}\n" + $"{lblDuracion.Content} {cita.duracion} minutos";
					MessageBox.Show($"Cita creada:\n{appointmentDetails}", "Cita creada", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				else
				{
					MessageBox.Show("La cita ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		private bool añadirCita(Cita cita)
		{
			if (!citaExistente())
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("../../Citas.xml");

				XmlElement nuevaCita = doc.CreateElement("Cita");

				XmlAttribute fecha_cita = doc.CreateAttribute("fecha_cita");
				fecha_cita.Value = cita.fecha_cita.ToString("d");
				nuevaCita.SetAttributeNode(fecha_cita);

				XmlAttribute paciente = doc.CreateAttribute("paciente");
				paciente.Value = cita.paciente.Email;
				nuevaCita.SetAttributeNode(paciente);

				XmlAttribute hora_cita = doc.CreateAttribute("hora_cita");
				hora_cita.Value = cita.hora_cita.ToString();
				nuevaCita.SetAttributeNode(hora_cita);

				XmlAttribute sanitario = doc.CreateAttribute("sanitario");
				sanitario.Value = cita.sanitario.Email;
				nuevaCita.SetAttributeNode(sanitario);

				XmlAttribute duracion = doc.CreateAttribute("duracion");
				duracion.Value = cita.duracion.ToString();
				nuevaCita.SetAttributeNode(duracion);

				XmlAttribute estado = doc.CreateAttribute("estado");
				estado.Value = cita.estado.ToString();
				nuevaCita.SetAttributeNode(estado);

				doc.DocumentElement.AppendChild(nuevaCita);
				doc.Save("../../Citas.xml");
				return true;
			}
			return false;
		}

		private bool citaExistente()
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("../../Citas.xml");

			foreach (XmlNode cita in xmlDoc.DocumentElement.ChildNodes)
			{
				if (cita.Attributes["fecha_cita"].Value.Equals(txtbFecha.Text.Replace(" ", "")) && (cita.Attributes["hora_cita"].Value.Split(':')[0] + ":" + cita.Attributes["hora_cita"].Value.Split(':')[1]).Equals(txtbHora.Text.Replace(" ", ""))
					&& cita.Attributes["paciente"].Value.Equals(txtbPaciente.Text.Replace(" ", "")) && cita.Attributes["sanitario"].Value.Equals(txtbSanitario.Text.Replace(" ", ""))
					&& cita.Attributes["duracion"].Value.Equals(txtbDuracion.Text.Replace(" ", "")))
				{
					return true;
				}
			}
			return false;
		}

		private DateTime? IsValidDate(string date)
		{
			date = date.Replace(" ", "");
			if (DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
			{
				if (parsedDate < DateTime.Today)
				{
					MessageBox.Show($"Por favor intruduce una fecha a partir del {DateTime.Today.ToString("d")}.", "Fecha incorrecta", MessageBoxButton.OK, MessageBoxImage.Warning);
					txtbFecha.BorderBrush = Brushes.Red;
					txtbFecha.Background = Brushes.LightCoral;
					return null;
				}
				return parsedDate;
			}
			MessageBox.Show("Por favor intruduce una fecha válida en formato dd/MM/yyyy.", "Fecha incorrecta", MessageBoxButton.OK, MessageBoxImage.Warning);
			txtbFecha.BorderBrush = Brushes.Red;
			txtbFecha.Background = Brushes.LightCoral;
			return null;
		}

		private Paciente IsValidPac(string email)
		{
			email = email.Replace(" ", "");
			foreach (var item in dgInfoPacientes.Items)
			{
				if (item is Paciente pac && pac.Email == email)
				{
					return pac;
				}
			}
			MessageBox.Show("Por favor intruduce un email existente o añade un nuevo paciente.", "Email Paciente incorrecto", MessageBoxButton.OK, MessageBoxImage.Warning);
			txtbPaciente.BorderBrush = Brushes.Red;
			txtbPaciente.Background = Brushes.LightCoral;
			return null;
		}

		private Prof_Sanitario IsValidProfSanitario(string email)
		{
			email = email.Replace(" ", "");

			foreach (var item in dgInfoProfesionales.Items)
			{
				if (item is Prof_Sanitario prof && prof.Email == email)
				{
					return prof;
				}
			}
			MessageBox.Show("Por favor intruduce un email existente o añade un nuevo profesional sanitario.", "Email Profesional incorrecto", MessageBoxButton.OK, MessageBoxImage.Warning);
			txtbSanitario.BorderBrush = Brushes.Red;
			txtbSanitario.Background = Brushes.LightCoral;
			return null;
		}

		private DateTime? IsValidTime(string time)
		{
			time = time.Replace(" ", "");

			if (DateTime.TryParse(time, out DateTime appointmentDateTime))
			{
				return appointmentDateTime;
			}
			MessageBox.Show("Por favor intruduce una hora válida en formato HH:mm.", "Hora errónea", MessageBoxButton.OK, MessageBoxImage.Warning);
			txtbHora.BorderBrush = Brushes.Red;
			txtbHora.Background = Brushes.LightCoral;
			return null;
		}

		private int? IsValidDuration(string duration)
		{
			duration = duration.Replace(" ", "");
			if (int.TryParse(duration, out int parsedDuration) && parsedDuration > 0)
			{
				return parsedDuration;
			}
			MessageBox.Show("Por favor intruduce una duración válida.", "Duración errónea", MessageBoxButton.OK, MessageBoxImage.Warning);
			txtbDuracion.BorderBrush = Brushes.Red;
			txtbDuracion.Background = Brushes.LightCoral;
			return null;
		}

		private DateTime? CombineDateAndTime(string date, string time)
		{
			DateTime? validDate = IsValidDate(date);
			DateTime? validTime = IsValidTime(time);
			if (validDate.HasValue && validTime.HasValue)
			{
				DateTime combinedDateTime = new DateTime(
						validDate.Value.Year,
						validDate.Value.Month,
						validDate.Value.Day,
						validTime.Value.Hour,
						validTime.Value.Minute,
						0);
				return combinedDateTime;
			}
			return null;
		}

		private void calNuevaCita_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		{
			if (calNuevaCita.SelectedDate.HasValue)
			{
				DateTime selectedDate = calNuevaCita.SelectedDate.Value;
				txtbFecha.Text = selectedDate.ToString("dd/MM/yyyy");
			}
		}

		private void dgInfoProfesionales_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			TabItem ti = TabControlProf.SelectedItem as TabItem;

			if (dgInfoProfesionales.SelectedItem != null && ti.Header.Equals("Datos Personales"))
			{
				Profesional prof = dgInfoProfesionales.SelectedItem as Profesional;

                MainConfiguration nuevaConfig = new MainConfiguration(configuracion_actual.urlFondo, configuracion_actual.ColorPanel, configuracion_actual.ColorBotonNoPresionado, configuracion_actual.ColorBotonPresionado, configuracion_actual.ColorLetra, configuracion_actual.TamanioLetra);
                nuevaConfig.ProfesionalSeleccionado = prof;
                gridMain.DataContext = nuevaConfig;

                checkSanitarioInd.IsChecked = prof.Tipo.Equals(TipoProfesional.Sanitario);
				checkLimpiezaInd.IsChecked = prof.Tipo.Equals(TipoProfesional.Limpieza);
			}
			else if (dgInfoProfesionales.SelectedItem != null && ti.Header.Equals("Historial de citas"))
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("../../Citas.xml");

				Profesional prof = dgInfoProfesionales.SelectedItem as Profesional;
				dgrHistorialProf.Items.Clear();
				int counter = 0;

				if (prof.Tipo == TipoProfesional.Limpieza)
				{
					LeyendaProfs.Visibility = Visibility.Hidden;
					lblHistorial.Content = "No es un profesional sanitario";
					lblHistorial.Visibility = Visibility.Visible;
					dgrHistorialProf.Visibility = Visibility.Hidden;
					return;
				}

				foreach (XmlNode cita in xmlDoc.DocumentElement.ChildNodes)
				{
					if (cita.Attributes["sanitario"].Value.Equals(prof.Email))
					{
							Paciente p = IsValidPac(cita.Attributes["paciente"].Value);

							var row = new
							{
								fecha = cita.Attributes["fecha_cita"].Value,
								hora = cita.Attributes["hora_cita"].Value,
								paciente = p.Nombre + " " + p.Apellidos,
								estado = cita.Attributes["estado"].Value
							};
							dgrHistorialProf.Visibility = Visibility.Visible;
							dgrHistorialProf.Items.Add(row);
							LeyendaProfs.Visibility = Visibility.Visible;
							lblHistorial.Visibility = Visibility.Hidden;		
							counter++;
					}
				}
				if(counter == 0)
				{
					LeyendaProfs.Visibility = Visibility.Hidden;
					dgrHistorialProf.Visibility = Visibility.Hidden;
					lblHistorial.Content = "No hay citas para este profesional";
					lblHistorial.Visibility = Visibility.Visible;
				}
			}

		}

		private void btnAñadirProfesional_Click(object sender, RoutedEventArgs e)
		{
			string nombre = txtNombrePr.Text;
			string apellidos = txtApellidoPr.Text;
			string direccion = txtDireccionPr.Text;
			string dni = txtDNIPr.Text;
			string telefono = txtTlfPr.Text;
			string sexo = cbSexoPr.Text;
			string email = txtEmailPr.Text;
			string fecha_nacimiento = txtFechaNacPr.Text;
			string[] fecha_nacimiento_unidades = fecha_nacimiento.Replace(" ", "").Split('/');
			TipoProfesional tipo = checkSanitario.IsChecked.Value ? TipoProfesional.Sanitario : TipoProfesional.Limpieza;


			restoreBorders();

			if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellidos) && !string.IsNullOrEmpty(direccion) && (!string.IsNullOrEmpty(dni) || dni.Replace(" ", "").Length == 8) && (!string.IsNullOrEmpty(telefono) || telefono.Replace(" ", "").Length == 9) && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[0]) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[1]) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[2]))
			{
				if ((!checkSanitario.IsChecked.Value && !checkLimpieza.IsChecked.Value) || (checkSanitario.IsChecked.Value && checkLimpieza.IsChecked.Value))
				{
					MessageBox.Show("Seleccione el tipo de profesional", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
					return;
				}

				if (tipo == TipoProfesional.Sanitario)
				{

					Prof_Sanitario prof = new Prof_Sanitario(nombre.Replace(" ", ""), apellidos.Replace(" ", ""), fecha_nacimiento.Replace(" ", ""), direccion, email.Replace(" ", ""), telefono.Replace(" ", ""), sexo.Replace(" ", ""), dni.Replace(" ", ""), tipo, "");

					if (añadirProfesionalSanitario(prof))
					{
						MessageBox.Show("Profesional sanitario añadido correctamente", "Profesional añadido", MessageBoxButton.OK, MessageBoxImage.Information);
					}
					else
					{
						MessageBox.Show("El profesional ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
					}
				}
				else
				{

					Prof_Limpieza prof = new Prof_Limpieza(nombre.Replace(" ", ""), apellidos.Replace(" ", ""), fecha_nacimiento.Replace(" ", ""), direccion.Replace(" ", ""), email.Replace(" ", ""), telefono.Replace(" ", ""), sexo.Replace(" ", ""), dni.Replace(" ", ""), tipo, "");

					if (añadirProfesionalLimpieza(prof))
					{
						MessageBox.Show("Profesional de limpieza añadido correctamente", "Profesional añadido", MessageBoxButton.OK, MessageBoxImage.Information);
					}
					else
					{
						MessageBox.Show("El profesional ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
					}
				}
			}
			else
			{
				if (fecha_nacimiento_unidades[0].Length != 2 || fecha_nacimiento_unidades[1].Length != 2 || fecha_nacimiento_unidades[2].Length != 4)
				{
                    MessageBox.Show("La fecha debe tener el formato dd/mm/yyyy", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                } 
				else
				if (telefono.Replace(" ", "").Length != 9)
				{
					MessageBox.Show("El teléfono debe tener 9 dígitos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				else if (dni.Replace(" ", "").Length != 8)
				{
					MessageBox.Show("El DNI debe tener 8 dígitos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				else
				{
					MessageBox.Show("Rellene todos los campos correctamente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		private bool añadirProfesionalLimpieza(Prof_Limpieza prof)
		{
			if (!ProfesionalExistente())
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("../../Profesionales.xml");

				XmlElement nuevoProf = doc.CreateElement("Prof_limpieza");

				XmlAttribute nombre = doc.CreateAttribute("Nombre");
				nombre.Value = prof.Nombre;
				nuevoProf.SetAttributeNode(nombre);

				XmlAttribute apellidos = doc.CreateAttribute("Apellidos");
				apellidos.Value = prof.Apellidos;
				nuevoProf.SetAttributeNode(apellidos);

				XmlAttribute fecha_nac = doc.CreateAttribute("FechaNacimiento");
				fecha_nac.Value = prof.FechaNacimiento;
				nuevoProf.SetAttributeNode(fecha_nac);

				XmlAttribute dni = doc.CreateAttribute("DNI");
				dni.Value = prof.DNI;
				nuevoProf.SetAttributeNode(dni);

				XmlAttribute direcc = doc.CreateAttribute("Direccion");
				direcc.Value = prof.Direccion;
				nuevoProf.SetAttributeNode(direcc);

				XmlAttribute tlf = doc.CreateAttribute("Telefono");
				tlf.Value = prof.Telefono;
				nuevoProf.SetAttributeNode(tlf);

				XmlAttribute sexo = doc.CreateAttribute("Sexo");
				sexo.Value = prof.Sexo;
				nuevoProf.SetAttributeNode(sexo);

				XmlAttribute email = doc.CreateAttribute("Email");
				email.Value = prof.Email;
				nuevoProf.SetAttributeNode(email);

				XmlAttribute tipo = doc.CreateAttribute("Tipo");
				tipo.Value = prof.Tipo.ToString();
				nuevoProf.SetAttributeNode(tipo);

				XmlAttribute horario = doc.CreateAttribute("Horario");
				horario.Value = prof.horario;
				nuevoProf.SetAttributeNode(horario);

				doc.DocumentElement.AppendChild(nuevoProf);
				doc.Save("../../Profesionales.xml");
				return true;
			}
			return false;
		}

		private bool añadirProfesionalSanitario(Prof_Sanitario prof)
		{
			if (!ProfesionalExistente())
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("../../Profesionales.xml");

				XmlElement nuevoProf = doc.CreateElement("Prof_sanitario");

				XmlAttribute nombre = doc.CreateAttribute("Nombre");
				nombre.Value = prof.Nombre;
				nuevoProf.SetAttributeNode(nombre);

				XmlAttribute apellidos = doc.CreateAttribute("Apellidos");
				apellidos.Value = prof.Apellidos;
				nuevoProf.SetAttributeNode(apellidos);

				XmlAttribute fecha_nac = doc.CreateAttribute("FechaNacimiento");
				fecha_nac.Value = prof.FechaNacimiento;
				nuevoProf.SetAttributeNode(fecha_nac);

				XmlAttribute dni = doc.CreateAttribute("DNI");
				dni.Value = prof.DNI;
				nuevoProf.SetAttributeNode(dni);

				XmlAttribute direcc = doc.CreateAttribute("Direccion");
				direcc.Value = prof.Direccion;
				nuevoProf.SetAttributeNode(direcc);

				XmlAttribute tlf = doc.CreateAttribute("Telefono");
				tlf.Value = prof.Telefono;
				nuevoProf.SetAttributeNode(tlf);

				XmlAttribute sexo = doc.CreateAttribute("Sexo");
				sexo.Value = prof.Sexo;
				nuevoProf.SetAttributeNode(sexo);

				XmlAttribute email = doc.CreateAttribute("Email");
				email.Value = prof.Email;
				nuevoProf.SetAttributeNode(email);

				XmlAttribute tipo = doc.CreateAttribute("Tipo");
				tipo.Value = prof.Tipo.ToString();
				nuevoProf.SetAttributeNode(tipo);

				XmlAttribute historial = doc.CreateAttribute("Historial");
				historial.Value = prof.historial;
				nuevoProf.SetAttributeNode(historial);


				doc.DocumentElement.AppendChild(nuevoProf);
				doc.Save("../../Profesionales.xml");
				return true;
			}
			return false;
		}

		private bool ProfesionalExistente()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load("../../Profesionales.xml");


			foreach (XmlNode prof in doc.DocumentElement.ChildNodes)
			{
				if (prof.Attributes["DNI"].Value.Equals(txtDNIPr.Text.Replace(" ", "")) && prof.Attributes["Email"].Value.Equals(txtEmailPr.Text.Replace(" ", "")))
				{
					if ((prof.Attributes["Tipo"].Value == "Sanitario" && checkSanitario.IsChecked.Value) || (prof.Attributes["Tipo"].Value == "Limpieza" && checkLimpieza.IsChecked.Value))
					{
						return true;
					}
				}
			}
			return false;
		}
		private void btnAñadirPaciente_Click(object sender, RoutedEventArgs e)
		{
			string nombre = txtNombre.Text;
			string apellidos = txtApellido.Text;
			string direccion = txtDireccion.Text;
			string dni = txtDNI.Text;
			string telefono = txtTlf.Text;
			string sexo = cbSexo.Text;
			string email = txtEmail.Text;
			string fecha_nacimiento = txtFechaNac.Text;
			string[] fecha_nacimiento_unidades = fecha_nacimiento.Replace(" ", "").Split('/');
			bool fumador = checkFumador.IsChecked.Value;
			bool cirugia = checkCirugiaPrevia.IsChecked.Value;
			restoreBorders();

			

			if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellidos) && !string.IsNullOrEmpty(direccion) && (!string.IsNullOrEmpty(dni) || dni.Replace(" ", "").Length == 8) && (!string.IsNullOrEmpty(telefono) && telefono.Replace(" ", "").Length == 9) && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[0]) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[1]) && !string.IsNullOrEmpty(fecha_nacimiento_unidades[2]))

            {
                

                Paciente pac = new Paciente(nombre.Replace(" ", ""), apellidos.Replace(" ", ""), fecha_nacimiento.Replace(" ", ""), direccion, email.Replace(" ", ""), telefono.Replace(" ", ""), dni.Replace(" ", ""), sexo.Replace(" ", ""), cirugia, fumador);

				if (añadirPaciente(pac))
				{
					MessageBox.Show("Paciente añadido correctamente", "Paciente añadido", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				else
				{
					MessageBox.Show("El paciente ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
			else
			{
				if (fecha_nacimiento_unidades[0].Length != 2 || fecha_nacimiento_unidades[1].Length != 2 || fecha_nacimiento_unidades[2].Length != 4)
				{
					MessageBox.Show("La fecha debe tener el formato dd/mm/yyyy", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				else if (telefono.Replace(" ", "").Length != 9)
				{
					MessageBox.Show("El teléfono debe tener 9 dígitos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				else if (dni.Replace(" ", "").Length != 8)
				{
					MessageBox.Show("El DNI debe tener 8 dígitos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}else
				{
					MessageBox.Show("Rellene todos los campos correctamente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		private bool añadirPaciente(Paciente pac)
		{
			if (!PacienteExistente())
			{
				XmlDocument doc = new XmlDocument();
				doc.Load("../../Pacientes.xml");

				XmlElement nuevoPac = doc.CreateElement("Paciente");

				XmlAttribute nombre = doc.CreateAttribute("Nombre");
				nombre.Value = pac.Nombre;
				nuevoPac.SetAttributeNode(nombre);

				XmlAttribute apellidos = doc.CreateAttribute("Apellidos");
				apellidos.Value = pac.Apellidos;
				nuevoPac.SetAttributeNode(apellidos);

				XmlAttribute dni = doc.CreateAttribute("DNI");
				dni.Value = pac.DNI;
				nuevoPac.SetAttributeNode(dni);

				XmlAttribute fecha_nac = doc.CreateAttribute("FechaNacimiento");
				fecha_nac.Value = pac.FechaNacimiento;
				nuevoPac.SetAttributeNode(fecha_nac);

				XmlAttribute direcc = doc.CreateAttribute("Direccion");
				direcc.Value = pac.Direccion;
				nuevoPac.SetAttributeNode(direcc);

				XmlAttribute tlf = doc.CreateAttribute("Telefono");
				tlf.Value = pac.Telefono;
				nuevoPac.SetAttributeNode(tlf);

				XmlAttribute sexo = doc.CreateAttribute("Sexo");
				sexo.Value = pac.Sexo;
				nuevoPac.SetAttributeNode(sexo);

				XmlAttribute email = doc.CreateAttribute("Email");
				email.Value = pac.Email;
				nuevoPac.SetAttributeNode(email);

				XmlAttribute fmdr = doc.CreateAttribute("Fumador");
				fmdr.Value = pac.Fumador.ToString();
				nuevoPac.SetAttributeNode(fmdr);

				XmlAttribute crg = doc.CreateAttribute("Cirugia");
				crg.Value = pac.Cirugia.ToString();
				nuevoPac.SetAttributeNode(crg);

				doc.DocumentElement.AppendChild(nuevoPac);
				doc.Save("../../Pacientes.xml");
				return true;
			}
			return false;
		}

		private bool PacienteExistente()
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("../../Pacientes.xml");

			foreach (XmlNode pac in xmlDoc.DocumentElement.ChildNodes)
			{
				if (pac.Attributes["DNI"].Value.Equals(txtDNI.Text.Replace(" ", "")) && pac.Attributes["Email"].Value.Equals(txtEmail.Text.Replace(" ", "")))
				{
					return true;
				}
			}
			return false;
		}

		private void calendarCitas_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load("../../Citas.xml");

			if (calendarCitas.SelectedDate.HasValue)
			{
				dgCitas.Items.Clear();
				foreach (XmlNode cita in xmlDoc.DocumentElement.ChildNodes)
				{
					string selectedDate = calendarCitas.SelectedDate.Value.ToString("d");

					if (cita.Attributes["fecha_cita"].Value.ToString().Equals(selectedDate) && cita.Attributes["estado"].Value=="Pendiente")
					{
						var row = new 
						{
							hora = cita.Attributes["hora_cita"].Value,
							paciente = cita.Attributes["paciente"].Value,
							sanitario = cita.Attributes["sanitario"].Value,
							duracion = cita.Attributes["duracion"].Value
						};

						dgCitas.Items.Add(row);
					}
				} 
			}
		}

		private void btnCancelarCita_Click(object sender, RoutedEventArgs e)
		{
			if (dgCitas.SelectedItem != null)
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load("../../Citas.xml");
				foreach (XmlNode cita in xmlDoc.DocumentElement.ChildNodes)
				{
					if (cita.Attributes["paciente"].Value.Equals(((dynamic)dgCitas.SelectedItem).paciente) && cita.Attributes["hora_cita"].Value.Equals(((dynamic)dgCitas.SelectedItem).hora) && cita.Attributes["fecha_cita"].Value.Equals(calendarCitas.SelectedDate.Value.ToString("d")))
					{
						CustomMessageBox messageBox = new CustomMessageBox("¿Está seguro de que \ndesea cancelar la cita?", "Cancelación de cita");
						messageBox.WindowStartupLocation = WindowStartupLocation.CenterScreen;
						bool? result = messageBox.ShowDialog();
						if (result == true)
						{
							cita.Attributes["estado"].Value = "Cancelada";
							dgCitas.Items.Remove(dgCitas.SelectedItem);
							xmlDoc.Save("../../Citas.xml");
							MessageBox.Show("Cita cancelada correctamente", "Cita cancelada", MessageBoxButton.OK, MessageBoxImage.Information);
							break;
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Seleccione una cita", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}


        // ---- BOTONES AJUSTES ----

        private void checkOscuro_unchecked(object sender, RoutedEventArgs e)
        {
			MainConfiguration nuevaConfig = new MainConfiguration();
			nuevaConfig.TamanioLetra = configuracion_actual.TamanioLetra;
			configuracion_actual = nuevaConfig;
			gridMain.DataContext = nuevaConfig;	
			gridMain.UpdateLayout();
        }

        private void checkOscuro_checked(object sender, RoutedEventArgs e)
        {
            MainConfiguration nuevaConfig = new MainConfiguration(new BitmapImage(new Uri(@"/img/fondo_oscuro.png", UriKind.Relative)), new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9F696969")), new SolidColorBrush(Colors.DimGray), new SolidColorBrush(Colors.DarkGray), new SolidColorBrush(Colors.White), configuracion_actual.TamanioLetra);
			configuracion_actual = nuevaConfig;
            gridMain.DataContext = nuevaConfig;
            gridMain.UpdateLayout();
        }

        private void btnGrande_Click(object sender, RoutedEventArgs e)
        {
            MainConfiguration nuevaConfig = new MainConfiguration(configuracion_actual.urlFondo,configuracion_actual.ColorPanel,configuracion_actual.ColorBotonNoPresionado,configuracion_actual.ColorBotonPresionado,configuracion_actual.ColorLetra,"18");
			configuracion_actual= nuevaConfig;
            gridMain.DataContext = nuevaConfig;
            gridMain.UpdateLayout();
        }

        private void btnMediano_Click(object sender, RoutedEventArgs e)
        {
            MainConfiguration nuevaConfig = new MainConfiguration(configuracion_actual.urlFondo, configuracion_actual.ColorPanel, configuracion_actual.ColorBotonNoPresionado, configuracion_actual.ColorBotonPresionado, configuracion_actual.ColorLetra, "15");
            configuracion_actual = nuevaConfig;
            gridMain.DataContext = nuevaConfig;
            gridMain.UpdateLayout();
        }

        private void btnPequeño_Click(object sender, RoutedEventArgs e)
        {
            MainConfiguration nuevaConfig = new MainConfiguration(configuracion_actual.urlFondo, configuracion_actual.ColorPanel, configuracion_actual.ColorBotonNoPresionado, configuracion_actual.ColorBotonPresionado, configuracion_actual.ColorLetra, "12");
            configuracion_actual = nuevaConfig;
            gridMain.DataContext = nuevaConfig;
            gridMain.UpdateLayout();
        }

		// ---- Textboxes añadir cita ----
		private void txtbPaciente_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtbPaciente.Text == "example@mail.com")
			{
				txtbPaciente.Text = string.Empty;
			}
		}

		private void txtbPaciente_LostFocus(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtbPaciente.Text))
			{
				txtbPaciente.Text = "example@mail.com";
			}
		}

		private void txtbSanitario_LostFocus(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtbSanitario.Text))
			{
				txtbSanitario.Text = "example@mail.com";
			}
		}

		private void txtbSanitario_GotFocus(object sender, RoutedEventArgs e)
		{
			if(txtbSanitario.Text == "example@mail.com")
			{
				txtbSanitario.Text = string.Empty;
			}
		}

		// ---- BOTONES AYUDA ----
		private void BtnFondoNegro_Click(object sender, RoutedEventArgs e)
		{
			string mensaje = "Si el fondo está negro, es debido a que en la sección Ajustes el modo oscuro está activado.";
			MessageBox.Show(mensaje, "Ayuda Modo Oscuro", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void btnEliminarCitaAtendida_Click(object sender, RoutedEventArgs e)
		{
			string mensaje = "No, las citas se pueden cancelar, pero las atendidas se guardan en el historial del paciente para su seguimiento.";
			MessageBox.Show(mensaje, "Ayuda Eliminar Cita", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void btnManual_Click(object sender, RoutedEventArgs e)
		{
			string nombreArchivo = "ManualUsuario.html";

			string currentDirectory = Directory.GetCurrentDirectory();

			string rootDirectory = System.IO.Path.Combine(currentDirectory, "..", "..");

			string rutaHtml = System.IO.Path.Combine(rootDirectory, nombreArchivo);

			Process.Start(rutaHtml);
		}

		private void btnBuscarPac_Click(object sender, RoutedEventArgs e)
		{
			if (!(string.IsNullOrWhiteSpace(txtbBuscarPaciente.Text)))
			{
				if(txtbBuscarPaciente.Text == "Introduce el nombre, DNI, o email de un paciente...")
				{
					dgInfoPacientes.Items.Clear();
					CargarContenidoPacientesXML();
				}
				else
				{
					var textoBusqueda = txtbBuscarPaciente.Text.Replace(" ", "").ToLower();
					dgInfoPacientes.Items.Clear();
					CargarContenidoPacientesXML();

					for (int i = dgInfoPacientes.Items.Count - 1; i >= 0; i--)
					{
						var item = dgInfoPacientes.Items[i] as Paciente;

						if (item != null &&
							!(item.DNI.ToLower().Contains(textoBusqueda) ||
							  item.Email.ToLower().Contains(textoBusqueda) ||
							  item.Apellidos.ToLower().Contains(textoBusqueda) ||
							  item.Nombre.ToLower().Contains(textoBusqueda)))
						{
							dgInfoPacientes.Items.RemoveAt(i);
						}
					}
				}
			}
			else
			{
				dgInfoPacientes.Items.Clear();
				CargarContenidoPacientesXML();
			}
		}
		private void btnBuscarSan_Click(object sender, RoutedEventArgs e)
		{
			if (!(string.IsNullOrWhiteSpace(txtbBuscarSanitario.Text)))
			{
				if (txtbBuscarSanitario.Text == "Introduce el nombre, DNI, o email de un profesional...")
				{
					dgInfoProfesionales.Items.Clear();
					CargarContenidoProfesionalesXML();
				}
				else
				{
					var textoBusqueda = txtbBuscarSanitario.Text.Replace(" ", "").ToLower();
					dgInfoProfesionales.Items.Clear();
					CargarContenidoProfesionalesXML();

					for (int i = dgInfoProfesionales.Items.Count - 1; i >= 0; i--)
					{
						var item = dgInfoProfesionales.Items[i] as Profesional;

						if (item != null &&
							!(item.DNI.ToLower().Contains(textoBusqueda) ||
							  item.Email.ToLower().Contains(textoBusqueda) ||
							  item.Apellidos.ToLower().Contains(textoBusqueda) ||
							  item.Nombre.ToLower().Contains(textoBusqueda)))
						{
							dgInfoProfesionales.Items.RemoveAt(i);
						}
					}
				}
			}
			else
			{
				dgInfoProfesionales.Items.Clear();
				CargarContenidoProfesionalesXML();
			}
		}

		private void txtbBuscarSanitario_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtbBuscarSanitario.Text == "Introduce el nombre, DNI, o email de un profesional...")
			{
				txtbBuscarSanitario.Text = string.Empty;
			}
		}

		private void txtbBuscarSanitario_LostFocus(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtbSanitario.Text))
			{
				txtbSanitario.Text = "Introduce el nombre, DNI, o email de un profesional...";
			}
		}

		private void txtbBuscarPaciente_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtbBuscarPaciente.Text == "Introduce el nombre, DNI, o email de un paciente...")
			{
				txtbBuscarPaciente.Text = string.Empty;
			}
		}

		private void txtbBuscarPaciente_LostFocus(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtbBuscarPaciente.Text))
			{
				txtbBuscarPaciente.Text = "Introduce el nombre, DNI, o email de un paciente...";
			}
		}

		private void BtnVerInforme_Click(object sender, RoutedEventArgs e)
		{
			Informe_Paciente informe_seleccionado = dgInformesPaciente.SelectedItem as Informe_Paciente;

			if (informe_seleccionado != null)
			{
				MainConfiguration informeConfig = new MainConfiguration(configuracion_actual.urlFondo, configuracion_actual.ColorPanel, configuracion_actual.ColorBotonNoPresionado, configuracion_actual.ColorBotonPresionado, configuracion_actual.ColorLetra, configuracion_actual.TamanioLetra);
				VentanaInforme ventanaInforme = new VentanaInforme(informe_seleccionado.fecha_informe, informe_seleccionado.paciente_informe, informe_seleccionado.dolencia, informe_seleccionado.pruebas, informe_seleccionado.conclusiones, informeConfig);
				ventanaInforme.Show();
			}
		}
	}
}
