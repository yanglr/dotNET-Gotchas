                                8                0 	        84   V S _ V E R S I O N _ I N F O     ╜я■               ?                        Ш   S t r i n g F i l e I n f o   t   0 4 0 9 0 4 e 4   J   C o m p a n y N a m e     T O D O :   < C o m p a n y   n a m e >     Z   F i l e D e s c r i p t i o n     T O D O :   < F i l e   d e s c r i p t i o n >     0   F i l e V e r s i o n     1 . 0 . 0 . 1   Д 0  L e g a l C o p y r i g h t   T O D O :   ( c )   < C o m p a n y   n a m e > .     A l l   r i g h t s   r e s e r v e d .   :   I n t e r n a l N a m e   A C O M C o m p . e x e     B   O r i g i n a l F i l e n a m e   A C O M C o m p . e x e     J   P r o d u c t N a m e     T O D O :   < P r o d u c t   n a m e >     4   P r o d u c t V e r s i o n   1 . 0 . 0 . 1   D    V a r F i l e I n f o     $    T r a n s l a t i o n     	фy   0   R E G I S T R Y     e       0 	        HKCR
{
	NoRemove AppID
	{
		'%APPID%' = s 'ACOMComp'
		'ACOMComp.EXE'
		{
			val AppID = s '%APPID%'
		}
	}
}
   O  0   R E G I S T R Y     f       0 	        HKCR
{
	ACOMComp.MyComp.1 = s 'MyComp Class'
	{
		CLSID = s '{E4EB3427-1E60-4EEC-9C6F-3A82F707DE13}'
	}
	ACOMComp.MyComp = s 'MyComp Class'
	{
		CLSID = s '{E4EB3427-1E60-4EEC-9C6F-3A82F707DE13}'
		CurVer = s 'ACOMComp.MyComp.1'
	}
	NoRemove CLSID
	{
		ForceRemove {E4EB3427-1E60-4EEC-9C6F-3A82F707DE13} = s 'MyComp Class'
		{
			ProgID = s 'ACOMComp.MyComp.1'
			VersionIndependentProgID = s 'ACOMComp.MyComp'
			ForceRemove 'Programmable'
			LocalServer32 = s '%MODULE%'
			val AppID = s '%APPID%'
			'TypeLib' = s '{06B486A8-F271-4932-A9BE-F2E12E011A7D}'
		}
	}
}
   ,   T Y P E L I B          0 	        MSFT      	      A                            )                  А             d   L  ╚          d            p            T              А          Ф  └          М            М  l          °  T          L                           T  T          и  $                                        %"  ╠                                     `                                                  4" ╠  P   H                             и   └  ,       ,                                          Р           и                                       `           x                       H                          0   иЖ┤qЄ2Iй╛Єс.}■       e║w▐|Q╤в┌  °w<щ        c║w▐|Q╤в┌  °w<щ        d║w▐|Q╤в┌  °w<щ        '4ыф`ьNЬo:Вў▐        0     └      F             └      F       Ш&ЧЮ╢▀HР╦2XAH╢d       d                    Р   x          - stdole2.tlbWWW                                                                                                                                                                                                    @                                                               X                                                                           ,                                                                                                                                                                                       ▐ACOMCompLibW        8юдMyCompWWd       8T╨IMyCompWd        1;doSomethingW         ┴
pCountWW ACOMComp 1.0 Type LibraryW MyComp ClassWW IMyComp InterfaceW method doSomething @ А >   Created by MIDL version 6.00.0361 at Mon Jan 17 16:42:16 2005
 I?ьAWW i WW           0   D       H   L      ,   ,    А     L 	         @       X         @       0                 0	                 A C O M C o m p                       