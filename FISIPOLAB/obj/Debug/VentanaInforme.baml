   M S B A M L   `   `   `  ����E  AFISIPOLAB_, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FISIPOLAB_
FISIPOLAB_  5   	       FISIPOLAB_.VentanaInforme   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:FISIPOLAB_     5   	     � Title$  Informe��5   	   $	��450��6    � WindowStartupLocation$ CenterScreen=�6&   $	��800��6K    � 
ResizeMode$ NoResize=�6W   .��5	      � -   5         �Name$ gridMain��5	       � DataContext 5
   
   "   FISIPOLAB_.MainConfiguration  5       � ColumnDefinitions 5   
   �� 5      $
��242* �6   �� 5      $
��295* �6   �� 5      $
��263* �6    � RowDefinitions 5   
   �� 5      $	��53* �6   �� 5      $
��163* �6   �� 5      $
��174* �6   �� 5      $	��44* �6   .+�5   
   � -   5        $ gridBg��5      $��3��6   $
��Left=�63   $	��646��6N   $��4��6[   $	��Top=�6l   $
��1205��6�   .+�5      �� -   5         ��Name$ imgBg��5      $��2,-1,0,0q�6#   $
��Left=�6Q   $	��797��6l   $	��431��6x   $	��Top=�6�   $
��Fill=�6�   ��65   �� *
urlFondo+6�   5      �� 5   
   -   5         ��Name$ spPresentacionUsuario��5      $��0,53,0,0q�64   $��2��6F   .+�5      (� -   5        	 (�Name$	 vbImagenPaciente��5      $��Center=�5       $	��100��5!      $��	10,10,0,0q�5"      $��Center=�5#      $	��100��5$      .��5%      �� -   5        $ imgImagenPaciente��5%      $	��100��5&      $	��100��5'      $%��./img/menu_agregar_sin_foto.png��5(      5)      �� 5+      -   5        
 ��Name$
 lblNombrePaciente��5+      $��Nombre Usuario��5,      $��Center=�5-      $��	10,10,0,0q�5.      $��Center=�5/      $	��222��50      $��20(�51      $
��Bold"�52      $��Center=�53      ��54      �� *
ColorLetra+55      �� 56   
   $��1��6   $��Sobre el informe��6    $��
0,163,0,22q�6:   $��3��6N   $
��Bold"�6�   $��Georgia Pro)�6�   ��6_   �� *
ColorPanel+��6�   �� *
ColorLetra+��6�   �� *TamanioLetra+.��57      �� $	��Top=�6   $	��173��61   $��0,10,0,0q�6>   .+�58      �� -   5         ��Name$ tbPrueba��58      $��Normal"�6.   $��41��6B   �� 6O   $�Prueba��6S   �� 6c    � Language$ es-es�6g   $�:��6x   6�   �� 59      -	   5        $ 
tbDolencia��59      $��Normal"�60   $��Síntomas: ��6D   $��43��6V   �� 5:      -
   5        $ tbFecha��5:      $��Normal"�6-   $��Fecha: ��6A   $��44��6P   5;      5<      (� 5=   
   $��1��6   $��0,53,0,0q�6"   $��3��64   .��5>      �� $	��100��6   $	��100��6!   $$��Img/Informe/pizarra_humana.jpg��6-   5?      �� 5@   
   $��2��6   $��Conclusiones��6#   $��0,53,0,3q�69   $��2��6K   $
��Bold"�6�   $��Georgia Pro)�6�   ��6\   �� *
ColorPanel+��6~   �� *
ColorLetra+��6�   �� *TamanioLetra+.��5A      �� -   5        $ tbConclusionesInforme��5A      $��Normal"�67   $
��Wrap=�6K   $�� ��6_   {�.  6g   5B      �� 5C   
   $��2��6   $��1��6#   $��Edición��60   $��
0,163,0,22q�6A   $��3��6U   $��Georgia Pro)�6f   $
��Bold"�6�   ��6   �� *
ColorPanel+��6�   �� *
ColorLetra+��6�   �� *TamanioLetra+.��5D      �� $��2��6   $��2��6)   $��LeftToRight=�66    �� Orientation$ 
Horizontal=�6R   .+�5E      �� $��15q�6   .+�5F      �� -   5         ��Name$ 	btnPincel��5F      $��40��60   $��50��6<   ��6G   �� *ColorBotonNoPresionado+ J� Effect 5G      3  -System.Windows.Media.Effects.DropShadowEffect  5H      .��5J      (� .��5K      �� $��Img/Informe/pincel.png��6$   5L      5M      �� 5O      -   5        $ btnRojo��5O      $��40��6.   $��50��6:   $��0,35,0,0q�6E   ��6W   �� *ColorBotonNoPresionado+ 5P        5Q      .��5S      (� .��5T      �� $��Img/Informe/circulo.png��6$   5U      5V      5W      �� 5Y      $��15q�6   .+�5Z      �� -   5        $ btnGoma��5Z      $��40��6.   $��50��6:   ��6E   �� *ColorBotonNoPresionado+ 5[        5\      .��5^      (� .��5_      �� $$��Img/Informe/goma-de-borrar.png��6$   5`      5a      �� 5c      -   5        $ btnCuboPintura��5c      $��40��65   $��50��6A   $��0,35,0,0q�6L   ��6^   �� *ColorBotonNoPresionado+ 5d        5e      .��5g      (� .��5h      �� $%��Img/Informe/bote-de-pintura.png��6$   5i      5j      5l      �� 5n      $��15q�6   .+�5o      �� -   5        $ btnTexto��5o      $��40��6/   $��50��6;   ��6F   �� *ColorBotonNoPresionado+ 5p        5q      .��5s      (� .��5t      �� $��Img/Informe/fuente.png��6$   5u      5v      �� 5x      -   5        $ btnseleccion��5x      $��40��63   $��50��6?   $��0,35,0,0q�6J   ��6\   �� *ColorBotonNoPresionado+ 5y        5z      .��5|      (� .��5}      �� $��Img/Informe/seleccion.png��6$   5~      5      5�      5�      5�      5�      5�      