   M S B A M L   `   `   `  ����L  HCandidate_WPF_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Candidate_WPF_GUICandidate_WPF_GUI  5      .    (Candidate_WPF_GUI.CandidateProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      1localclr-namespace:Candidate_WPF_GUI     5      -   5          � Title$  JobPostingWindow��5      $	��638��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$
 None=�6_   .��5	      � $��Center=�6   $	��800��6(   $��0,0,0,2q�64   ���	#FFFAB2B2.+�5
   
   �� $"��CANDIDATE PROFILE MANAGEMENT��6   $
��Left=�67   $��
238,32,0,0q�6R   $	��Top=�6f   $��22(�6~   $
��Bold"�6�   ���	#FF1F89AE���	#FFF3EAEA6�   �� 5   
   -   5         ��Name$ lbPostID��5      $��Post ID:��6"   $
��Left=�65   $��110,111,0,0q�6P   $	��Top=�6e   $��14(�6}   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -   5        $ 
lbFullName��5      $��	FullName:��6$   $
��Left=�68   $��103,169,0,0q�6S   $	��Top=�6h   $��14(�6�   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -   5        $ 
lbPostDate��5      $��	BirthDay:��6$   $
��Left=�68   $��101,278,0,0q�6S   $	��Top=�6h   $��14(�6�   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -   5         ��Name$ 	txtPostID��5      $
��Left=�6%   $��29��6@   $��193,111,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��207��6�   �� 5   
   -   5        $ txtFullName��5      $
��Left=�6'   $��29��6B   $��193,169,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��207��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtgBirthDay��5      $
��Left=�6*   $��193,278,0,0q�6E   $	��Top=�6Z   $	��207��6r   $��29��6~   �� 5   
   -   5        $ lbDescription��5      $��Description��6'   $
��Left=�6=   $��470,169,0,0q�6X   $	��Top=�6m   $��14(�6�   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -	   5         ��Name$ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��263,562,0,0q�6P   $	��Top=�6e   $��78��6}   $��15(�6�   ���	#FFE1F410$
��Bold"�6�   6�   �� 5   
   -
   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��460,562,0,0q�6P   $	��Top=�6e   $��78��6}   $��15(�6�   ���	#FF1A40D6$
��Bold"�6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $	��107��6E   $��470,211,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��320��6�   �� 5   
   -   5        $ lbTitle_Copy��5      $��	ImageURL:��6&   $
��Left=�6:   $��
96,221,0,0q�6U   $	��Top=�6i   $��14(�6�   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -   5        $ txtImageURL��5      $
��Left=�6'   $��29��6B   $��193,221,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��207��6�   �� 5   
   $��
JobPosting��6   $
��Left=�6%   $��470,111,0,0q�6@   $	��Top=�6U   ���	#FF9EE060$
��Bold"�6�   �� 5   
   -   5         ��Name$ cbJobPosting��5      $
��Left=�6)   $��29��6D   $��543,108,0,0q�6P   $	��Top=�6e   $	��229��6}   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 
dtgProfile��5      $��Center=�6'   $	��193��6D   $��	0,346,0,0q�6Q   $	��Top=�6d   $	��800��6|   6�   �� 5   
   -   5        $ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
71,562,0,0q�6J   $	��Top=�6^   $��78��6v   $��15(�6�   ���	#FF11E90F$
��Bold"�6�   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��658,562,0,0q�6N   $	��Top=�6c   $��78��6{   $��15(�6�   ���	#FFC2C8E3$
��Bold"�6�   6�   5      5      