   M S B A M L   `   `   `  ???? S  OHaloInfiniteCountDownApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HaloInfiniteCountDownAppHaloInfiniteCountDownApp  )    #HaloInfiniteCountDownApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:HaloInfiniteCountDownApp       ? Title$  
MainWindow??$	??500??$	??800?? ? WindowStyle$
 None=? ? 
ResizeMode$ NoResize=????#181735.???  ? RowDefinitions ?? $??50 ???  ? ColumnDefinitions ?? ?? .+?? -   ???#0f0f2d$??2??$y?Visible=? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? .+??? -   $??TitleTextBlock??$%??HALO INFINITE RELEASE COUNTDOWN??
???????$??0??$??5??$??Center=?$??Center=?$??Calibri)?$??22(??? -   $??CloseButton??
???????$??22(?$??9??$??1??????  ?? 
TargetType" ??.???  ?? Property ? ?? ?? Value$ Calibri)???  ? ?? ?#FF4C70????  ?? 
TargetType" ??.R??? $??40??$??70??	 ?? CornerRadius$	 10??#??z??._??? $??Center=?$??Center=?$??Close???? -   $??ImagePanel1??$??1??$??2??
 ?? Orientation$
 Vertical=?.+??? -   $??MarinesImage??$??/HaloInfiniteMarines.jpg??$y?Hidden=??? -   $??ImagePanel2??$??1??$??2??$
 Vertical=?.+??? -   $??	RingImage??$??/HaloInfiniteRing.png??$y?Hidden=??? -   $??ImagePanel3??$??1??$??2??$
 Vertical=?.+??? -	   $??SpartanHelmetImage??$$??/HaloInfiniteSpartanHelmet.png??$y?Hidden=??? -
   $??ImagePanel4??$??1??$??2??$
 Vertical=?.+??? -   $??MasterChiefImage??$"??/HaloInfiniteMasterChief.jpg?? K? ZIndex$ 1??$y?Visible=?? $??1??$??1?? ?? ?? ?? ?? .+??? -   $$??DaysTillReleaseHeaderTextBlock??$?? Releases in:??$??55??$??Calibri)?$??44(?$??light"?
??????????#181735$y?Visible=?$??20, 0, 10, 0q?$	??Top=?$??3???? -   $??DaysTillReleaseTextBlock??$?? days hrs min s??$??55??$??Calibri)?$??44(?$??Light"?
??????????#181735$y?Visible=?$??20, 0, 10, 10q?$??Bottom=?$??3??