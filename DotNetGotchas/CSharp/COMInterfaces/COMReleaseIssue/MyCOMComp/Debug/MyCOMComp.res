                                8                0 	        84   V S _ V E R S I O N _ I N F O     ╜я■               ?                        Ш   S t r i n g F i l e I n f o   t   0 4 0 9 0 4 e 4   J   C o m p a n y N a m e     T O D O :   < C o m p a n y   n a m e >     Z   F i l e D e s c r i p t i o n     T O D O :   < F i l e   d e s c r i p t i o n >     0   F i l e V e r s i o n     1 . 0 . 0 . 1   Д 0  L e g a l C o p y r i g h t   T O D O :   ( c )   < C o m p a n y   n a m e > .     A l l   r i g h t s   r e s e r v e d .   <   I n t e r n a l N a m e   M y C O M C o m p . d l l   D   O r i g i n a l F i l e n a m e   M y C O M C o m p . d l l   J   P r o d u c t N a m e     T O D O :   < P r o d u c t   n a m e >     4   P r o d u c t V e r s i o n   1 . 0 . 0 . 1   D    V a r F i l e I n f o     $    T r a n s l a t i o n     	ф{   0   R E G I S T R Y     e       0 	        HKCR
{
	NoRemove AppID
	{
		'%APPID%' = s 'MyCOMComp'
		'MyCOMComp.DLL'
		{
			val AppID = s '%APPID%'
		}
	}
}
 Й  0   R E G I S T R Y     f       0 	        HKCR
{
	MyCOMComp.MyComp.1 = s 'MyComp Class'
	{
		CLSID = s '{F943FD21-B157-4F14-AD74-A97751839D66}'
	}
	MyCOMComp.MyComp = s 'MyComp Class'
	{
		CLSID = s '{F943FD21-B157-4F14-AD74-A97751839D66}'
		CurVer = s 'MyCOMComp.MyComp.1'
	}
	NoRemove CLSID
	{
		ForceRemove {F943FD21-B157-4F14-AD74-A97751839D66} = s 'MyComp Class'
		{
			ProgID = s 'MyCOMComp.MyComp.1'
			VersionIndependentProgID = s 'MyCOMComp.MyComp'
			ForceRemove 'Programmable'
			InprocServer32 = s '%MODULE%'
			{
				val ThreadingModel = s 'Apartment'
			}
			val AppID = s '%APPID%'
			'TypeLib' = s '{F7A31496-AE82-48B7-BF51-15C92FD25B55}'
		}
	}
}
     ,   T Y P E L I B          0 	        MSFT      	      A                            /                  А             d   ╚   P  ,                     $            ь             |  А          №  Ё          @            @  |          ╝  t                                        0  T          Д  $                                        %"  и                                     `                                                  4" и  @   8                             и   └  ,       ,                                  4" ╪  @   8                             └   └  T       P                                 ╪       Р                           `                                   x       и   └           H                          0   ЦгўВо╖H┐Q╔/╥[U■       e║w▐|Q╤в┌  °w<щ        c║w▐|Q╤в┌  °w<щ        d║w▐|Q╤в┌  °w<щ        !¤C∙W▒OнtйwQГЭf        0     └      F             └      F       аГ░СєБяDИ√н█ёЖ\d       ╣°ЯUO&BРHОУq}U╞╚               └      F       d             ╚                     Р        ╪   x          - stdole2.tlbWWW                                                                                                                                                                                                                                                                    @   h                                                                       ,       T                                                                                                                                                                               +╨MyCOMCompLib        8юдMyCompWWd       8T╨IMyCompWd        ASMethod1W╚       8VcIMyComp2╚        BSMethod2W MyCOMComp 1.0 Type Library MyComp ClassWW IMyComp InterfaceW method Method1 IMyComp2 Interface method Method2 >   Created by MIDL version 6.00.0361 at Sun Sep 05 15:28:54 2004
 w;AWW i WW           0   D       H   L               А     4 	          @      @                А     4 	          d      h       2                 0	                	 M y C O M C o m p                         