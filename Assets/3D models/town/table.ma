//Maya ASCII 2023 scene
//Name: table.ma
//Last modified: Fri, Feb 10, 2023 04:48:44 PM
//Codeset: 1252
requires maya "2023";
requires "mtoa" "5.1.0";
requires "mtoa" "4.2.4";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2023";
fileInfo "version" "2023";
fileInfo "cutIdentifier" "202202161415-df43006fd3";
fileInfo "osv" "Windows 10 Pro v2009 (Build: 19044)";
fileInfo "UUID" "1FC46795-418D-DC5A-CE84-5C973C182816";
createNode transform -n "pCube13";
	rename -uid "16C8ABF2-40A2-00E2-800E-08A7DE66C4DA";
	setAttr ".t" -type "double3" 34.73119643876548 9.5937027684893454 0 ;
	setAttr ".s" -type "double3" 1.3449407320555882 1.3449407320555882 1.3449407320555882 ;
createNode mesh -n "pCubeShape6" -p "pCube13";
	rename -uid "84766F6A-421D-5DFE-796D-2B954818B3A5";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.875 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode polyAutoProj -n "polyAutoProj1";
	rename -uid "A24EC755-46F3-61EA-3852-E5A2BED4A768";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:61]";
	setAttr ".ix" -type "matrix" 1.3449407320555882 0 0 0 0 1.3449407320555882 0 0 0 0 1.3449407320555882 0
		 34.73119643876548 9.5937027684893454 0 1;
	setAttr ".s" -type "double3" 29.357873353314119 29.357873353314119 29.357873353314119 ;
	setAttr ".ps" 0.20000000298023224;
	setAttr ".dl" yes;
createNode polyTweak -n "polyTweak6";
	rename -uid "055F34CC-46FF-6926-866C-86B51457E300";
	setAttr ".uopa" yes;
	setAttr -s 48 ".tk";
	setAttr ".tk[0]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[1]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[6]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[7]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[8]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[9]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[15]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[16]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[17]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[18]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[19]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[20]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[28]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[29]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[30]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[31]" -type "float3" 0 9.5367432e-07 0 ;
	setAttr ".tk[32]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[33]" -type "float3" 2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[34]" -type "float3" 0 7.1525574e-07 0 ;
	setAttr ".tk[35]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[36]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[37]" -type "float3" 0 7.1525574e-07 0 ;
	setAttr ".tk[38]" -type "float3" 0 7.1525574e-07 1.7881393e-07 ;
	setAttr ".tk[39]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[40]" -type "float3" 0 7.1525574e-07 0 ;
	setAttr ".tk[41]" -type "float3" 0 7.1525574e-07 2.9802322e-07 ;
	setAttr ".tk[42]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[43]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[44]" -type "float3" 0 7.1525574e-07 2.9802322e-07 ;
	setAttr ".tk[45]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[46]" -type "float3" 0 7.1525574e-07 0 ;
	setAttr ".tk[47]" -type "float3" -2.3841858e-07 7.1525574e-07 0 ;
	setAttr ".tk[48]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[49]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[50]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[51]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[52]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[53]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[54]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[55]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[56]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[57]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[58]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[59]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[60]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[61]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[62]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
	setAttr ".tk[63]" -type "float3" 0 -8.8372211 9.5367432e-07 ;
createNode polyExtrudeFace -n "polyExtrudeFace8";
	rename -uid "959CB1DC-4536-111F-8384-BDA4AAF8849D";
	setAttr ".ics" -type "componentList" 4 "f[3]" "f[6]" "f[26]" "f[28]";
	setAttr ".ix" -type "matrix" 1.3449407320555882 0 0 0 0 1.3449407320555882 0 0 0 0 1.3449407320555882 0
		 34.73119643876548 9.5937027684893454 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 48.737663 8.9212332 8.2984352 ;
	setAttr ".rs" 63102;
	setAttr ".c[0]"  0 1 1;
	setAttr ".m23" no;
	setAttr ".cbn" -type "double3" 34.058725752078828 8.9212333644381268 -0.67247036602779409 ;
	setAttr ".cbx" -type "double3" 63.416599105392947 8.9212333644381268 17.269340624142234 ;
createNode polyExtrudeFace -n "polyExtrudeFace7";
	rename -uid "4F8BBEF6-4D42-C561-B263-7C88368F7877";
	setAttr ".ics" -type "componentList" 4 "f[3]" "f[6]" "f[26]" "f[28]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 34.73119643876548 9.5937027684893454 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 45.145386 9.0937033 6.1701121 ;
	setAttr ".rs" 35610;
	setAttr ".c[0]"  0 1 1;
	setAttr ".m23" no;
	setAttr ".cbn" -type "double3" 34.23119643876548 9.0937037221636619 -0.5 ;
	setAttr ".cbx" -type "double3" 56.059573208785011 9.0937037221636619 12.840224266052246 ;
createNode polySplit -n "polySplit16";
	rename -uid "CD21F13A-42B6-B44C-0C45-AB81BFDC3680";
	setAttr -s 9 ".e[0:8]"  0.072663903 0.92733598 0.92733598 0.072663903
		 0.92733598 0.072663903 0.072663903 0.92733598 0.072663903;
	setAttr -s 9 ".d[0:8]"  -2147483642 -2147483627 -2147483606 -2147483641 -2147483625 -2147483610 
		-2147483632 -2147483623 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit15";
	rename -uid "44E3AA01-4EA1-8BB4-B5C4-839925074279";
	setAttr -s 7 ".e[0:6]"  0.96561402 0.034386098 0.96561402 0.96561402
		 0.96561402 0.96561402 0.96561402;
	setAttr -s 7 ".d[0:6]"  -2147483636 -2147483619 -2147483635 -2147483634 -2147483621 -2147483633 
		-2147483636;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit14";
	rename -uid "6FC63353-441D-80E6-B329-B8801C664E60";
	setAttr -s 7 ".e[0:6]"  0.93668997 0.063309498 0.93668997 0.063309498
		 0.93668997 0.063309498 0.93668997;
	setAttr -s 7 ".d[0:6]"  -2147483642 -2147483630 -2147483641 -2147483637 -2147483632 -2147483638 
		-2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit13";
	rename -uid "8E54AF5E-4649-542A-E9E2-BE854A77912F";
	setAttr -s 5 ".e[0:4]"  0.030479901 0.030479901 0.030479901 0.030479901
		 0.030479901;
	setAttr -s 5 ".d[0:4]"  -2147483648 -2147483645 -2147483646 -2147483647 -2147483648;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak5";
	rename -uid "9AF42368-4C93-9981-FF39-9EB2A99E705C";
	setAttr ".uopa" yes;
	setAttr -s 6 ".tk";
	setAttr ".tk[0]" -type "float3" 0 0 12.340224 ;
	setAttr ".tk[1]" -type "float3" 20.828377 0 12.340224 ;
	setAttr ".tk[2]" -type "float3" 0 0 12.340224 ;
	setAttr ".tk[3]" -type "float3" 20.828377 0 12.340224 ;
	setAttr ".tk[5]" -type "float3" 20.828377 0 0 ;
	setAttr ".tk[7]" -type "float3" 20.828377 0 0 ;
createNode polyCube -n "polyCube2";
	rename -uid "32732AAD-4D1D-8F64-08D6-62BDAD479D2D";
	setAttr ".cuv" 4;
createNode materialInfo -n "materialInfo2";
	rename -uid "83D8E862-4E2F-EF69-755B-B0950965AEE9";
createNode shadingEngine -n "blinn1SG";
	rename -uid "3AAB2B7E-46A8-B7A3-3DF5-57A7FE75DF40";
	setAttr ".ihi" 0;
	setAttr -s 8 ".dsm";
	setAttr ".ro" yes;
createNode blinn -n "wood";
	rename -uid "54D0E843-431F-9010-29E9-C0AAA8836938";
createNode file -n "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2";
	rename -uid "9B71F5C0-49E3-106B-CD67-8CBCDEA8BEA8";
	setAttr ".ftn" -type "string" "C:/Users/energ/Downloads/Casa-Padrino-Luxus-Barock-Beistelltisch-Antik-Gold-Prunkvoller-handgefertigter-Tisch-im-Barockstil-Barock-Wohnzimmer-Moebel-116318_5 (1).png.jfif";
	setAttr ".cs" -type "string" "sRGB";
createNode place2dTexture -n "place2dTexture2";
	rename -uid "5723F31A-4B37-422C-7047-C1AFD69BE97C";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "3F37ED1A-4CD1-5353-4475-FC940B9EB85D";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 6 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 2 ".u";
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
	setAttr -s 2 ".tx";
select -ne :initialShadingGroup;
	setAttr -s 9 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 8 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	addAttr -ci true -h true -sn "dss" -ln "defaultSurfaceShader" -dt "string";
	setAttr ".ren" -type "string" "arnold";
	setAttr ".dss" -type "string" "lambert1";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :defaultColorMgtGlobals;
	setAttr ".cfe" yes;
	setAttr ".cfp" -type "string" "<MAYA_RESOURCES>/OCIO-configs/Maya2022-default/config.ocio";
	setAttr ".vtn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".vn" -type "string" "ACES 1.0 SDR-video";
	setAttr ".dn" -type "string" "sRGB";
	setAttr ".wsn" -type "string" "ACEScg";
	setAttr ".otn" -type "string" "ACES 1.0 SDR-video (sRGB)";
	setAttr ".potn" -type "string" "ACES 1.0 SDR-video (sRGB)";
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polyAutoProj1.out" "pCubeShape6.i";
connectAttr "polyTweak6.out" "polyAutoProj1.ip";
connectAttr "pCubeShape6.wm" "polyAutoProj1.mp";
connectAttr "polyExtrudeFace8.out" "polyTweak6.ip";
connectAttr "polyExtrudeFace7.out" "polyExtrudeFace8.ip";
connectAttr "pCubeShape6.wm" "polyExtrudeFace8.mp";
connectAttr "polySplit16.out" "polyExtrudeFace7.ip";
connectAttr "pCubeShape6.wm" "polyExtrudeFace7.mp";
connectAttr "polySplit15.out" "polySplit16.ip";
connectAttr "polySplit14.out" "polySplit15.ip";
connectAttr "polySplit13.out" "polySplit14.ip";
connectAttr "polyTweak5.out" "polySplit13.ip";
connectAttr "polyCube2.out" "polyTweak5.ip";
connectAttr "blinn1SG.msg" "materialInfo2.sg";
connectAttr "wood.msg" "materialInfo2.m";
connectAttr "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.msg" "materialInfo2.t"
		 -na;
connectAttr "wood.oc" "blinn1SG.ss";
connectAttr "pCubeShape6.iog" "blinn1SG.dsm" -na;
connectAttr "pCylinderShape2.iog" "blinn1SG.dsm" -na;
connectAttr "pCube12Shape.iog" "blinn1SG.dsm" -na;
connectAttr "pCylinderShape1.iog" "blinn1SG.dsm" -na;
connectAttr "pCylinderShape3.iog" "blinn1SG.dsm" -na;
connectAttr "pCylinderShape5.iog" "blinn1SG.dsm" -na;
connectAttr "pCylinderShape4.iog" "blinn1SG.dsm" -na;
connectAttr "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.oc" "wood.c"
		;
connectAttr ":defaultColorMgtGlobals.cme" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.cme"
		;
connectAttr ":defaultColorMgtGlobals.cfe" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.cmcf"
		;
connectAttr ":defaultColorMgtGlobals.cfp" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.cmcp"
		;
connectAttr ":defaultColorMgtGlobals.wsn" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.ws"
		;
connectAttr "place2dTexture2.c" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.c"
		;
connectAttr "place2dTexture2.tf" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.tf"
		;
connectAttr "place2dTexture2.rf" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.rf"
		;
connectAttr "place2dTexture2.mu" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.mu"
		;
connectAttr "place2dTexture2.mv" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.mv"
		;
connectAttr "place2dTexture2.s" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.s"
		;
connectAttr "place2dTexture2.wu" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.wu"
		;
connectAttr "place2dTexture2.wv" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.wv"
		;
connectAttr "place2dTexture2.re" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.re"
		;
connectAttr "place2dTexture2.of" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.of"
		;
connectAttr "place2dTexture2.r" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.ro"
		;
connectAttr "place2dTexture2.n" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.n"
		;
connectAttr "place2dTexture2.vt1" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.vt1"
		;
connectAttr "place2dTexture2.vt2" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.vt2"
		;
connectAttr "place2dTexture2.vt3" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.vt3"
		;
connectAttr "place2dTexture2.vc1" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.vc1"
		;
connectAttr "place2dTexture2.o" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.uv"
		;
connectAttr "place2dTexture2.ofs" "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.fs"
		;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
connectAttr "blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "wood.msg" ":defaultShaderList1.s" -na;
connectAttr "place2dTexture2.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "Casa_Padrino_Luxus_Barock_Beistelltisch_Antik_Gold_Prunkvoller_handgefertigter_Tisch_im_Barockstil_Barock_Wohnzimmer_Moebel_116318_5__1__2.msg" ":defaultTextureList1.tx"
		 -na;
// End of table.ma
