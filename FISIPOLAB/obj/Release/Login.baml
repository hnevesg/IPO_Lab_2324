   M S B A M L   `   `   `  ���� E  AFISIPOLAB_, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FISIPOLAB_
FISIPOLAB_      FISIPOLAB_.Login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:FISIPOLAB_       � WindowStartupLocation$  CenterScreen=�$��Stretch=�$��Stretch=� � Title$ Login��$	��450��$	��800��.��� -    �Name$ pnlPrincipal�� � RowDefinitions �� $	��70* ��� $	��70* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��70* ��� $	��40* ��� $��45 � � ColumnDefinitions �� $
��171* ��� $	��70* ��� $
��154* ��� $
��124* ��� $	��40* ��� $	��70* ��� $
��171* �.+��� -    ��Name$ FondoVentana��$��0��$��0��$��9��$��7�� �� RadiusX$ 1�� �� RadiusY$ 1�����	#FF6C006C
���   � J� Opacity$	 0.8Q�$��3��	 J� RenderTransformOrigin$	 0.5,0.5&��� -   $ 
FondoLogin��$��1��$��1��$��5��$��6�����	#FFF175EE$��5,5,5,5q�$ 10��$ 10���� -   
 ��Name$
 lblTituloLogin��$��1��$��2��$��	FISIPOLAB��$��70,21,35,22q�$��34(����	#FFFDFBFB$��Center=�$��2��$��2���� -   $
 
lblUsuario��$��2��$��2��$��Usuario��$��5,0,0,5q�$��14(����	#FFFBFAFA$��Bottom=�$��Stretch=��� -    ��Name$ 
txtUsuario��$��3��$��2��$��3��$��2q�$��5,5,5,5q�$��Center=��� -   $
 lblContrasena��$��4��$��2��$��Contraseña��$��14(����	#FFFBFAFA$��	5,10,0,38q�$��Bottom=�$��Stretch=�$��2���� -   $
 lblRecordarContrasena��$��4��$��3��$��¿Necesita ayuda?��$��Italic$�$
��Bold"����	#FFA9C4F3$��Right=�$��Bottom=�$��0,0,4,38q�$��2��$��2��G� -	    G�Name$ passContrasena��$��5��$��2��$��3�� G� PasswordChar$ *��$��2q�$��5,5,5,5q�$��Center=�{�.  �� -
    ��Name$ btnLogin��$��6��$��2��$��2��$��Iniciar Sesión��$��14(�$
��Bold"����	#FFFFBCFD
�������$��91,13,56,22q��� -    ��Name$ imgCheck_usuario��$��4��$��3��$��Center=�$��30��$��0,4,0,4q�$��/imagenes/tic.png���� -   $ imgCheck_contraseña��$��4��$��5��$��Center=�$��30��$��0,4,0,4q�$��/imagenes/tic.png��