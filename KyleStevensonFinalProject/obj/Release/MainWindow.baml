   M S B A M L   `   `   `  ���� T  PKyleStevensonFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:KyleStevensonFinalProjectKyleStevensonFinalProject  *    $KyleStevensonFinalProject.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:KyleStevensonFinalProject       � Title$  WebPageMaker��$	��900��$
��1200����. $
��Auto=�$
��Auto=� � WindowStartupLocation$ CenterScreen=�.��]� -    ]�Name$ 	dockPanel��$
��Auto��$
��Auto����. .+�o� -    o�Name$
 menu��$��23��$
��Auto��$	��Top=�.@�m� $
��File��$��23��.@�m� -    m�Name$ new_menuItem��$��
Clear Data��m� -   $ create_menuItem��$��Create Webpage���� m� -   $ exit_menuItem��$
��Exit��m� $
��Help��.@�m� -   $ about_menuItem��$��About���� $��	10,0,2,10q�.��� -    �Name$ Grid1����. $
��Auto=�$��0,0,0,20q�$	��Top=� � ColumnDefinitions �� $
��220* ��� $
��195* ��� $
��348* � � RowDefinitions �� $	��34* ��� $	��75* ��� $	��67* ��� $	��43* ��� $	��40* ��� $	��68* ��� �� .+��� -    ��Name$ 	helpLabel��$8��2Fill out the options below to create your website!��$��3��$��0��$��176,0,177,0q�$��Center=�$��Center=�$��18(�$��SemiBold"�$��Center=�$	��Top=�$��34��$	��410���� -	   $ 
titleLabel��$��Website Title:��$��0��$��1��$��Right=�$��5,5,20,5q�$��14(��� -
   	 ��Name$	 	titleText��$��2��$��1��$��1��$��	0,0,50,20q�$��30��$��Center=��� -   $ subTitleLabel��$��
Sub Title:��$��0��$��2��$��Right=�$��5,5,20,5q�$��14(��� -   $	 subTitleText��$��2��$��1��$��2��$��	0,0,50,20q�$��30��$��Center=��� -   $ titleOptionLabel��$��Title Banner:��$��0��$��3��$��Right=�$��5,5,20,5q�$��14(��� -   $ titleOption_colorLabel��$��Color:��$��1��$��3��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$��Center=�$
��Left=��� -   
 ��Name$
 
titleColor�� �� SelectedValuePath$ Content��$��1��$��3��$��Center=�$	��120��$��38��$��Center=�$��Center=�$��Right=�$	��100��$��10q�$��36��$	��0,5q�
���   �.@��� $��Default�� �� 
IsSelected . ���	#FF00D1B2�� $
��Blue�����	#FF209CEE�� $��Green�����	#FF23D160�� $��Yellow�����	#FFFFDD57�� $	��Red�����	#FFFF3860�� $��Light��
��������� $
��Dark�����	#FF363636
��������� -   $ titleOption_sizeLabel��$��Size:��$��2��$��3��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$��Center=�$
��Left=��� -   $
 	titleSize��$ Content��$��2��$��3��$��Center=�$	��120��$��38��$��Center=�$��Center=�$��Center=�$	��100��$��10q�$��36��$��0,5,50,5q�
���   �.@��� $��Medium�� . $��Center=�$��Center=��� $��Large��$��Center=�$��Center=��� $��
Fullheight��$��Center=�$��Center=��� -   $ backgroundColorLabel��$��Page Background Color:��$��0��$��4��$��Right=�$��5,5,20,5q�$��14(��� -   $" backgroundColorLabel_popular��$��Popular Colors:��$��1��$��4��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$��Center=�$
��Left=��� -   $
 backgroundColorSelect��$ Content��$��1��$��4��$��Center=�$	��120��$��35��$��Center=�$��Center=�$��Right=�$	��100��$��10q�$��36��$	��0,5q�.@��� $��White�� . �� $��#b2ad7f�����	#FFB2AD7F�� $��#feb236�����	#FFFEB236�� $��#ff7b25�����	#FFFF7B25�� $��#a2b9bc�����	#FFA2B9BC�� $��#dac292�����	#FFDAC292�� $��#bdcebe�����	#FFBDCEBE�� $��#eca1a6�����	#FFECA1A6�� $��#d5e1df�����	#FFD5E1DF�� -   $ backgroundColorLabel_user��$��Enter your own:��$��2��$��4��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$
��Left=�$��93��$��Center=��� -   $	 backgroundColorText_user��$��2��$��4��$��0,5,50,5q�$��30��$��Center=�$��Center=�$��Center=�$	��160��$��30��$	��160���� -    ��Name$ backgroundColor_HelpBtn��$��2��$��4��$
��Help��$��30��$��Center=�$��Center=�$��50��$��	180,0,0,0q� J� RenderTransformOrigin$ 
0.94,0.567&��� -   $ 	fontLabel��$��
Page Font:��$��0��$��5��$��Right=�$��5,5,20,5q�$��14(��� -   $ fontFamilyLabel��$��Font Family:��$��1��$��5��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$��Center=�$
��Left=��� -   $
 fontFamilySelect��$ Content��$��1��$��5��$��Center=�$	��120��$��35��$��Center=�$��Center=�$��Right=�$	��100��$��10q�$��36��$	��0,5q�$��	open sans)�.@��� $��Default�� . $��Segoe UI)��� $��Calibri��$��Calibri)��� $��
Comic Sans��$��Comic Sans MS)��� $��Courier New��$��Courier New)��� $��Georgia��$��Georgia)��� $
��Lato��$
��Lato)��� $��	Monospace��$��Global Monospace)��� $��	MS Gothic��$��	MS Gothic)��� $��Times New Roman��$��Times New Roman)��� -   $ fontSizeLabel��$��
Font Size:��$��2��$��5��$
��Left=�$��5,5,5,5q�$��12(�$��40,0,0,0q�$
��Left=�$��93��$��Center=��� -   $
 fontSizeSelect��$ Content��$��2��$��5��$��Center=�$	��120��$��35��$��Center=�$��Center=�$��Center=�$	��100��$��10q�$��36��$��0,5,50,5q�
���   �.@��� $��Default�� . $��Center=�$��Center=��� $
��18px��$��Center=�$��Center=��� $
��20px��$��Center=�$��Center=��� $
��22px��$��Center=�$��Center=��� $
��24px��$��Center=�$��Center=��� $
��26px��$��Center=�$��Center=��� $
��28px��$��Center=�$��Center=��� $
��30px��$��Center=�$��Center=��� $��3��$��6��$��10q��� -   $ addSectionBtn��$��7��$��0��$��Add Section��$��Center=�$��Center=�$��10q�$��70,15,64,15q�$��38��$��86��