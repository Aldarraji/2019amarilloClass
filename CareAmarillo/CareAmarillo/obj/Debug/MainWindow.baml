   M S B A M L   `   `   `  ����G  CCareAmarillo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CareAmarilloCareAmarillo  5   	       CareAmarillo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CareAmarillo     5   	     � Title$  Page1��5   	   $	��800��6   $	��800��6$   .��5	      � -   5         �Name$ lblchngpassP1��5	       � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   $	��792��6,   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��231��6:   $��
271,51,0,0q�6G   $	��Top=�6[   $	��311��6s   $��Capture.JPG��6   �� 5   
   -   5         ��Name$ 	txtUserID��5      $
��Left=�6%   $��38��6@   $��312,444,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��259��6�   $��20(�6�   6�   �� 5   
   -   5         ��Name$ lblCA��5      $��CareAmarillo��6   $
��Left=�66   $��271,265,0,0q�6Q   $	��Top=�6f   $��45(�6~   $��70��6�   $	��265��6�   �� 5   
   -   5        $ lblwel��5      $*��$Welcome! pleace sign in or register.��6    $
��Left=�6O   $��235,356,0,0q�6j   $	��Top=�6   $��22(�6�   $��39��6�   $	��356��6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��38��6B   $��312,503,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��259��6�   $��20(�6�   $2��,/CareAmarillo;component/Properties/#Password)�6�   �� 5   
   -   5        $ lblUser��5      $��UserID:��6!   $
��Left=�63   $��219,446,0,0q�6N   $	��Top=�6c   $��20(�6{   $��37��6�   $��80��6�   �� 5   
   -   5        $ lblPassword��5      $��	Password:��6%   $
��Left=�69   $��195,505,0,0q�6T   $	��Top=�6i   $��20(�6�   $��37��6�   $	��104��6�   �� 5   
   -	   5         ��Name$ btnLogin��5      $��Login��6#   $
��Left=�63   $��437,565,0,0q�6N   $	��Top=�6c   $	��134��6{   ���	#FF75BC03$��39��6�   $��18(�6�   
���   ���6�   Z� 6�   �� 5   
   -
   5        $ 
btnRegFoHS��5      $ ��Register for human service��6%   $
��Left=�6J   $��110,639,0,0q�6e   $	��Top=�6z   $	��241��6�   $��39��6�   ���	#FF75BC03
���   �$��18(�6�   ��6�   Z� 6�   �� 5   
   -   5        $ btnRegFoProv��5      $��Register for providers��6'   $
��Left=�6H   $��376,639,0,0q�6c   $	��Top=�6x   $	��195��6�   $��39��6�   ���	#FF75BC03
���   �$��18(�6�    J� RenderTransformOrigin$ 	0.7,0.315&�6  ��6�   Z� 6  �� 5   
   -   5        $ btnChangeP2��5      $��Forget password?��6&   $
��Left=�6A   $��325,702,0,0q�6\   $	��Top=�6q   $	��146��6�   
�������
���   �$��20��6�   ��6�   Z� 6�   5      5      