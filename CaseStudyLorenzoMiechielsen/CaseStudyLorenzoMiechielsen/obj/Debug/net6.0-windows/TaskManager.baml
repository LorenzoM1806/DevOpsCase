   M S B A M L   `   `   `  ����V  RCaseStudyLorenzoMiechielsen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CaseStudyLorenzoMiechielsenCaseStudyLorenzoMiechielsen  5   	   -    'CaseStudyLorenzoMiechielsen.TaskManager   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:CaseStudyLorenzoMiechielsen     5   	     � Title$  TaskManager��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� ��6   �� *
TaskName+6.   �� 5   
   -   5         ��Name$ 
cbPriority��5      $��0��6'   $��1��64    �� SelectedItem 6D   �� *
Priority+.@�5      �� $��1 - High Priority��6   69   �� 5      $��2 - Medium Priority��6   6;   �� 5      $��3 - Low Priority��6   68   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dueDatePicker��5      $��2��6,   $��0��6<      SelectedDate 6I   �� *	DueDate+6l   �� 5   
   -   5         ��Name$ 
btnAddTask��5   .   $��3��6   $��0��6!   $��Add Task��6B   $	��Add��6i   ��6U   �� 6�   5      5       