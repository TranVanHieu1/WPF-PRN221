   M S B A M L   `   `   `  ����L  HCandidate_WPF_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Candidate_WPF_GUICandidate_WPF_GUI  5   	   (    "Candidate_WPF_GUI.JobPostingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Candidate_WPF_GUI     5   	   -   5          �Name$  jobPostWindow��5   	    � Title$ JobPostingWindow��5   	   $	��638��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`   .��5	      � $��Center=�6   $	��800��6(   $��0,0,0,2q�64    J� OpacityMask �	#FF35E4F1���	#FF20BAA4.+�5
   
   �� $��JOB POSTING MANAGEMENT��6   $
��Left=�61   $��
263,42,0,0q�6L   $	��Top=�6`   $��22(�6x   $
��Bold"�6�   �� 5   
   -   5         ��Name$ lbPostID��5      $��Post ID:��6"   $
��Left=�65   $��
21,107,0,0q�6P   $	��Top=�6d   $��14(�6|   �� 5   
   -   5        $ lbTitle��5      $��Title:��6!   $
��Left=�62   $��
30,169,0,0q�6M   $	��Top=�6a   $��14(�6y   �� 5   
   -   5        $ 
lbPostDate��5      $��
Post Date:��6$   $
��Left=�69   $��
10,217,0,0q�6T   $	��Top=�6h   $��14(�6�   �� 5   
   -   5         ��Name$ 	txtPostID��5      $
��Left=�6%   $��29��6@   $��
83,107,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��207��6�   �� 5   
   -   5        $ txtTile��5      $
��Left=�6#   $��29��6>   $��
83,169,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��207��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtgPostDate��5      $
��Left=�6*   $��
82,231,0,0q�6E   $	��Top=�6Y   $	��207��6q   $��29��6}   �� 5   
   -   5        $ lbDescription��5      $��Description��6'   $
��Left=�6=   $��
-3,276,0,0q�6X   $	��Top=�6l   $��14(�6�   &   System.Windows.Controls.DataGrid  5   
   -	   5        	  Name$	 
dtgJobPost��5      $
��Left=�6'   $	��338��6B   $��347,107,0,0q�6O   $	��Top=�6d   $	��453��6|   6�   �� 5   
   -
   5        
 ��Name$
 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
86,562,0,0q�6J   $	��Top=�6^   $��15(�6v   ���	#FF3CFC22$��69��6�   $
��Bold"�6�   6�   �� 5   
   -   5        $
 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��263,562,0,0q�6P   $	��Top=�6e   $��78��6}   $��15(�6�   ���	#FFE1F410$
��Bold"�6�   6�   �� 5   
   -   5        $
 btnClose��5      $��Close��6#   $
��Left=�63   $��650,562,0,0q�6N   $	��Top=�6c   $��78��6{   $��15(�6�   ���	#FF04D6C6$
��Bold"�6�   6�   �� 5   
   -   5        $
 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��460,562,0,0q�6P   $	��Top=�6e   $��78��6}   $��15(�6�   ���	#FF1A40D6$
��Bold"�6�   6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $	��107��6E   $��
10,318,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��320��6�   5      5      