   M S B A M L   `   `   `  ���� E  AFISIPOLAB_, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FISIPOLAB_
FISIPOLAB_  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem     FISIPOLAB_.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:FISIPOLAB_     9System&clr-namespace:System;assembly=mscorlib       � Title$  
MainWindow��$	��666��$
��1200�����	#FFB8B8B8 � 	Resources    ClickedButtonBrush �� Color  ClickedButtonBkgd��%A   &	        &	      �� $ SeaGreen���� $ LightSeaGreen��.��� -    �Name$ gridMain�� � RowDefinitions �� $	��91* ��� $
��470* ��� $	��23* � � ColumnDefinitions �� $	��11* ��� $	��82* ��� $
��421* ��� $	��73* �.+�� -   $ gridMainMenu��$��5��$��3�� �� $	��65* ��� $
��131* ��� $	��66* ��� $
��244* ��� $
��103* � �� $
��187* ��� $
��835* ��� $
��178* �.+��� -    ��Name$ 
lblNavegar��$��¡Empieza a navegar!��$
��Left=�$��53��$	��Top=�$	��320��$��34(�$��Georgia Pro)�$��1��$��4��$��	291,4,0,0q��� -   $ lblBienvenida��$��34(�$��Center=�$��Georgia Pro)�$��1��$��2��$��
162,5,94,4q��� -    ��Name$ imgUsuarioMini_Copiar2��$��281,10,214,0q�$��1��$#��/img/user_profile_picture.png��$��1���� $��3��$��1��$	��241��$��Sobre Ti��$��	67,0,35,0q�$��Center=�.���� -    ��Name$ UserStackPanel��$��0,0,-2,0q�.+��� -   $ lblNombreUsuario��$��Nombre: ��$��	10,0,-2,0q�$��25���� -   $ lblApellidosUsuario��$��Apellidos: ��$��	10,0,-2,0q�$��25���� -	   $ lblDNIUsuario��$��DNI: ��$��	10,0,-2,0q�$��25���� -
   $ lblFechaNacimientoUsuario��$��Fecha de Nacimiento: ��$��	10,0,-2,0q�$��25���� -   $ lblDireccionUsuario��$��Dirección: ��$��	10,0,-2,0q�$��25���� -   $ lblEmailUsuario��$��E-mail: ��$��	10,0,-2,0q�$��25��� -   $! gridPlanificacionCalendario��$��5��$��3�� �� $	��57* ��� $	��30* ��� $	��40* ��� $
��376* ��� $	��21* � �� $	��44* ��� $
��113* ��� $	��98* ��� $	��27* �.+�&   System.Windows.Controls.Calendar  -   	  Name$	 calendarCitas��$��1��$
��Left=�$��3��$	��Top=����	#FF0786FF���	#FFD7D7D7
 J� RenderTransformOrigin$
 0.5,0.5&�$	��168��$	��178��$��Georgia Pro)�$��	74,84,0,0q���Z� ���� *	FontStyle+ �� ElementName$ calendarCitas�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  z�V� .~���  �� ScaleX$	 1.6Q� �� ScaleY$	 1.6Q��� �� T� �� $��1��$
��Left=�$��	32,30,0,0q�$��1��$	��Top=�$��37��$	��120��$��Georgia Pro)�$��2��   .����  �� Orientation$ 
Horizontal=�.+��� $��/img/papelera.png��$��0,0,5,0q�$��29��$��29���� $��Cancelar cita��$��Center=��� $��1��$
��Left=�$��
172,30,0,0q�$��1��$	��Top=�$��37��$	��120��$��Georgia)�$��2��   .���� $ 
Horizontal=�.+��� $��/img/reloj.png��$��0,0,5,0q�$��29��$��29���� $��
Nueva cita��$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ dgInfoUsuario_Copiar��$��1��$��475,10,26,10q�$��2��$��2��$��Georgia Pro)�   AutoGenerateColumns .  $��2��      Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Hora��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *hora+  $ Paciente�� �� *
paciente+  $ 	Sanitario�� �� *	sanitario+  $ Duracion�� �� *
duracion+.@���#ItemsSource="Usuario.cs"��� -   $  gridPlanificacionNuevaCita��$��5��$��3�� �� $	��56* ��� $	��88* ��� $
��283* ��� $	��77* ��� $	��20* � �� $
��132* ��� $
��302* ��� $
��160* ��� $	��50* ��� $	��92* ��� $	��29* ��� $	��81* �.+�  -   $	 calNuevaCita��$��1��$��2�����	#FF0786FF���	#FFD7D7D7$
 0.5,0.5&�$��Georgia Pro)�$��76,64,0,119q�$
��Left=�$	��168��$	��178����Z� ���� *	FontStyle+$ calendarCitas��   z�V� .~��� $	 1.5Q�$	 1.5Q��� �� T� �� -   $ lblFecha��$��2��$��Fecha de la cita:��$��Right=�$��0,51,0,0q�$��2��$	��116��$��Georgia Pro)�$��29��$	��Top=��� -   $ lblHora��$��2��$��Hora de la cita:��$��Right=�$��0,85,0,0q�$��2��$	��111��$��Georgia Pro)�$��29��$	��Top=��� -   $ lblPaciente��$��2��$��Paciente atendido:��$��Right=�$��	0,123,0,0q�$��2��$	��132��$��Georgia Pro)�$��29��$	��Top=��� -   $ lblSanitario��$��2��$��Sanitario encargado:��$��Right=�$��	0,161,0,0q�$��2��$	��150��$��Georgia Pro)�$��29��$	��Top=��� -   $ lblDuracion��$��2��$��Duración estimada:��$��Right=�$��	0,195,0,0q�$��2��$	��140��$��Georgia Pro)�$��29��$	��Top=��� -    ��Name$ 	txtbFecha��$��3��$��
1,51,120,0q�$��2�� �� TextWrapping$
 Wrap=�$
�� / /��$��Georgia Pro)�$��29��$	��Top=�$��2��$��Center=��� -   $ txtbHora��$��3��$��
1,85,120,0q�$��2��$
 Wrap=�$	�� : ��$��Georgia Pro)�$��29��$	��Top=�$��2��$��Center=��� -   $ txtbPaciente��$��3��$��	0,121,0,0q�$��2��$
 Wrap=�$��example@mail.com��$��2��$��Georgia Pro)�$��29��$	��Top=�$��Center=��� -   $ txtbSanitario��$��3��$��	0,161,0,0q�$��2��$
 Wrap=�$��example@mail.com��$��2��$��Georgia Pro)�$��29��$	��Top=�$��Center=��� -   $ txtbDuracion��$��3��$��	0,195,0,0q�$��2��$
 Wrap=�$��Georgia Pro)�$��Center=�$��69��$��29��$��Center=�$	��Top=��� -   $ 
lblMinutos��$��4��$��Minutos��$
��Left=�$��	0,195,0,0q�$��2��$��70��$��Georgia Pro)�$��29��$	��Top=��� -    ��Name$ btnCrearCita��$��2��$
��Left=�$��183,252,0,0q�$��2��$	��Top=�$��50��$��3��$	��125��   .���� $ 
Horizontal=�.+��� $��/img/menu/mas.png��$��0,0,5,0q�$��21��$��18���� $��
Crear cita��$��Center=��� -    ��Name$ gboxNuevaCita��$��2��$��
Nueva Cita��$��1��$��4��$��
0,89,10,18q�$��2��
���   �$��26(�$��2q�� -   $ gridPacientesLista��$��5��$��3�� �� $	��56* ��� $
��140* ��� $
��224* ��� $	��85* ��� $	��19* � �� $	��44* ��� $
��211* ��� $	��27* �.+��� -     ��Name$ TabControlPac�� �� TabStripPlacement$ Right=�$��1��$��2��$��3��$��
248,1,0,19q�.@��� -!    ��Name$ TabDatosPersonalesPac��$��Datos Personales��$��0,-2,-2,-18q�.��� -"   $ grDatosIndividualesPac�����	#FFE5E5E5$��0,0,-12,-30q�.+��� $	��Top=�$	��214��$��
-2,-7,-2,0q�.+��� $��Center=�$	��300��$	��Top=�$	��245��
 �� Top$ 10��.+��� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -#   $ 	lblDNIInd��$
��Left=�$��Right=�$	��DNI��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -$   $ 	txtDNIInd��$
��Left=�$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *DNI+�� $ 
Horizontal=�$
��Left=�$��48,0,0,0q�.+��� -%   $ 	lblTlfInd��$��Right=�$��	Teléfono��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -&   $ 	txtTlfInd��$
��Left=�$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *
Telefono+�� $ 
Horizontal=�$	��224��$��43��$
��Left=�$��18,0,0,0q�.+��� -'   $ lblFechaNacInd��$��Right=�$��Fecha de Nacimiento��$	��122��$��21��$��Georgia Pro)��� -(   $ txtFechaNacInd��$
��Left=�$��97��$��19��$��5,0,0,6q�$��Georgia Pro)����� *FechaNacimiento+�� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -)   $ lblDireccionInd��$��Right=�$��
Dirección��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -*   $ txtDireccionInd��$��98��$��35��$��5,0,0,6q� � Cursor$  ��$
 Wrap=�$��Georgia Pro)����� *	Direccion+�� $��	220,0,0,0q�$ 10��.+��� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -+   $ lblEmailInd��$��Right=�$��Email��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -,   $ txtEmailInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *Email+�� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� --   $ 
lblSexoInd��$��Right=�$
��Sexo��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -.   $ 
txtSexoInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *Sexo+�� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -/   $ lblCirugiaPreviaInd��$��Right=�$��Cirugia previa��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -0   $ txtCirugiaInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *	Cirugia+�� $ 
Horizontal=�$
��Left=�$��48,0,0,0q�.+��� -1   $ lblFumadorInd��$��Right=�$��Fumador��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)�$��Center=��� -2   $ txtFumadorInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *	Fumador+�� -3   $ TabHistorialCitas��$��Historial de citas��$��0,18,-2,-36q�.��� -4   $ grHistorialCitasPac�����	#FFE5E5E5�� -5   $ TabInformes��$��Informes Médicos��$��0,35,-2,-56q�.��� -6   $ 
grInformes�����	#FFE5E5E5$��0,0,1,0q�  -7   $ dgInfoPacientes��$��1��$��
21,2,650,0q�$��2�� .     $ Nombre�� �� *Nombre+  $ 	Apellidos�� �� *	Apellidos+  $	 DNI��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80  �� *DNI+�� $�� ��$��21,48,131,47q�$��1��$��1��
���   �
���   ����	#80FFFFFF.���� $��-6,-8,-2,-2q�$
��Left=�$	��Top=�$ 
Horizontal=�.+��� -8   $ imgUsuarioMini_Copiar��$��/img/search.png��$��19��$��28���� $
 Wrap=�$3��-Introduce el nombre o email de un paciente...��$	��450��$��30��$
 0.5,0.5&�$	��Top=�$��12(����	#FF393939.��z�V� .~��� $ 1Q��� �� T� .���� $��1��$��772,70,51,47q�$��1��.���� $��/img/filtro.png��� -9   $ gridPacientesAgregar��$��5��$��3�� �� $	��56* ��� $
��247* ��� $
��200* ��� $	��21* � �� $
��132* ��� $
��115* ��� $
��518* ��� $	��81* �.+��� -:   $ GrDatosPersonalesPac��$��2��$��Datos Personales��$��0,10,0,0q�
���   �$��2q�$��Georgia Pro)�$��1��.���� $	��Top=�$	��214��$��	-2,0,-2,0q�.+��� $��Center=�$	��199��$	��Top=�$	��245��$ 10��.+��� $ 
Horizontal=�$��0,0,0,6q�.+��� -;   $ 	lblNombre��$��Right=�$��Nombre��$��91��$��29��$��0,0,0,0q�$��Georgia Pro)��� -<   $ 	txtNombre��$	��149��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -=   $ lblApellidos��$��Right=�$��	Apellidos��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� ->   $ txtApellido��$	��148��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -?   $ lblDNI��$��Right=�$	��DNI��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -@   $ txtDNI��$
��Left=�$	��120��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -A   $ lblTlf��$��Right=�$��	Teléfono��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -B   $ txtTlf��$
��Left=�$	��120��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -C   $ lblFechaNac��$��Right=�$��Fecha de 
Nacimiento��$��92��$��48��$��Georgia Pro)��� -D   $ txtFechaNac��$
��Left=�$	��120��$��29��$��5,0,0,6q�$�� / / ��$��Georgia Pro)��� $
��Left=�$	��201�� �� Left$	 245��$��Center=�$	��251��.+��� $ 
Horizontal=�$��0,0,0,6q�.+��� -E   $ lblDireccion��$��Right=�$��
Dirección��$��87��$��29��$��0,0,0,0q�$��Georgia Pro)��� -F   $ txtDireccion��$	��170��$��29��$��5,0,0,6q�$  ��$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -G   $ lblEmail��$��Right=�$��Email��$��87��$��29��$��0,0,0,0q�$��Georgia Pro)��� -H   $ txtEmail��$	��167��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -I   $ lblSexo��$��Right=�$
��Sexo��$��87��$��29��$��0,0,0,0q�$��Georgia Pro)��� -J   $ txtSexo��$	��167��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -K   $ lblCirugiaPrevia��$��Right=�$��Cirugia previa��$��87��$��29��$��0,0,0,0q�$��Georgia Pro)��� -L     ��Name$  checkCirugiaPrevia��$�� ��$��5,6,0,6q�$��16���� $ 
Horizontal=�.+��� -M   $ 
lblFumador��$��Right=�$��Fumador��$��87��$��29��$��0,0,0,0q�$��Georgia Pro)�$��Center=�$��Center=��� -N   $  checkFumador��$�� ��$��5,6,0,6q�$��16��$��Center=�$��Center=��� -O   $ 
GrInformes��$��1��$��Informes��$��2��$��10,5,0,0q�
���   �$��2q�$��2��$��Georgia Pro)�.���� $��	10,0,11,0q�$
��Wrap=�$	��155��
�������$��Georgia Pro)��� ! � Language$! es-es�$	�+ N���� $�uevo informe:���� -P   $ imgFotoPaciente��$��1��$
��Left=�$	��109��$��10,0,0,0q�$��1��$��Center=�$	��100��" J� OpacityMask
" �   �$$��/img/menu_agregar_sin_foto.png���� $��1��$��Foto de perfil��$
��Left=�$��31��$��
11,175,0,0q�$��1��$	��Top=�$��99��$��Georgia Pro)�� -Q   $ gridProfesionalesLista��$��5��$��3�� �� $	��56* ��� $
��140* ��� $
��224* ��� $	��85* ��� $	��19* � �� $	��44* ��� $
��211* ��� $	��27* �.+��� -R   $ TabControlProf��$ Right=�$��1��$��2��$��	262,1,0,0q�.@��� -S   $ TabDatosPersonalesProf��$��Datos Personales��$��0,-2,-2,-18q�.��� -T   $ grDatosIndivProf�����	#FFE5E5E5$��0,0,-12,-30q�.+��� $	��Top=�$	��214��$��
-2,-7,-2,0q�.+��� $��Center=�$	��300��$	��Top=�$	��245��$ 10��.+��� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -U   $ lblDNIIndPr��$
��Left=�$��Right=�$	��DNI��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -V   $ txtDNIIndPr��$
��Left=�$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *DNI+�� $ 
Horizontal=�$
��Left=�$��48,0,0,0q�.+��� -W   $ lblTlfIndPr��$��Right=�$��	Teléfono��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -X   $ txtTlfIndPr��$
��Left=�$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *
Telefono+�� $ 
Horizontal=�$	��224��$��43��$
��Left=�$��18,0,0,0q�.+��� -Y   $ lblFechaNacIndPr��$��Right=�$��Fecha de Nacimiento��$	��122��$��21��$��Georgia Pro)��� -Z   $ txtFechaNacIndPr��$
��Left=�$��97��$��19��$��5,0,0,6q�$��Georgia Pro)����� *FechaNacimiento+�� $ 
Horizontal=�$��48,0,0,0q�$
��Left=�.+��� -[   $ lblDireccionIndPr��$��Right=�$��
Dirección��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -\   $ txtDireccionIndPr��$��98��$��35��$��5,0,0,6q�$  ��$
 Wrap=�$��Georgia Pro)����� *	Direccion+�� $��	220,0,0,0q�$ 10��.+��� $ 
Horizontal=�$��40,0,0,0q�$
��Left=�.+��� -]   $ lblEmailIndPr��$��Right=�$��Email��$��55��$��29��$��Georgia Pro)��� -^   $ txtEmailIndPr��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *Email+�� $ 
Horizontal=�$��40,0,0,0q�$
��Left=�.+��� -_   $ lblSexoIndPr��$��Right=�$
��Sexo��$��55��$��29��$��Georgia Pro)��� -`   $ txtSexoIndPr��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)����� *Sexo+�� $ 
Horizontal=�$��40,0,0,0q�$
��Left=�.+��� -a   $ lblSanitarioInd��$��Right=�$��Profesional sanitario��$	��138��$��29��$��Georgia Pro)��� -b   $  txtSanitarioInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$
��Left=�$��40,0,0,0q�.+��� -c   $ lblLimpiezaInd��$��Right=�$��Profesional de limpieza��$	��138��$��29��$��0,0,0,0q�$��Georgia Pro)�$��Center=��� -d   $  txtLimpiezaInd��$��98��$��19��$��5,0,0,6q�$��Georgia Pro)��� -e   $ 
TabHorario��$��Horario��$��0,17,-2,-38q�.��� -f   $ 	grHorario�����	#FFE5E5E5$��0,0,1,0q��� -g   $ TabHistorialProf��$��Historial de citas��$��0,37,-2,-58q�.��� -h   $ grHistorialProf�����	#FFE5E5E5$��0,0,1,0q�  -i   $ dgInfoProfesionales��$��1��$��
21,2,636,0q�$��2�� .     $
 Foto��$ 40   $ Nombre��$ 60  �� *Nombre+  $ 	Apellidos��$ 60  �� *	Apellidos+  $	 DNI��$ 60  �� *DNI+�� $�� ��$��21,48,131,47q�$��1��$��1��
���   �
���   ����	#80FFFFFF.���� $��-6,-8,-2,-2q�$
��Left=�$	��Top=�$ 
Horizontal=�.+��� -j   $ imgUsuarioMini_Copiar1��$��/img/search.png��$��19��$��28���� $
 Wrap=�$6��0Introduce el nombre o email de un profesional...��$	��450��$��30��$
 0.5,0.5&�$	��Top=�$��12(����	#FF393939.��z�V� .~��� $ 1Q��� �� T� .���� $��1��$��772,70,51,47q�$��1��.���� $��/img/filtro.png��� -k   $ gridProfesionalesAgregar��$��5��$��3�� �� $	��56* ��� $
��247* ��� $
��200* ��� $	��21* � �� $
��132* ��� $
��115* ��� $
��518* ��� $	��81* �.+��� -l   $ GrDatosPersonalesProf��$��2��$��Datos Personales��$��0,10,0,0q�
���   �$��2q�$��Georgia Pro)�$��1��.���� $	��Top=�$	��214��$��	-2,0,-2,0q�.+��� $��Center=�$	��199��$	��Top=�$	��245��$ 10��.+��� $ 
Horizontal=�$��0,0,0,6q�.+��� -m   $ lblNombrePr��$��Right=�$��Nombre��$��91��$��29��$��0,0,0,0q�$��Georgia Pro)��� -n   $ txtNombrePr��$	��149��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -o   $ lblApellidosPr��$��Right=�$��	Apellidos��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -p   $ txtApellidoPr��$	��148��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -q   $ lblDNIPr��$��Right=�$	��DNI��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -r   $ txtDNIPr��$
��Left=�$	��120��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -s   $ lblTlfPr��$��Right=�$��	Teléfono��$��92��$��29��$��0,0,0,0q�$��Georgia Pro)��� -t   $ txtTlfPr��$
��Left=�$	��120��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -u   $ lblFechaNacPr��$��Right=�$��Fecha de 
Nacimiento��$��92��$��48��$��Georgia Pro)��� -v   $ txtFechaNacPr��$
��Left=�$	��120��$��29��$��5,0,0,6q�$�� / / ��$��Georgia Pro)��� $
��Left=�$	��201��$	 245��$��Center=�$	��251��.+��� $ 
Horizontal=�$��0,0,0,6q�.+��� -w   $ lblDireccionPr��$��Right=�$��
Dirección��$	��121��$��29��$��0,0,0,0q�$��Georgia Pro)��� -x   $ txtDireccionPr��$	��170��$��29��$��5,0,0,6q�$  ��$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -y   $ 
lblEmailPr��$��Right=�$��Email��$	��121��$��29��$��0,0,0,0q�$��Georgia Pro)��� -z   $ 
txtEmailPr��$	��167��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -{   $ 	lblSexoPr��$��Right=�$
��Sexo��$	��121��$��29��$��0,0,0,0q�$��Georgia Pro)��� -|   $ 	txtSexoPr��$	��167��$��29��$��5,0,0,6q�$��Georgia Pro)��� $ 
Horizontal=�$��0,0,0,6q�.+��� -}   $ lblSanitario1��$��Right=�$��Personal sanitario��$	��121��$��29��$��0,0,0,0q�$��Georgia Pro)��� -~   $  checkSanitario��$�� ��$��5,6,0,6q�$��16���� $ 
Horizontal=�.+��� -   $ lblLimpieza��$��Right=�$��Personal de limpieza��$	��121��$��29��$��0,0,0,0q�$��Georgia Pro)�$��Center=�$��Center=��� -�   $  checkLimpieza��$�� ��$��5,6,0,6q�$��16��$��Center=�$��Center=��� -�   $ GrInformes1��$��1��$��Curriculum Vitae��$��2��$��10,5,0,0q�
���   �$��2q�$��2��$��Georgia Pro)�.���� $��	10,0,11,0q�$
��Wrap=�$	��155��
�������$��Georgia Pro)��� $�+ ���� $! es-es�$	�CV:���� -�   $ imgFotoPaciente1��$��1��$
��Left=�$	��109��$��10,0,0,0q�$��1��$��Center=�$	��100��
" �   �$$��/img/menu_agregar_sin_foto.png���� $��1��$��Foto de perfil��$
��Left=�$��31��$��
11,175,0,0q�$��1��$	��Top=�$��99��$��Georgia Pro)�� -�   $ gridMasAjustes��$��5��$��3�� �� $	��56* ��� $	��79* ��� $
��318* ��� $	��52* ��� $	��19* � �� $��* ��� $
��131* ��� $
��633* ��� $	��81* �.+��� $��Ajustes de la aplicación��$��Georgia Pro)�$��32(�$��32,18,255,17q�$��2��$��1���� $��2��$��2��
�������$��
32,4,101,4q�.+��� -�   $��	lblOscuro��$��Modo Oscuro��$��0,0,0,10q�$��Georgia Pro)��� -�   $ lblTamañoLetra_Copiar��$��Tamaño de fuente��$��Georgia Pro)��� -�   $  checkOscuro��$��2��$��178,14,438,278q�$��2��o� $��178,53,154,238q�$��2��$��2��.@�m� $��Pequeña��
���   �$��27��$��Georgia Pro)�$��10(�.@��� $��Pequeña��$��50��$��30��m� $��Mediana��
���   �$��12(�$��Georgia Pro)�.@��� $��Mediana��$��50��$��30��m� $��Grande��
���   �$��27��$��Georgia Pro)�.@��� $��Grande��$��50��$��30��m� $��
Muy grande��
���   �$��20(�$��27��$	��124��$��Georgia Pro)�.@��� $��
Muy Grande��$��50��$��30���� $��32,35,101,259q�$��2��$��2���� $��32,75,101,219q�$��2��$��2���� $��32,119,101,179q�$��2��$��2���� -�   $  checkNarrador��$��2��$��178,98,438,194q�$��2���� -�   $ lblTamañoLetra��$��Narrador��$��2��$��32,86,101,187q�$��2��$��Georgia Pro)�� -�   $ gridMasAyuda��$��5��$��3�� �� $	��28* ��� $	��55* ��� $	��66* ��� $
��113* � �� $	��13* ��� $
��119* ��� $
��402* ��� $
��231* ��� $	��81* �.+��� -�   $ lblAyuda��$��¿Necesitas Ayuda?��$��48��$��Center=�$��Georgia Pro)�$��32(�$��	36,0,92,0q�$��2��$��1���� -�   $ lblPregFrecuentes��$��2��$��Preguntas frecuentes:��$��32,1,189,97q�$��2��$��18(��� -�   $ lblEncontrar��$��2��$'��!¿No encuentras lo que necesitas?��$��32,19,96,173q�$��3��$��18(��� -�   $ lblProporcionManual��$��2��$4��.Te proporcionamos el manual de la aplicación:��$��12(�$��42,58,105,142q�$��3���� -�   $ 	btnManual��$��2��$��123,89,210,68q�$��3��
���������Z� .���� -�   $ Manual��$��/img/manual.png���� -�   $ 	lblManual��$��2��$��Manual de la aplicación��$��90,163,146,33q�$��3���� $��
26,40,26,3q�$��2��$��2��.+��� $.��(¿Por qué mi página tiene fondo negro?��$��25��$��0,0,0,20q��� $2��,¿Puedo eliminar una cita que ya he atendido��$��25��� -�   $ gridMasCreditos��$��5��$��3�� �� $	��56* ��� $
��451* ��� $	��18* � �� $
��132* ��� $	��32* ��� $
��383* ��� $
��218* ��� $	��81* �.+��� $��	Créditos��$��76��$	��Top=�$��Georgia Pro)�$��32(�$��0,32,0,0q�$��2��$��1��$
��Left=�$	��265���� $��2��$��	2,113,2,0q�$��1��$
��Wrap=�$	��Top=�$	��337��# �� TextAlignment$# Justify=�$��Georgia Pro)�$��14(��� $?�9Esta aplicación fue desarrollada por un grupo de futuros���� �� $C�=profesionales de la Escuela Superior de Informática, para su�� �� $� ���� $"�proyecto de Laboratorio de I���� $�PO���� $	� 1.���� �� �� �� $�Estos profesionales son:���� �� �� �� �� �� $�-Helena Neves García���� �� $�-Manuel Perales Briones���� �� $!�-Miguel Ángel Ruiz Arreaza���� -�   $ spUsuarioMini��$��3��$��0��$��	0,0,0,439q�$��2��$��2��.+��� -�   $ imgUsuarioMini��$��	13,3,13,3q�$��3��$#��/img/user_profile_picture.png��$��88��$��85���� -�   $ lblFechaUltimoAcceso��$��Último Acceso:��$��Center=�$��Center=�$��	10,0,-2,0q�$��64��$��10(�$��84���� $��1�����	#7F3329F6$��2,1,2,0q�$��1���� -�   $ stackPanelMainSelection��$��2,1,2,0q�$��1��$��1��$��2��.+��� -�   $ lblPlanificacion1��$��30��$	��112��$��0,8,0,0q�$��Center=�$��Center=�$��Center=�$��1,1,1,1q�$��Georgia Pro)�
�������.���� $ 
Horizontal=�$��18��.+��� $!��/img/menu/planificacion.png��$��0,0,5,0q�$��20��$��18���� $��Planificación��$��Center=��� -�   $ btnCalendario1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/calendario.png��$��48��$��22��$��0,0,5,0q��� $��
Calendario��$��Center=��� -�   $ btnNuevaCita1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/mas.png��$��45��$��18��$��0,0,5,0q��� $��
Nueva Cita��$��Center=��� -�   $ lblPacientes1��$��26��$	��102��$��Center=�$��Center=�$��Center=�$��0,15,0,0q�$��Georgia Pro)�
�������.���� $ 
Horizontal=�$��22��.+��� $��/img/menu/pacientes.png��$��0,0,5,0q��� $��	Pacientes��$��Center=��� -�   $ btnListaPac1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/listado.png��$��48��$��22��$��0,0,5,0q��� $��Listado��$��Center=��� -�   $ btnNuevoPac1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/mas.png��$��45��$��18��$��0,0,5,0q��� $��Añadir��$��Center=��� -�   $ lblProfesionales1��$��26��$	��112��$��Center=�$��Center=�$��Center=�$��0,15,0,0q�$��Georgia Pro)�
�������.���� $ 
Horizontal=�$��22��.+��� $��/img/menu/profesional.png��$��0,0,5,0q��� $��Profesionales��$��Center=��� -�   $ btnListaProf1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/listado.png��$��48��$��22��$��0,0,5,0q��� $��Listado��$��Center=��� -�   $ btnNuevoProf1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/mas.png��$��45��$��18��$��0,0,5,0q��� $��Añadir��$��Center=��� -�   $ lblMas1��$��27��$	��102��$��Center=�$��Center=�$��Center=�$��0,15,0,0q�$��Georgia Pro)�
�������.���� $ 
Horizontal=�$��17��.+��� $��/img/menu/masinfo.png��$��0,0,5,0q�$��18��$��17���� $
��Más��$��Center=��� -�   $ btnAjustes1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/ajustes.png��$��24��$��22��$��0,0,5,0q��� $��Ajustes��$��Center=��� -�   $ 	btnAyuda1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/ayuda.png��$��0,0,5,0q�$��24��$��22���� $��Ayuda��$��Center=��� -�   $ btnCreditos1��$��30��$	��100��$��Georgia Pro)�   .���� $ 
Horizontal=�.+��� $��/img/menu/creditos.png��$��0,0,5,0q��� $��	Créditos��$��Center=��� -�   $ btnHome��$��2��$
��Left=�$��0��$	��Top=�$��35��$��35��$��10,0,0,0q���Z� ��Z� ��Z� .���� $��/img/home.png��$
 0.975,0.201&��� -�   $ btnsalir��$��4��$��Center=�$��	0,450,0,0q�$��1��$	��Top=�$��38��$��38��$
 0.426,2.546&���Z� ��Z� ��Z� .���� $��img/salir.png���� -�   $ btncerrar_sesion��$��4��$��Center=�$��	0,400,0,0q�$��1��$	��Top=�$��38��$��38����Z� ��Z� ��Z� .���� $��img/cerrar_sesion.png��